
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_btn = new ChatApplication.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // creatAccount_btn
            // 
            this.creatAccount_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.creatAccount_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.creatAccount_btn.BorderColor = System.Drawing.Color.White;
            this.creatAccount_btn.BorderRadius = 30;
            this.creatAccount_btn.BorderSize = 2;
            this.creatAccount_btn.FlatAppearance.BorderSize = 0;
            this.creatAccount_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creatAccount_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.creatAccount_btn.ForeColor = System.Drawing.Color.White;
            this.creatAccount_btn.Location = new System.Drawing.Point(306, 174);
            this.creatAccount_btn.Name = "creatAccount_btn";
            this.creatAccount_btn.Size = new System.Drawing.Size(234, 68);
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
            this.logIn_btn.BorderColor = System.Drawing.Color.White;
            this.logIn_btn.BorderRadius = 30;
            this.logIn_btn.BorderSize = 2;
            this.logIn_btn.FlatAppearance.BorderSize = 0;
            this.logIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logIn_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logIn_btn.ForeColor = System.Drawing.Color.White;
            this.logIn_btn.Location = new System.Drawing.Point(306, 259);
            this.logIn_btn.Name = "logIn_btn";
            this.logIn_btn.Size = new System.Drawing.Size(234, 68);
            this.logIn_btn.TabIndex = 1;
            this.logIn_btn.Text = "Log In";
            this.logIn_btn.TextColor = System.Drawing.Color.White;
            this.logIn_btn.UseVisualStyleBackColor = false;
            this.logIn_btn.Click += new System.EventHandler(this.logIn_btn_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Lavender;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.iconPictureBox1.IconColor = System.Drawing.Color.MediumVioletRed;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 174;
            this.iconPictureBox1.Location = new System.Drawing.Point(22, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(179, 174);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(207, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHAT APPLICATION";
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.exit_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.exit_btn.BorderColor = System.Drawing.Color.White;
            this.exit_btn.BorderRadius = 30;
            this.exit_btn.BorderSize = 2;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(306, 346);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(234, 68);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "Exit";
            this.exit_btn.TextColor = System.Drawing.Color.White;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.logIn_btn);
            this.Controls.Add(this.creatAccount_btn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton creatAccount_btn;
        private RoundedButton logIn_btn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private RoundedButton exit_btn;
    }
}