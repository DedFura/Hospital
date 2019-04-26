using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Patient : IAccount, IEntity
    {
        public long Id { get; set; }    
        public string Name { get; set; }
        public string Password { get; set; }

        private readonly bool getIsAdmin;

        private bool GetGetIsAdmin()
        {
            return getIsAdmin;
        }

        public Patient (string name, string password)
        {
            Name = name;
            Password = password;
        }

     
    }
}
