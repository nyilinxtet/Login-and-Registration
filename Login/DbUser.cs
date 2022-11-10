using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
   public class DbUser
    {
        public static SqlConnection Getconnection()
        {
           SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q1GM20T\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
            return con;
        }

        public static void AddUser(user us)
        {
            SqlConnection con = Getconnection();
            con.Open();
            SqlCommand com = new SqlCommand("INSERT INTO LoginTb VALUES (@name,@email,@address,@ph,@role,@password) ", con);
            com.CommandType = System.Data.CommandType.Text;
            com.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = us.name;
            com.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = us.email;
            com.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value = us.address;
            com.Parameters.Add("@ph", System.Data.SqlDbType.Int).Value = us.ph;
            com.Parameters.Add("@role", System.Data.SqlDbType.VarChar).Value = us.role;
            com.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = us.password;
            try
            {
                MessageBox.Show("Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                com.ExecuteNonQuery();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateUser(user us,string id)
        {
            SqlConnection con = Getconnection();
            con.Open();
            SqlCommand com = new SqlCommand("UPDATE LoginTb SET name = @name ,email = @email, address = @address, ph = @ph, role = @role, password = @password WHERE id = @id", con);
            com.CommandType = CommandType.Text;
            com.Parameters.Add("@id ", System.Data.SqlDbType.Int).Value = id;
            com.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = us.name;
            com.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = us.email;
            com.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value = us.address;
            com.Parameters.Add("@ph", System.Data.SqlDbType.Int).Value = us.ph;
            com.Parameters.Add("@role", System.Data.SqlDbType.VarChar).Value = us.role;
            com.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = us.password;
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void DeleteUser(string id)
        {
            SqlConnection con = Getconnection();
            con.Open();
            SqlCommand com = new SqlCommand("DELETE FROM LoginTB WHERE Id = @id", con)
            {
                CommandType = System.Data.CommandType.Text
            };
            com.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public static void DisplayUser(string query , DataGridView dgv)
        {
            
            SqlConnection con = Getconnection();
            con.Open();
            SqlCommand com = new SqlCommand(query,con);
            SqlDataAdapter adp = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgv.DataSource = dt;
            con.Close();
            
        }
    }
}
