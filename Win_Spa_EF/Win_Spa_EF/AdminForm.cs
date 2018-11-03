using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Spa_EF
{
    public partial class AdminForm : Form
    {
        SpaServicesContainer se;
        bool edit = false;

        public AdminForm()
        {
            InitializeComponent();

            se = new SpaServicesContainer();
            try
            {
                se.PurchaseSet.Load();
                dataGridView1.DataSource = se.PurchaseSet.ToList();
            }
            catch { }
            groupBoxCat.Visible = false;
            groupBoxServ.Visible = false;
        }

        private void refreshCombo1()
        {
            try
            {
                comboBox1.DataSource = se.CategorySet.ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
            catch { }
        }
        private void refreshCombo2()
        {
            try
            {
                comboBox2.DataSource = se.CategorySet.ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
            }
            catch { }
        }
        private void refreshCombo3()
        {
            try
            {
                comboBox3.DataSource = ((Category)comboBox2.SelectedItem).Services.ToList();
                comboBox3.DisplayMember = "Name";
                comboBox3.ValueMember = "Id";
            }
            catch { }
        }
        //categories
        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBoxCat.Visible)
                groupBoxCat.Visible = false;
            else
            {
                try
                {
                    se = new SpaServicesContainer();
                    se.CategorySet.Load();
                    refreshCombo1();
                    textBox2.Text = ((Category)comboBox1.SelectedItem).Name;
                }
                catch { }

                groupBoxCat.Visible = true;
            }
        }

        //services
        private void button2_Click(object sender, EventArgs e)
        {
            if (groupBoxServ.Visible)
                groupBoxServ.Visible = false;
            else
            {
                try
                {
                    se = new SpaServicesContainer();
                    se.CategorySet.Load();
                    refreshCombo2();
                    refreshCombo3();
                    groupBoxServ.Visible = true;
                    groupBoxService.Visible = false;
                }
                catch { }
            }
        }

        //add category
        private void buttonAddCat_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Name = textBox1.Text;
            var results = new List<ValidationResult>();
            var context = new ValidationContext(c);
            if (!Validator.TryValidateObject(c, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
            }
            else
            {
                se.CategorySet.Add(c);
                se.SaveChanges();
                refreshCombo1();
                textBox1.Text = string.Empty;
            }
        }

        //delete category
        private void buttonDeleteCat_Click(object sender, EventArgs e)
        {
            Category c = (Category)comboBox1.SelectedItem;
            if (c != null && c.Services.Count == 0)
            {
                se.CategorySet.Remove(c);
                se.SaveChanges();
                refreshCombo1();
            }
            else
                MessageBox.Show("Категория не может быть удалена!");
        }

        //edit category
        private void buttonEditCat_Click(object sender, EventArgs e)
        {
            Category c = (Category)comboBox1.SelectedItem;
            if (c != null && c.Services.Count == 0)
            {
                c.Name = textBox2.Text;
                var results = new List<ValidationResult>();
                var context = new ValidationContext(c);
                if (!Validator.TryValidateObject(c, context, results, true))
                {
                    foreach (var error in results)
                    {
                        MessageBox.Show(error.ErrorMessage);
                    }
                }
                else
                {
                    se.SaveChanges();
                    refreshCombo1();
                    textBox2.Text = string.Empty;
                }
            }
            else
                MessageBox.Show("Категория не может быть переименована!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = ((Category)comboBox1.SelectedItem).Name;
        }


        //add service
        private void buttonAddS_Click(object sender, EventArgs e)
        {
            groupBoxService.Text = "Add service";
            groupBoxService.Visible = true;
            textBox3.Text = string.Empty;
            textBox4.Text = "0";
            textBox5.Text = "0";
        }
        //edit service
        private void buttonEditS_Click(object sender, EventArgs e)
        {
            groupBoxService.Visible = true;
            groupBoxService.Text = "Edit service";
            edit = true;

            Services s = (Services)comboBox3.SelectedItem;
            textBox3.Text = s.Name;
            textBox4.Text = s.Duration.ToString();
            textBox5.Text = s.Price.ToString();

        }

        //delete service
        private void buttonDeleteS_Click(object sender, EventArgs e)
        {
            Services s = (Services)comboBox3.SelectedItem;
            if (s != null)
            {
                se.Entry(s).State = EntityState.Deleted;
                se.SaveChanges();
                refreshCombo3();
            }
            else
                MessageBox.Show("Услуга не может быть удалена!");

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Services s;
            if (edit)
                s = (Services)comboBox3.SelectedItem;
            else
                s = new Services();

            s.Name = textBox3.Text;
            s.Price = double.Parse(textBox5.Text);
            s.Duration = Int32.Parse(textBox4.Text);
            s.IdCat = ((Category)comboBox2.SelectedItem).Id;
            var results = new List<ValidationResult>();
            var context = new ValidationContext(s);
            if (!Validator.TryValidateObject(s, context, results, true))
            {
                foreach (var error in results)
                    MessageBox.Show(error.ErrorMessage);
            }
            else
            {
                if (!edit)
                    se.ServicesSet.Add(s);
                se.SaveChanges();

                groupBoxService.Visible = false;
                edit = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.DataSource = null;
            groupBoxService.Visible = false;
            refreshCombo3();
        }
    }
}
