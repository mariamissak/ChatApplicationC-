
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
            this.add_contact_btn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chatrooms_btn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 117);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(466, 715);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(529, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 877);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(60, 117);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(791, 715);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.chatrooms_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.add_contact_btn);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 877);
            this.panel2.TabIndex = 2;
            // 
            // add_contact_btn
            // 
            this.add_contact_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_contact_btn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.add_contact_btn.IconColor = System.Drawing.Color.MediumVioletRed;
            this.add_contact_btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.add_contact_btn.IconSize = 60;
            this.add_contact_btn.Location = new System.Drawing.Point(385, 47);
            this.add_contact_btn.Name = "add_contact_btn";
            this.add_contact_btn.Size = new System.Drawing.Size(100, 73);
            this.add_contact_btn.TabIndex = 9;
            this.add_contact_btn.UseVisualStyleBackColor = true;
            this.add_contact_btn.Click += new System.EventHandler(this.add_contact_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(381, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Contact";
            // 
            // chatrooms_btn
            // 
            this.chatrooms_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatrooms_btn.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.chatrooms_btn.IconColor = System.Drawing.Color.MediumVioletRed;
            this.chatrooms_btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.chatrooms_btn.IconSize = 60;
            this.chatrooms_btn.Location = new System.Drawing.Point(291, 47);
            this.chatrooms_btn.Name = "chatrooms_btn";
            this.chatrooms_btn.Size = new System.Drawing.Size(93, 73);
            this.chatrooms_btn.TabIndex = 11;
            this.chatrooms_btn.UseVisualStyleBackColor = true;
            this.chatrooms_btn.Click += new System.EventHandler(this.chatrooms_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(280, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Chatrooms";
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1420, 877);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}