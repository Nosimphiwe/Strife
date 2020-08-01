using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrifeCode
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static List<UserDetails> _list;
        public Form2(List<UserDetails> list) {
            _list = list;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string cell = txtCell.Text;
            string unit = txtUnit.Text;
            string street = txtStreet.Text;
            string suburb = txtSuburb.Text;
            string zip = txtZip.Text;
            string province = txtProvince.Text;
            string country = txtCountry.Text;
            string password = txtPassword.Text;
            Image profile = picProfile.Image;

            _list.Add(new UserDetails(name, surname, email, cell, unit, street, suburb, zip, province, country, password, profile));
        }

        private void picProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog findFile = new OpenFileDialog();
            findFile.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (findFile.ShowDialog() == DialogResult.OK)
            {
                picProfile.Image = new Bitmap(findFile.FileName);
            }

        }
    }
}
