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
    public partial class MainForm : Form
    {

        public static User mainUser;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

        private void creatAccount_btn_Click(object sender, EventArgs e)
        {
            CreateAccount CA = new CreateAccount();
            CA.Show();
            this.Hide();
        }
    }
}
