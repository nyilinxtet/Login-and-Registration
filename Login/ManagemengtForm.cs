using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class ManagemengtForm : Form
    {
        UserForm form = new UserForm();
        public ManagemengtForm()
        {
            InitializeComponent();
        }
       public  void Display()
        {
            DbUser.DisplayUser("SELECT id , name , email, address , ph ,role , password FROM LoginTb",dataGridView1);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            form.clear();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Display();  
        } 

        private void ManagemengtForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DbUser.DisplayUser("SELECT id , name , email, address , ph ,role , password FROM LoginTb WHERE name LIKE '%"+textBox1.Text +"%' ", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                form.clear();
                form.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.email = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.address = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.ph = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.role = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(); 
                form.password = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.UserInfo();
                form.ShowDialog();
                return;
                
            }
            if (e.ColumnIndex ==1)
            {
                DialogResult dg = MessageBox.Show("Are you sure to delete","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    DbUser.DeleteUser(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
               }
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dh = new Dashboard();
            dh.Show();
            this.Hide();
        }
    }
}
