using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChatApplication
{
    
    public partial class CreateAccount : Form
    {
        public static string crmobileNumber;
        public static string crpassword;
        public static string crfirstName;
        public static string crlastName;
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void terms_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (terms_chk.Checked)
            {
                next_btn.Visible = true;
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            next_btn.Visible = false;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            crfirstName = fname_txt.Text;
            crlastName = lname_txt.Text;
            crmobileNumber = phoneNumber_txt.Text;
            crpassword = password_txt.Text;

            ProfileDescriptionForm pr = new ProfileDescriptionForm();
            pr.Show();
            this.Hide();
        }
    }
}
