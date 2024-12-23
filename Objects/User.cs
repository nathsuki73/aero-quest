using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aero_quest.Objects
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {

        }
        public User(int Id, string Name, string Email, string Password) {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
        }

    }
}
