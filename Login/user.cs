using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Login
{
    
   public class user
    {
        public string name;
        public string email;
        public string address;
        public int ph;
        public string role;
        public string password;

        public user(string Name,string Email,string Address,int Ph,string Role,string Password)
        {
            name = Name;
            email = Email;
            address = Address;
            ph = Ph;
            role = Role;
            password = Password;

        }
        
    }
}
