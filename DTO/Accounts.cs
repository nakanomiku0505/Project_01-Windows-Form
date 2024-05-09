using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Accounts
    {
        public string users {  get; set; }
        public string passwords { get; set; }
        public int quyen { get; set; }
        public string Email { get; set; }
        public Accounts() { }
        public Accounts(DataRow row)
        {
            this.users = row["users"].ToString();
            this.passwords = row["password"].ToString();
            this.quyen = Convert.ToInt32(row["quyen"]);
            this.Email = row["email"].ToString();
        }
    }
}
