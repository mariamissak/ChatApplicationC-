using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using ChatApplication;
using System.IO;

namespace ChatApplication
{
    public partial class MainForm : Form
    {
        

        public static User mainUser;
        public static string dbConnStr = "server=sql11.freesqldatabase.com;database=sql11495725;uid=sql11495725;pwd=iDswq8DKc8; Convert Zero Datetime=True";
        public MainForm()
        {
            InitializeComponent();
        }
        public static void Load_Database()
        {
            MySqlConnection con = new MySqlConnection(MainForm.dbConnStr); ;
            
            MySqlConnection con2;
            MySqlConnection con3;
            MySqlConnection con4;
            MySqlConnection con5;
            MySqlConnection con6;

            con2 = new MySqlConnection(MainForm.dbConnStr);
            con3 = new MySqlConnection(MainForm.dbConnStr);
            con4 = new MySqlConnection(MainForm.dbConnStr);
            con5 = new MySqlConnection(MainForm.dbConnStr);
            con6 = new MySqlConnection(MainForm.dbConnStr);

            con.Open();
            con2.Open();
            con3.Open();
            con4.Open();
            con5.Open();
            con6.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM chatrooms ch, chatroomusers chu WHERE chu.userid = @uid and ch.ChatRoomId = chu.chatroomId order by lastdate desc; ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@uid", MainForm.mainUser.UserId);
            MySqlDataReader chatroomsOfMainUser = cmd.ExecuteReader();
            while (chatroomsOfMainUser.Read())
            { 
                    MySqlCommand cmd3 = new MySqlCommand();
                    cmd3.Connection = con3;
                    cmd3.CommandText = "select * from chatroomusers where chatroomid = @chid ";
                    cmd3.CommandType = CommandType.Text;
                    cmd3.Parameters.AddWithValue("@chid", chatroomsOfMainUser[0]);
                    MySqlDataReader allUsersInChatRoom = cmd3.ExecuteReader();
                    List<User> listOfUsers = new List<User>();
                    while (allUsersInChatRoom.Read())
                    {
                        MySqlCommand cmd4 = new MySqlCommand();
                        cmd4.Connection = con4;
                        cmd4.CommandText = "select * from users where userid = @uid";
                        cmd4.CommandType = CommandType.Text;
                        cmd4.Parameters.AddWithValue("@uid", allUsersInChatRoom[1]);
                        MySqlDataReader userDetailsInChatROOM = cmd4.ExecuteReader();
                        if (userDetailsInChatROOM.Read())
                        {
                            Image prof;
                            if (Convert.IsDBNull(userDetailsInChatROOM[7]))
                            {

                                listOfUsers.Add(new User(Convert.ToInt64(userDetailsInChatROOM[0].ToString()), userDetailsInChatROOM[1].ToString(), userDetailsInChatROOM[2].ToString(), userDetailsInChatROOM[3].ToString(), userDetailsInChatROOM[4].ToString(), userDetailsInChatROOM[5].ToString(), Convert.ToBoolean(userDetailsInChatROOM[6])));
                            }
                            else
                            {
                                byte[] img = (byte[])userDetailsInChatROOM[7];
                                MemoryStream ms = new MemoryStream(img);
                                prof = Image.FromStream(ms);
                                listOfUsers.Add(new User(Convert.ToInt64(userDetailsInChatROOM[0].ToString()), userDetailsInChatROOM[1].ToString(), userDetailsInChatROOM[2].ToString(), userDetailsInChatROOM[3].ToString(), userDetailsInChatROOM[4].ToString(), prof, userDetailsInChatROOM[5].ToString(), Convert.ToBoolean(userDetailsInChatROOM[6])));
                            }
                        }
                        userDetailsInChatROOM.Close();
                    }
                    allUsersInChatRoom.Close();
                    ChatRoom ch = new ChatRoom(Convert.ToInt64(chatroomsOfMainUser[0].ToString()), Convert.ToBoolean(chatroomsOfMainUser[1]), listOfUsers, Convert.ToDateTime(chatroomsOfMainUser["lastDate"]));
                    MainForm.mainUser.ChatRoomsList.Append(ch);
                    

                    MySqlCommand cmd5 = new MySqlCommand();
                    cmd5.Connection = con6;
                    cmd5.CommandText = "select * from messages where chatroomid = @chatroomid";
                    cmd5.CommandType = CommandType.Text;
                    cmd5.Parameters.AddWithValue("@chatroomid", Convert.ToInt64(chatroomsOfMainUser[0].ToString()));

                    MySqlDataReader dr = cmd5.ExecuteReader();

                    while (dr.Read())
                    {
                       ch.LastDate = Convert.ToDateTime(dr["timeSent"]);
                       ch.MessageStack.Push(new
                            Message(Convert.ToInt64(dr[0].ToString()),
                                    Convert.ToInt64(dr[1].ToString()),
                                    dr[3].ToString(),
                                    Convert.ToInt64(dr[2].ToString()),
                                    Convert.ToDateTime(dr["timeSent"]),
                                    Convert.ToBoolean(dr["isSeen"]))
                            );
                    }

                dr.Close();
                }
                chatroomsOfMainUser.Close();

            //get contacts
            if (MainForm.mainUser.Contacts.Count == 0)
            {
                MySqlCommand cmd5 = new MySqlCommand();
                cmd5.Connection = con5;
                cmd5.CommandText = "select * from users,contacts where contacts.userid=@uid and contacts.phonenumber=users.phonenumber;";
                cmd5.Parameters.AddWithValue("@uid", MainForm.mainUser.UserId);
                MySqlDataReader d = cmd5.ExecuteReader();
                while (d.Read())
                {
                    Image prof2;
                    if (Convert.IsDBNull(d[7]))
                    {
                        MainForm.mainUser.Contacts.Add(d[1].ToString(), new User(Convert.ToInt64(d[0].ToString()), d[1].ToString(), d[2].ToString(), d[3].ToString(), d[4].ToString(), d[5].ToString(), Convert.ToBoolean(d[6])));

                    }
                    else
                    {

                        byte[] img2 = (byte[])d[7];
                        MemoryStream ms2 = new MemoryStream(img2);
                        prof2 = Image.FromStream(ms2);
                        MainForm.mainUser.Contacts.Add(d[1].ToString(), new User(Convert.ToInt64(d[0].ToString()), d[1].ToString(), d[2].ToString(), d[3].ToString(), d[4].ToString(), prof2, d[5].ToString(), Convert.ToBoolean(d[6])));
                    }
                }
                d.Close();
            }
            con.Dispose();
            con2.Dispose();
            con3.Dispose();
            con4.Dispose();
            con5.Dispose();

            
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

        public static bool checkMutualContact(User contact)
        {
            // handy lil null check
            if (mainUser == null || contact == null)
            {
                return false;
            }

            if (contact.UserDescription.IsVisible)
            {
                return true;
            }

            MySqlConnection con = new MySqlConnection(dbConnStr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from contacts where userId = @id and phonenumber = @ph";
            cmd.Parameters.AddWithValue("@id", contact.UserId);
            cmd.Parameters.AddWithValue("@ph", mainUser.MobileNumber);

            MySqlDataReader dr = cmd.ExecuteReader();

            bool res = false;

            if (dr.Read())
            {
                res = true;
            }

            dr.Close();
            con.Dispose();


            return res;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            Application.Exit();
        }
    }
}
