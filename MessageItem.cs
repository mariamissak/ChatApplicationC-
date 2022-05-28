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
    public partial class MessageItem : UserControl
    {
        MySqlConnection con;
        public MessageItem()
        {
            InitializeComponent();
            
        }

        private Message message;
        public Message Message
        {
            get { return message; }
            set { message = value;  }
        }

        private void MessageItem_Load(object sender, EventArgs e)
        {
            
        }

        public void initializeMessageItem()
        {
            con = new MySqlConnection(MainForm.dbConnStr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select firstName,lastName from users where userId=@uid";
            cmd.Parameters.AddWithValue("@uid", message.UserId);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                user_message_label.Text = dr[0].ToString() + " " + dr[1].ToString();
            }


            dr.Close();
            message_label.Text = message.Text;
            date_time_label.Text = message.MessageStatus.DateTime.ToString();
            if (message.MessageStatus.IsSeen)
            {
                is_seen_label.Text = "Seen";
            }
            else
            {
                is_seen_label.Text = "Delivered";
            }

        }

        private void user_message_label_Click(object sender, EventArgs e)
        {

        }
    }
}
