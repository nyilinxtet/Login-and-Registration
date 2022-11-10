using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q1GM20T\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userEmail = txt_email.Text;
            string password = txt_password.Text;

            try
            {
                con.Open();
                string query = "SELECT* FROM LoginTb WHERE email = '"+txt_email.Text +"' AND password = '"+txt_password.Text +"'";
                SqlDataAdapter adp = new SqlDataAdapter(query,con);
                DataTable db = new DataTable();
                adp.Fill(db);

                if (db.Rows.Count > 0)
                {

                    for (int i = 0; i < db.Rows.Count; i++)
                    {
                        if (db.Rows[i]["role"].ToString() == "admin")
                        {
                            MyConncetion.type = "A";

                        }
                        else
                        {
                            MyConncetion.type = "u";
                        }
                    }
                    Dashboard dash = new Dashboard();
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Detail","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txt_email.Clear();
                    txt_password.Clear();

                    txt_email.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Dia = MessageBox.Show("Are you sure to exit!","",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (Dia == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                txt_password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_password.UseSystemPasswordChar = false;
            }
        }
    }
}
