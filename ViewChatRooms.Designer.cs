
namespace ChatApplication
{
    partial class ViewChatRooms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.user_prof_btn = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.logout_btn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.message_box = new ChatApplication.TextBoxG();
            this.messagesList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.send_icon_btn = new FontAwesome.Sharp.IconButton();
            this.participants_btn = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.customDropdownMenu1 = new ChatApplication.CustomDropdownMenu(this.components);
            this.viewInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.customDropdownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 117);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(451, 715);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.user_prof_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 1050);
            this.panel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(15, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Contacts";
            this.label7.Visible = false;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconButton3.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton3.IconSize = 50;
            this.iconButton3.Location = new System.Drawing.Point(19, 59);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(79, 59);
            this.iconButton3.TabIndex = 15;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            this.iconButton3.MouseHover += new System.EventHandler(this.iconButton3_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(103, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stories";
            this.label6.Visible = false;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.iconButton2.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 50;
            this.iconButton2.Location = new System.Drawing.Point(97, 59);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(93, 59);
            this.iconButton2.TabIndex = 13;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            this.iconButton2.MouseHover += new System.EventHandler(this.iconButton2_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(177, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "View Profile";
            this.label4.Visible = false;
            // 
            // user_prof_btn
            // 
            this.user_prof_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_prof_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_prof_btn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.user_prof_btn.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.user_prof_btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.user_prof_btn.IconSize = 60;
            this.user_prof_btn.Location = new System.Drawing.Point(187, 59);
            this.user_prof_btn.Name = "user_prof_btn";
            this.user_prof_btn.Size = new System.Drawing.Size(97, 59);
            this.user_prof_btn.TabIndex = 0;
            this.user_prof_btn.UseVisualStyleBackColor = true;
            this.user_prof_btn.Click += new System.EventHandler(this.user_prof_btn_Click);
            this.user_prof_btn.MouseHover += new System.EventHandler(this.user_prof_btn_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(291, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Logout";
            this.label3.Visible = false;
            // 
            // logout_btn
            // 
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.logout_btn.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.logout_btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.logout_btn.IconSize = 60;
            this.logout_btn.Location = new System.Drawing.Point(281, 59);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(97, 60);
            this.logout_btn.TabIndex = 10;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            this.logout_btn.MouseHover += new System.EventHandler(this.logout_btn_MouseHover);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(373, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add Chatroom";
            this.label2.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Navy;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 60;
            this.iconButton1.Location = new System.Drawing.Point(373, 59);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(97, 60);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            this.iconButton1.MouseHover += new System.EventHandler(this.iconButton1_MouseHover);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // message_box
            // 
            this.message_box.BackColor = System.Drawing.SystemColors.Window;
            this.message_box.BorderColor = System.Drawing.Color.DeepPink;
            this.message_box.BorderFocusColor = System.Drawing.Color.HotPink;
            this.message_box.BorderRadius = 0;
            this.message_box.BorderSize = 2;
            this.message_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.message_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.message_box.Location = new System.Drawing.Point(551, 778);
            this.message_box.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.message_box.Multiline = true;
            this.message_box.Name = "message_box";
            this.message_box.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.message_box.PasswordChar = false;
            this.message_box.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.message_box.PlaceholderText = "";
            this.message_box.Size = new System.Drawing.Size(789, 49);
            this.message_box.TabIndex = 5;
            this.message_box.Texts = "";
            this.message_box.UnderlinedStyle = false;
            // 
            // messagesList
            // 
            this.messagesList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.messagesList.BackgroundImageTiled = true;
            this.messagesList.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messagesList.HideSelection = false;
            this.messagesList.Location = new System.Drawing.Point(551, 117);
            this.messagesList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messagesList.Name = "messagesList";
            this.messagesList.Size = new System.Drawing.Size(787, 649);
            this.messagesList.TabIndex = 6;
            this.messagesList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(551, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chat Room Title";
            // 
            // send_icon_btn
            // 
            this.send_icon_btn.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.send_icon_btn.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.send_icon_btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.send_icon_btn.IconSize = 50;
            this.send_icon_btn.Location = new System.Drawing.Point(1275, 778);
            this.send_icon_btn.Name = "send_icon_btn";
            this.send_icon_btn.Size = new System.Drawing.Size(65, 49);
            this.send_icon_btn.TabIndex = 10;
            this.send_icon_btn.UseVisualStyleBackColor = true;
            this.send_icon_btn.Click += new System.EventHandler(this.send_icon_btn_Click);
            // 
            // participants_btn
            // 
            this.participants_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.participants_btn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.participants_btn.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.participants_btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.participants_btn.IconSize = 60;
            this.participants_btn.Location = new System.Drawing.Point(1238, 41);
            this.participants_btn.Name = "participants_btn";
            this.participants_btn.Size = new System.Drawing.Size(99, 77);
            this.participants_btn.TabIndex = 11;
            this.participants_btn.UseVisualStyleBackColor = true;
            this.participants_btn.Click += new System.EventHandler(this.participants_btn_Click);
            this.participants_btn.MouseHover += new System.EventHandler(this.participants_btn_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1207, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "View Participants";
            this.label5.Visible = false;
            // 
            // customDropdownMenu1
            // 
            this.customDropdownMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.customDropdownMenu1.IsMainMenu = false;
            this.customDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInfoToolStripMenuItem,
            this.deleteMessageToolStripMenuItem});
            this.customDropdownMenu1.MenuItemHeight = 25;
            this.customDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.customDropdownMenu1.Name = "customDropdownMenu1";
            this.customDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.customDropdownMenu1.Size = new System.Drawing.Size(210, 68);
            // 
            // viewInfoToolStripMenuItem
            // 
            this.viewInfoToolStripMenuItem.Name = "viewInfoToolStripMenuItem";
            this.viewInfoToolStripMenuItem.Size = new System.Drawing.Size(209, 32);
            this.viewInfoToolStripMenuItem.Text = "View Info";
            // 
            // deleteMessageToolStripMenuItem
            // 
            this.deleteMessageToolStripMenuItem.Name = "deleteMessageToolStripMenuItem";
            this.deleteMessageToolStripMenuItem.Size = new System.Drawing.Size(209, 32);
            this.deleteMessageToolStripMenuItem.Text = "Delete Message";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(573, 141);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(739, 601);
            this.flowLayoutPanel2.TabIndex = 14;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // ViewChatRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1712, 1050);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.participants_btn);
            this.Controls.Add(this.send_icon_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messagesList);
            this.Controls.Add(this.message_box);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewChatRooms";
            this.Text = "ViewChatRooms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewChatRooms_FormClosing);
            this.Load += new System.EventHandler(this.ViewChatRooms_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.customDropdownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private TextBoxG message_box;
        private System.Windows.Forms.ListView messagesList;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton send_icon_btn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton logout_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton user_prof_btn;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton participants_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconButton2;
        private CustomDropdownMenu customDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMessageToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}