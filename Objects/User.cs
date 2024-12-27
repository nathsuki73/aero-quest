using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace aero_quest.Objects
{
    class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string ProfileImage { get; set; }

        public Profile() { }
    }
    internal class User
    {
        public static Profile profile;
        public static bool isLoggedIn = false;
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
