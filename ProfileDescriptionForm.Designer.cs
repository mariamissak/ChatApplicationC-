﻿
namespace ChatApplication
{
    partial class ProfileDescriptionForm
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
            this.profilePicture = new ChatApplication.CircularPictureBox();
            this.profilePicture_btn = new ChatApplication.RoundedButton();
            this.about_txt = new ChatApplication.TextBoxG();
            this.label1 = new System.Windows.Forms.Label();
            this.isVisible_toggle = new ChatApplication.ToggleButton();
            this.visible_label = new System.Windows.Forms.Label();
            this.fname_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.fnameUser_label = new System.Windows.Forms.Label();
            this.lnameUser_label = new System.Windows.Forms.Label();
            this.createAccount_btn = new ChatApplication.RoundedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePicture
            // 
            this.profilePicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.profilePicture.BorderColor = System.Drawing.Color.RoyalBlue;
            this.profilePicture.BorderColor2 = System.Drawing.Color.HotPink;
            this.profilePicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profilePicture.BorderSize = 2;
            this.profilePicture.GradientAngle = 50F;
            this.profilePicture.Location = new System.Drawing.Point(42, 25);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(227, 227);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // profilePicture_btn
            // 
            this.profilePicture_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.profilePicture_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.profilePicture_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.profilePicture_btn.BorderRadius = 20;
            this.profilePicture_btn.BorderSize = 0;
            this.profilePicture_btn.FlatAppearance.BorderSize = 0;
            this.profilePicture_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilePicture_btn.ForeColor = System.Drawing.Color.White;
            this.profilePicture_btn.Location = new System.Drawing.Point(62, 258);
            this.profilePicture_btn.Name = "profilePicture_btn";
            this.profilePicture_btn.Size = new System.Drawing.Size(187, 60);
            this.profilePicture_btn.TabIndex = 1;
            this.profilePicture_btn.Text = "Add Profile Picture";
            this.profilePicture_btn.TextColor = System.Drawing.Color.White;
            this.profilePicture_btn.UseVisualStyleBackColor = false;
            // 
            // about_txt
            // 
            this.about_txt.BackColor = System.Drawing.SystemColors.Window;
            this.about_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.about_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.about_txt.BorderRadius = 0;
            this.about_txt.BorderSize = 2;
            this.about_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.about_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.about_txt.Location = new System.Drawing.Point(68, 192);
            this.about_txt.Margin = new System.Windows.Forms.Padding(4);
            this.about_txt.Multiline = true;
            this.about_txt.Name = "about_txt";
            this.about_txt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.about_txt.PasswordChar = false;
            this.about_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.about_txt.PlaceholderText = "";
            this.about_txt.Size = new System.Drawing.Size(322, 94);
            this.about_txt.TabIndex = 2;
            this.about_txt.Texts = "";
            this.about_txt.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "About Description";
            // 
            // isVisible_toggle
            // 
            this.isVisible_toggle.AutoSize = true;
            this.isVisible_toggle.Checked = true;
            this.isVisible_toggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isVisible_toggle.Location = new System.Drawing.Point(233, 340);
            this.isVisible_toggle.MinimumSize = new System.Drawing.Size(60, 30);
            this.isVisible_toggle.Name = "isVisible_toggle";
            this.isVisible_toggle.OffBackColor = System.Drawing.Color.Gray;
            this.isVisible_toggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.isVisible_toggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.isVisible_toggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.isVisible_toggle.Size = new System.Drawing.Size(60, 30);
            this.isVisible_toggle.TabIndex = 4;
            this.isVisible_toggle.UseVisualStyleBackColor = true;
            // 
            // visible_label
            // 
            this.visible_label.AutoSize = true;
            this.visible_label.Location = new System.Drawing.Point(37, 342);
            this.visible_label.Name = "visible_label";
            this.visible_label.Size = new System.Drawing.Size(190, 25);
            this.visible_label.TabIndex = 5;
            this.visible_label.Text = "Profile Picture Visibility";
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Location = new System.Drawing.Point(54, 45);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(97, 25);
            this.fname_label.TabIndex = 6;
            this.fname_label.Text = "First Name";
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Location = new System.Drawing.Point(56, 109);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(95, 25);
            this.lname_label.TabIndex = 7;
            this.lname_label.Text = "Last Name";
            // 
            // fnameUser_label
            // 
            this.fnameUser_label.AutoSize = true;
            this.fnameUser_label.Location = new System.Drawing.Point(234, 45);
            this.fnameUser_label.Name = "fnameUser_label";
            this.fnameUser_label.Size = new System.Drawing.Size(97, 25);
            this.fnameUser_label.TabIndex = 8;
            this.fnameUser_label.Text = "First Name";
            // 
            // lnameUser_label
            // 
            this.lnameUser_label.AutoSize = true;
            this.lnameUser_label.Location = new System.Drawing.Point(236, 109);
            this.lnameUser_label.Name = "lnameUser_label";
            this.lnameUser_label.Size = new System.Drawing.Size(95, 25);
            this.lnameUser_label.TabIndex = 9;
            this.lnameUser_label.Text = "Last Name";
            // 
            // createAccount_btn
            // 
            this.createAccount_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.createAccount_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.createAccount_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.createAccount_btn.BorderRadius = 20;
            this.createAccount_btn.BorderSize = 0;
            this.createAccount_btn.FlatAppearance.BorderSize = 0;
            this.createAccount_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccount_btn.ForeColor = System.Drawing.Color.White;
            this.createAccount_btn.Location = new System.Drawing.Point(279, 417);
            this.createAccount_btn.Name = "createAccount_btn";
            this.createAccount_btn.Size = new System.Drawing.Size(187, 60);
            this.createAccount_btn.TabIndex = 10;
            this.createAccount_btn.Text = "Create Account";
            this.createAccount_btn.TextColor = System.Drawing.Color.White;
            this.createAccount_btn.UseVisualStyleBackColor = false;
            this.createAccount_btn.Click += new System.EventHandler(this.createAccount_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lnameUser_label);
            this.groupBox1.Controls.Add(this.fnameUser_label);
            this.groupBox1.Controls.Add(this.lname_label);
            this.groupBox1.Controls.Add(this.fname_label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.about_txt);
            this.groupBox1.Location = new System.Drawing.Point(330, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 311);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // ProfileDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createAccount_btn);
            this.Controls.Add(this.visible_label);
            this.Controls.Add(this.isVisible_toggle);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.profilePicture_btn);
            this.Name = "ProfileDescriptionForm";
            this.Text = "ProfileDescriptionForm";
            this.Load += new System.EventHandler(this.ProfileDescriptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPictureBox profilePicture;
        private RoundedButton profilePicture_btn;
        private TextBoxG about_txt;
        private System.Windows.Forms.Label label1;
        private ToggleButton isVisible_toggle;
        private System.Windows.Forms.Label visible_label;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.Label fnameUser_label;
        private System.Windows.Forms.Label lnameUser_label;
        private RoundedButton createAccount_btn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}