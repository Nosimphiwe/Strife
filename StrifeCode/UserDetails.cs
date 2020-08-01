using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrifeCode
{
    class UserDetails
    {
        private string name;
        private string surname;
        private string email;
        private string cell;
        private string unit;
        private string street;
        private string suburb;
        private string province;
        private string country;
        private string password;
        private string zip;
        private Image profile;

        //CTRL .   = encapsulate as fields

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Cell { get => cell; set => cell = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Street { get => street; set => street = value; }
        public string Suburb { get => suburb; set => suburb = value; }
        public string Province { get => province; set => province = value; }
        public string Country { get => country; set => country = value; }
        public string Password { get => password; set => password = value; }
        public string Zip { get => zip; set => zip = value; }
        public Image Profile { get => profile; set => profile = value; }

        //CTRL .   = generator and unclick the non-variables

        public UserDetails(string name, string surname, string email, string cell, string unit, string street, string suburb, string province, string country, string password, string zip, Image profile)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.cell = cell;
            this.unit = unit;
            this.street = street;
            this.suburb = suburb;
            this.province = province;
            this.country = country;
            this.password = password;
            this.zip = zip;
            this.profile = profile;
        }

        public UserDetails()
        {

        }

        public List<UserDetails> GetUserDetails() 
        {
            List<UserDetails> 
            return
        }

    }
}
