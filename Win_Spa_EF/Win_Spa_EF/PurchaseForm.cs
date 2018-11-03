using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Spa_EF
{
    public partial class PurchaseForm : Form
    {
        SpaServicesContainer se;

        public PurchaseForm()
        {
            InitializeComponent();

            se = new SpaServicesContainer();
            try
            {
                se.CategorySet.Load();
                comboBox1.DataSource = se.CategorySet.ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
            catch { }
            dateTimePicker1.Value = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            p.PersonName = textBox1.Text + " " + textBox2.Text;
            p.PhoneNum = textBox3.Text;
            p.Date = dateTimePicker1.Value;
            p.IdService = (int)comboBox2.SelectedValue;
            var results = new List<ValidationResult>();
            var context = new ValidationContext(p);
            if (!Validator.TryValidateObject(p, context, results, true))
            {
                foreach (var error in results)
                    MessageBox.Show(error.ErrorMessage);
            }
            else
            {
                se.PurchaseSet.Add(p);
                se.SaveChanges();
                MessageBox.Show("Дякуємо за замовлення!");
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            se.ServicesSet.Load();
            comboBox2.DataSource = ((Category)comboBox1.SelectedItem).Services.ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";

        }
    }
}
