
namespace ChatApplication
{
    partial class LogIn
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
            this.phoneNumber_txt = new ChatApplication.TextBoxG();
            this.password_txt = new ChatApplication.TextBoxG();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.logIn_btn = new ChatApplication.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.phoneNumber_txt.Location = new System.Drawing.Point(216, 134);
            this.phoneNumber_txt.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumber_txt.Multiline = false;
            this.phoneNumber_txt.Name = "phoneNumber_txt";
            this.phoneNumber_txt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.phoneNumber_txt.PasswordChar = false;
            this.phoneNumber_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.phoneNumber_txt.PlaceholderText = "";
            this.phoneNumber_txt.Size = new System.Drawing.Size(375, 39);
            this.phoneNumber_txt.TabIndex = 0;
            this.phoneNumber_txt.Texts = "";
            this.phoneNumber_txt.UnderlinedStyle = false;
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
            this.password_txt.Location = new System.Drawing.Point(216, 200);
            this.password_txt.Margin = new System.Windows.Forms.Padding(4);
            this.password_txt.Multiline = false;
            this.password_txt.Name = "password_txt";
            this.password_txt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.password_txt.PasswordChar = true;
            this.password_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.password_txt.PlaceholderText = "";
            this.password_txt.Size = new System.Drawing.Size(375, 39);
            this.password_txt.TabIndex = 1;
            this.password_txt.Texts = "";
            this.password_txt.UnderlinedStyle = false;
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber_label.Location = new System.Drawing.Point(69, 141);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(140, 25);
            this.phoneNumber_label.TabIndex = 2;
            this.phoneNumber_label.Text = "Phone Number";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password_label.Location = new System.Drawing.Point(117, 209);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(92, 25);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password";
            // 
            // logIn_btn
            // 
            this.logIn_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.logIn_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.logIn_btn.BorderColor = System.Drawing.Color.White;
            this.logIn_btn.BorderRadius = 30;
            this.logIn_btn.BorderSize = 2;
            this.logIn_btn.FlatAppearance.BorderSize = 0;
            this.logIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logIn_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logIn_btn.ForeColor = System.Drawing.Color.White;
            this.logIn_btn.Location = new System.Drawing.Point(340, 269);
            this.logIn_btn.Name = "logIn_btn";
            this.logIn_btn.Size = new System.Drawing.Size(146, 60);
            this.logIn_btn.TabIndex = 4;
            this.logIn_btn.Text = "Log In";
            this.logIn_btn.TextColor = System.Drawing.Color.White;
            this.logIn_btn.UseVisualStyleBackColor = false;
            this.logIn_btn.Click += new System.EventHandler(this.logIn_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(320, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 70);
            this.label1.TabIndex = 5;
            this.label1.Text = "Log In";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logIn_btn);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.phoneNumber_label);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.phoneNumber_txt);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxG phoneNumber_txt;
        private TextBoxG password_txt;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Label password_label;
        private RoundedButton logIn_btn;
        private System.Windows.Forms.Label label1;
    }
}