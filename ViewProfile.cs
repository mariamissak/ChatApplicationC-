using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace ChatApplication
{
    public partial class ViewProfile : Form
    {
        MySqlConnection con;

        string c = "server=localhost;database=chat;uid=root;pwd=root;";
        public ViewProfile()
        {
            InitializeComponent();
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            fname.Text = MainForm.mainUser.FirstName;
            lName.Text = MainForm.mainUser.LastName;
            phoneNumber.Text = MainForm.mainUser.MobileNumber;
            abt_txt.textBox1.Text = MainForm.mainUser.UserDescription.AboutDescription;
            toggleButton1.Checked = MainForm.mainUser.UserDescription.IsVisible;
            circularPictureBox1.Image = MainForm.mainUser.UserDescription.ProfilePicture;
        }

        private void textBoxg1_Load(object sender, EventArgs e)
        {

        }

        private void saveProfileDesc_Click(object sender, EventArgs e)
        {
            MainForm.mainUser.UserDescription.ProfilePicture = circularPictureBox1.Image;
            MainForm.mainUser.UserDescription.AboutDescription = abt_txt.textBox1.Text ;
            MainForm.mainUser.UserDescription.IsVisible = toggleButton1.Checked;

            //mysql code to save to database missing
            con = new MySqlConnection(c);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update users set profilePicture = @prof , aboutDescription = @abt , isVisible = @vis where userid = @userid;";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@prof", MainForm.mainUser.UserDescription.ProfilePicture);
            cmd.Parameters.AddWithValue("@abt", MainForm.mainUser.UserDescription.AboutDescription);
            cmd.Parameters.AddWithValue("@vis", MainForm.mainUser.UserDescription.IsVisible);
            cmd.Parameters.AddWithValue("@userid", MainForm.mainUser.UserId);

            int  r = cmd.ExecuteNonQuery();
            if(r!=-1)
            {
                MessageBox.Show("Changes Saved Successfully");
            }
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fname_Click(object sender, EventArgs e)
        {

        }
    }
}
