
namespace ChatApplication
{
    partial class ViewProfile
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
            this.imagebox = new ChatApplication.CircularPictureBox();
            this.roundedButton1 = new ChatApplication.RoundedButton();
            this.fname = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.abt_txt = new ChatApplication.TextBoxG();
            this.toggleButton1 = new ChatApplication.ToggleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.saveProfileDesc = new ChatApplication.RoundedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fname_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagebox
            // 
            this.imagebox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.imagebox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.imagebox.BorderColor2 = System.Drawing.Color.HotPink;
            this.imagebox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.imagebox.BorderSize = 2;
            this.imagebox.GradientAngle = 50F;
            this.imagebox.Location = new System.Drawing.Point(14, 16);
            this.imagebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imagebox.Name = "imagebox";
            this.imagebox.Size = new System.Drawing.Size(185, 185);
            this.imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagebox.TabIndex = 0;
            this.imagebox.TabStop = false;
            this.imagebox.Click += new System.EventHandler(this.circularPictureBox1_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton1.BorderColor = System.Drawing.Color.White;
            this.roundedButton1.BorderRadius = 30;
            this.roundedButton1.BorderSize = 2;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(34, 218);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(165, 50);
            this.roundedButton1.TabIndex = 1;
            this.roundedButton1.Text = "Change Profile Picture";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fname.Location = new System.Drawing.Point(222, 32);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(86, 20);
            this.fname.TabIndex = 2;
            this.fname.Text = "First Name";
            this.fname.Click += new System.EventHandler(this.fname_Click);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lName.Location = new System.Drawing.Point(222, 71);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(84, 20);
            this.lName.TabIndex = 3;
            this.lName.Text = "Last Name";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.Location = new System.Drawing.Point(222, 116);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(115, 20);
            this.phoneNumber.TabIndex = 4;
            this.phoneNumber.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "About Description";
            // 
            // abt_txt
            // 
            this.abt_txt.BackColor = System.Drawing.SystemColors.Window;
            this.abt_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.abt_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.abt_txt.BorderRadius = 0;
            this.abt_txt.BorderSize = 2;
            this.abt_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.abt_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.abt_txt.Location = new System.Drawing.Point(33, 202);
            this.abt_txt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.abt_txt.Multiline = false;
            this.abt_txt.Name = "abt_txt";
            this.abt_txt.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.abt_txt.PasswordChar = false;
            this.abt_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.abt_txt.PlaceholderText = "";
            this.abt_txt.Size = new System.Drawing.Size(329, 41);
            this.abt_txt.TabIndex = 6;
            this.abt_txt.Texts = "";
            this.abt_txt.UnderlinedStyle = false;
            this.abt_txt.Load += new System.EventHandler(this.textBoxg1_Load);
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.Location = new System.Drawing.Point(134, 282);
            this.toggleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(51, 30);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(51, 30);
            this.toggleButton1.TabIndex = 7;
            this.toggleButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Profile Visibility";
            // 
            // saveProfileDesc
            // 
            this.saveProfileDesc.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.saveProfileDesc.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.saveProfileDesc.BorderColor = System.Drawing.Color.White;
            this.saveProfileDesc.BorderRadius = 30;
            this.saveProfileDesc.BorderSize = 2;
            this.saveProfileDesc.FlatAppearance.BorderSize = 0;
            this.saveProfileDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveProfileDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveProfileDesc.ForeColor = System.Drawing.Color.White;
            this.saveProfileDesc.Location = new System.Drawing.Point(103, 261);
            this.saveProfileDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveProfileDesc.Name = "saveProfileDesc";
            this.saveProfileDesc.Size = new System.Drawing.Size(165, 50);
            this.saveProfileDesc.TabIndex = 9;
            this.saveProfileDesc.Text = "Save Changes";
            this.saveProfileDesc.TextColor = System.Drawing.Color.White;
            this.saveProfileDesc.UseVisualStyleBackColor = false;
            this.saveProfileDesc.Click += new System.EventHandler(this.saveProfileDesc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fname_label);
            this.groupBox1.Controls.Add(this.saveProfileDesc);
            this.groupBox1.Controls.Add(this.abt_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Controls.Add(this.lName);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Location = new System.Drawing.Point(211, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(395, 367);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Name";
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fname_label.Location = new System.Drawing.Point(33, 32);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(86, 20);
            this.fname_label.TabIndex = 11;
            this.fname_label.Text = "First Name";
            // 
            // ViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(616, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.imagebox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewProfile";
            this.Text = "ViewProfile";
            this.Load += new System.EventHandler(this.ViewProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPictureBox imagebox;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Label label1;
        private TextBoxG abt_txt;
        private ToggleButton toggleButton1;
        private System.Windows.Forms.Label label2;
        private RoundedButton saveProfileDesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fname_label;
    }
}