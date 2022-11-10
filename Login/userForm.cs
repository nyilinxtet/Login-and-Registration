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
    public partial class UserForm : Form
    {
      
        public UserForm()
        {
            InitializeComponent();
        }


        public string name, address, email, ph, role, password, id;
        public void UserInfo()
        {
            label1.Text = "Update user";
            btnAdd.Text = "Update";
            txtName.Text = name;
            txtAddress.Text = address;
            txtEmail.Text = email;
            txtPassword.Text= password;
            txtPhone.Text = ph;
            comRole.Text = role;          
        }

        //Clear text box
        public void clear()
        {
          comRole.Text=txtAddress.Text = txtEmail.Text = txtName.Text = txtPassword.Text = txtPhone.Text = string.Empty;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Add new user
            
                
                bool hasSpaceName = txtName.Text.Trim().Length == 0;
                bool hasSpaceEmail = txtEmail.Text.Trim().Length == 0;
                bool hasSpaceAddress = txtAddress.Text.Trim().Length == 0;
                bool hasSpacePhone = txtPhone.Text.Trim().Length == 0;
                bool hasSpaceRole = comRole.Text.Trim().Length == 0;
                bool hasSpacePassword = txtPassword.Text.Trim().Length == 0;
                try
                {

                    if (!(hasSpaceAddress) && !(hasSpaceName) && !(hasSpaceEmail) && !(hasSpaceName) && !(hasSpacePhone) && !(hasSpaceRole) && !(hasSpacePassword))
                    {
                        user us = new user(txtName.Text, txtEmail.Text, txtAddress.Text, int.Parse(txtPhone.Text), comRole.Text, txtPassword.Text);
                        DbUser.AddUser(us);
                        clear();
                        ManagemengtForm form = new ManagemengtForm();
                        form.Display();

                    }
                    else
                    {
                        MessageBox.Show("Invaild Error ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            

            //Update User
             if (btnAdd.Text == "Update")
            {
                user us = new user(txtName.Text, txtEmail.Text, txtAddress.Text, int.Parse(txtPhone.Text), comRole.Text, txtPassword.Text);
                DbUser.UpdateUser(us,id);
                clear();
                this.Hide();
            }
       
        }
    }
}
