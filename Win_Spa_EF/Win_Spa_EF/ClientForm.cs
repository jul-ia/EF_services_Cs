using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Spa_EF
{
    public partial class ClientForm : Form
    {
        SpaServicesContainer se;

        public ClientForm()
        {
            InitializeComponent();
            se = new SpaServicesContainer();
            try
            {
                se.CategorySet.Load();
            }
            catch { }
            comboBox1.DataSource = se.CategorySet.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = ((Category)comboBox1.SelectedItem).Services.ToList();
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns["Category"].Visible = false;
            }
            catch { }
        }

        //purchase
        private void button1_Click(object sender, EventArgs e)
        {
            PurchaseForm pf = new PurchaseForm();
            this.Visible = false;
            pf.ShowDialog();
            this.Visible = true;
        }
    }
}
