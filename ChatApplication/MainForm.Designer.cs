
namespace ChatApplication
{
    partial class MainForm
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
            this.creatAccount_btn = new ChatApplication.RoundedButton();
            this.logIn_btn = new ChatApplication.RoundedButton();
            this.SuspendLayout();
            // 
            // creatAccount_btn
            // 
            this.creatAccount_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.creatAccount_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.creatAccount_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.creatAccount_btn.BorderRadius = 20;
            this.creatAccount_btn.BorderSize = 0;
            this.creatAccount_btn.FlatAppearance.BorderSize = 0;
            this.creatAccount_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creatAccount_btn.ForeColor = System.Drawing.Color.White;
            this.creatAccount_btn.Location = new System.Drawing.Point(260, 132);
            this.creatAccount_btn.Name = "creatAccount_btn";
            this.creatAccount_btn.Size = new System.Drawing.Size(225, 60);
            this.creatAccount_btn.TabIndex = 0;
            this.creatAccount_btn.Text = "Create Account";
            this.creatAccount_btn.TextColor = System.Drawing.Color.White;
            this.creatAccount_btn.UseVisualStyleBackColor = false;
            this.creatAccount_btn.Click += new System.EventHandler(this.creatAccount_btn_Click);
            // 
            // logIn_btn
            // 
            this.logIn_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.logIn_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.logIn_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.logIn_btn.BorderRadius = 20;
            this.logIn_btn.BorderSize = 0;
            this.logIn_btn.FlatAppearance.BorderSize = 0;
            this.logIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logIn_btn.ForeColor = System.Drawing.Color.White;
            this.logIn_btn.Location = new System.Drawing.Point(260, 211);
            this.logIn_btn.Name = "logIn_btn";
            this.logIn_btn.Size = new System.Drawing.Size(225, 60);
            this.logIn_btn.TabIndex = 1;
            this.logIn_btn.Text = "Log In";
            this.logIn_btn.TextColor = System.Drawing.Color.White;
            this.logIn_btn.UseVisualStyleBackColor = false;
            this.logIn_btn.Click += new System.EventHandler(this.logIn_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logIn_btn);
            this.Controls.Add(this.creatAccount_btn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton creatAccount_btn;
        private RoundedButton logIn_btn;
    }
}