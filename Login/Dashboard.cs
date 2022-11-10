using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult Dia = MessageBox.Show("Are you sure to LogOut", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);  
            if (Dia == DialogResult.OK)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();  
            }
            else
            {
                this.Show();
            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            if (MyConncetion.type == "A")
            {
                btnItem.Visible = true;
                btnUserAcc.Visible = true;
                btnSale.Visible = true;
            }
            else
            {
                btnSale.Visible = true;
                btnItem.Visible = false;
                btnUserAcc.Visible = false;
            }

        }

        private void btnUserAcc_Click(object sender, EventArgs e)
        {
            ManagemengtForm form = new ManagemengtForm();
            form.Show();
            this.Hide();
        }
    }
}
