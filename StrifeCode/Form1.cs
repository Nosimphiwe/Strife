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
    public partial class Form1 : Form
    {
        List<UserDetails> userDetails = new List<UserDetails>();
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            userDetails.Add(new UserDetails());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string signName = txtName.Text;
            string signPass = txtPassword.Text;

            foreach (UserDetails item in userDetails)
            {
                if (item.Name == signName && item.Password == signPass)
                {
                    this.Hide();
                    Form3 form = new Form3();
                    form.Show();
                }
                else {
                    MessageBox.Show("Please reenter sign in details");
                    txtName.Clear();
                    txtPassword.Clear();
                }
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }
    }
}
