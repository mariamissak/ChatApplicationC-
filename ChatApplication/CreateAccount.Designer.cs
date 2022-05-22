
namespace ChatApplication
{
    partial class CreateAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.next_btn = new ChatApplication.RoundedButton();
            this.password_label = new System.Windows.Forms.Label();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.password_txt = new ChatApplication.TextBoxG();
            this.phoneNumber_txt = new ChatApplication.TextBoxG();
            this.fname_txt = new ChatApplication.TextBoxG();
            this.lname_txt = new ChatApplication.TextBoxG();
            this.fname_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.terms_chk = new System.Windows.Forms.CheckBox();
            this.conditions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Create Account";
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.next_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.next_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.next_btn.BorderRadius = 20;
            this.next_btn.BorderSize = 0;
            this.next_btn.FlatAppearance.BorderSize = 0;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.ForeColor = System.Drawing.Color.White;
            this.next_btn.Location = new System.Drawing.Point(339, 378);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(157, 60);
            this.next_btn.TabIndex = 10;
            this.next_btn.Text = "Next";
            this.next_btn.TextColor = System.Drawing.Color.White;
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(133, 292);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(87, 25);
            this.password_label.TabIndex = 9;
            this.password_label.Text = "Password";
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Location = new System.Drawing.Point(88, 233);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(132, 25);
            this.phoneNumber_label.TabIndex = 8;
            this.phoneNumber_label.Text = "Phone Number";
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.SystemColors.Window;
            this.password_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.password_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.password_txt.BorderRadius = 0;
            this.password_txt.BorderSize = 2;
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_txt.Location = new System.Drawing.Point(227, 278);
            this.password_txt.Margin = new System.Windows.Forms.Padding(4);
            this.password_txt.Multiline = false;
            this.password_txt.Name = "password_txt";
            this.password_txt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.password_txt.PasswordChar = false;
            this.password_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.password_txt.PlaceholderText = "";
            this.password_txt.Size = new System.Drawing.Size(375, 39);
            this.password_txt.TabIndex = 7;
            this.password_txt.Texts = "";
            this.password_txt.UnderlinedStyle = false;
            // 
            // phoneNumber_txt
            // 
            this.phoneNumber_txt.BackColor = System.Drawing.SystemColors.Window;
            this.phoneNumber_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.phoneNumber_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.phoneNumber_txt.BorderRadius = 0;
            this.phoneNumber_txt.BorderSize = 2;
            this.phoneNumber_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneNumber_txt.Location = new System.Drawing.Point(227, 219);
            this.phoneNumber_txt.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumber_txt.Multiline = false;
            this.phoneNumber_txt.Name = "phoneNumber_txt";
            this.phoneNumber_txt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.phoneNumber_txt.PasswordChar = false;
            this.phoneNumber_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.phoneNumber_txt.PlaceholderText = "";
            this.phoneNumber_txt.Size = new System.Drawing.Size(375, 39);
            this.phoneNumber_txt.TabIndex = 6;
            this.phoneNumber_txt.Texts = "";
            this.phoneNumber_txt.UnderlinedStyle = false;
            // 
            // fname_txt
            // 
            this.fname_txt.BackColor = System.Drawing.SystemColors.Window;
            this.fname_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.fname_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.fname_txt.BorderRadius = 0;
            this.fname_txt.BorderSize = 2;
            this.fname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fname_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fname_txt.Location = new System.Drawing.Point(227, 113);
            this.fname_txt.Margin = new System.Windows.Forms.Padding(4);
            this.fname_txt.Multiline = false;
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.fname_txt.PasswordChar = false;
            this.fname_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.fname_txt.PlaceholderText = "";
            this.fname_txt.Size = new System.Drawing.Size(375, 39);
            this.fname_txt.TabIndex = 12;
            this.fname_txt.Texts = "";
            this.fname_txt.UnderlinedStyle = false;
            // 
            // lname_txt
            // 
            this.lname_txt.BackColor = System.Drawing.SystemColors.Window;
            this.lname_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lname_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lname_txt.BorderRadius = 0;
            this.lname_txt.BorderSize = 2;
            this.lname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lname_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lname_txt.Location = new System.Drawing.Point(227, 160);
            this.lname_txt.Margin = new System.Windows.Forms.Padding(4);
            this.lname_txt.Multiline = false;
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lname_txt.PasswordChar = false;
            this.lname_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lname_txt.PlaceholderText = "";
            this.lname_txt.Size = new System.Drawing.Size(375, 39);
            this.lname_txt.TabIndex = 13;
            this.lname_txt.Texts = "";
            this.lname_txt.UnderlinedStyle = false;
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Location = new System.Drawing.Point(110, 113);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(97, 25);
            this.fname_label.TabIndex = 14;
            this.fname_label.Text = "First Name";
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Location = new System.Drawing.Point(110, 174);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(95, 25);
            this.lname_label.TabIndex = 15;
            this.lname_label.Text = "Last Name";
            // 
            // terms_chk
            // 
            this.terms_chk.AutoSize = true;
            this.terms_chk.Location = new System.Drawing.Point(227, 334);
            this.terms_chk.Name = "terms_chk";
            this.terms_chk.Size = new System.Drawing.Size(137, 29);
            this.terms_chk.TabIndex = 16;
            this.terms_chk.Text = "Agree to the";
            this.terms_chk.UseVisualStyleBackColor = true;
            this.terms_chk.CheckedChanged += new System.EventHandler(this.terms_chk_CheckedChanged);
            // 
            // conditions
            // 
            this.conditions.AutoSize = true;
            this.conditions.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.conditions.Location = new System.Drawing.Point(359, 336);
            this.conditions.Name = "conditions";
            this.conditions.Size = new System.Drawing.Size(197, 25);
            this.conditions.TabIndex = 17;
            this.conditions.Text = "Terms and Conditions";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.conditions);
            this.Controls.Add(this.terms_chk);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.lname_txt);
            this.Controls.Add(this.fname_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.phoneNumber_label);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.phoneNumber_txt);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RoundedButton next_btn;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label phoneNumber_label;
        private TextBoxG password_txt;
        private TextBoxG phoneNumber_txt;
        private TextBoxG fname_txt;
        private TextBoxG lname_txt;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.CheckBox terms_chk;
        private System.Windows.Forms.Label conditions;
    }
}