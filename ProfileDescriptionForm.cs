using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChatApplication;

namespace ChatApplication
{
    public partial class ProfileDescriptionForm : Form
    {
         String PhotoPath;
         String PhotoName;
         String FileType;
         String AboutDescription;
         Boolean IsVisible;
        public ProfileDescriptionForm()
        {
            InitializeComponent();
        }

        private void ProfileDescriptionForm_Load(object sender, EventArgs e)
        {
            fnameUser_label.Text = CreateAccount.crfirstName;
            lnameUser_label.Text = CreateAccount.crlastName;

        }

        private void createAccount_btn_Click(object sender, EventArgs e)
        {
            PhotoPath = profilePicture.ImageLocation;
            IsVisible = isVisible_toggle.Checked;
            AboutDescription = about_txt.Text;
            //photo details to be continued
            MainForm.mainUser = new User(CreateAccount.crmobileNumber, CreateAccount.crpassword, CreateAccount.crfirstName, CreateAccount.crlastName, PhotoName, PhotoPath, FileType, AboutDescription, IsVisible);
        }
    }
}
