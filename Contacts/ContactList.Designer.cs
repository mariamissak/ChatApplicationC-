
namespace ChatApplication.Contacts
{
    partial class ContactList
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.chatrooms_btn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.add_contact_btn = new FontAwesome.Sharp.IconButton();
            this.newGroupChatButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(326, 429);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(370, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 526);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(42, 70);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(554, 429);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.newGroupChatButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.chatrooms_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.add_contact_btn);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 526);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(196, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Chatrooms";
            // 
            // chatrooms_btn
            // 
            this.chatrooms_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatrooms_btn.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.chatrooms_btn.IconColor = System.Drawing.Color.MediumVioletRed;
            this.chatrooms_btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.chatrooms_btn.IconSize = 60;
            this.chatrooms_btn.Location = new System.Drawing.Point(204, 28);
            this.chatrooms_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chatrooms_btn.Name = "chatrooms_btn";
            this.chatrooms_btn.Size = new System.Drawing.Size(65, 44);
            this.chatrooms_btn.TabIndex = 11;
            this.chatrooms_btn.UseVisualStyleBackColor = true;
            this.chatrooms_btn.Click += new System.EventHandler(this.chatrooms_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(267, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Contact";
            // 
            // add_contact_btn
            // 
            this.add_contact_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_contact_btn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.add_contact_btn.IconColor = System.Drawing.Color.MediumVioletRed;
            this.add_contact_btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.add_contact_btn.IconSize = 60;
            this.add_contact_btn.Location = new System.Drawing.Point(270, 28);
            this.add_contact_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_contact_btn.Name = "add_contact_btn";
            this.add_contact_btn.Size = new System.Drawing.Size(70, 44);
            this.add_contact_btn.TabIndex = 9;
            this.add_contact_btn.UseVisualStyleBackColor = true;
            this.add_contact_btn.Click += new System.EventHandler(this.add_contact_btn_Click);
            // 
            // newGroupChatButton
            // 
            this.newGroupChatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGroupChatButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.newGroupChatButton.IconColor = System.Drawing.Color.MediumVioletRed;
            this.newGroupChatButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.newGroupChatButton.IconSize = 60;
            this.newGroupChatButton.Location = new System.Drawing.Point(130, 28);
            this.newGroupChatButton.Margin = new System.Windows.Forms.Padding(2);
            this.newGroupChatButton.Name = "newGroupChatButton";
            this.newGroupChatButton.Size = new System.Drawing.Size(70, 44);
            this.newGroupChatButton.TabIndex = 14;
            this.newGroupChatButton.UseVisualStyleBackColor = true;
            this.newGroupChatButton.Click += new System.EventHandler(this.newGroupChatButton_Click);
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(994, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ContactList";
            this.Text = "ContactList";
            this.Load += new System.EventHandler(this.ContactList_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private FontAwesome.Sharp.IconButton add_contact_btn;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton chatrooms_btn;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton newGroupChatButton;
    }
}