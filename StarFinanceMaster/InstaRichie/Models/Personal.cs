using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartFinance.Models
{
    class Personal
    {
        [PrimaryKey, AutoIncrement]
        public int PersonalID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
}
