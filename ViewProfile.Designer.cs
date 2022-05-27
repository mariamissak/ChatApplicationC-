
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
            this.circularPictureBox1 = new ChatApplication.CircularPictureBox();
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
            this.fname_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularPictureBox1.BorderSize = 2;
            this.circularPictureBox1.GradientAngle = 50F;
            this.circularPictureBox1.Location = new System.Drawing.Point(17, 20);
            this.circularPictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(231, 231);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 0;
            this.circularPictureBox1.TabStop = false;
            this.circularPictureBox1.Click += new System.EventHandler(this.circularPictureBox1_Click);
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
            this.roundedButton1.Location = new System.Drawing.Point(42, 273);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(206, 63);
            this.roundedButton1.TabIndex = 1;
            this.roundedButton1.Text = "Change Profile Picture";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fname.Location = new System.Drawing.Point(278, 40);
            this.fname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(103, 25);
            this.fname.TabIndex = 2;
            this.fname.Text = "First Name";
            this.fname.Click += new System.EventHandler(this.fname_Click);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lName.Location = new System.Drawing.Point(278, 89);
            this.lName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(101, 25);
            this.lName.TabIndex = 3;
            this.lName.Text = "Last Name";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.Location = new System.Drawing.Point(278, 145);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(140, 25);
            this.phoneNumber.TabIndex = 4;
            this.phoneNumber.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
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
            this.abt_txt.Location = new System.Drawing.Point(41, 252);
            this.abt_txt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.abt_txt.Multiline = false;
            this.abt_txt.Name = "abt_txt";
            this.abt_txt.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.abt_txt.PasswordChar = false;
            this.abt_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.abt_txt.PlaceholderText = "";
            this.abt_txt.Size = new System.Drawing.Size(411, 49);
            this.abt_txt.TabIndex = 6;
            this.abt_txt.Texts = "";
            this.abt_txt.UnderlinedStyle = false;
            this.abt_txt.Load += new System.EventHandler(this.textBoxg1_Load);
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.Location = new System.Drawing.Point(167, 352);
            this.toggleButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(64, 37);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(64, 37);
            this.toggleButton1.TabIndex = 7;
            this.toggleButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
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
            this.saveProfileDesc.Location = new System.Drawing.Point(129, 326);
            this.saveProfileDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveProfileDesc.Name = "saveProfileDesc";
            this.saveProfileDesc.Size = new System.Drawing.Size(206, 63);
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
            this.groupBox1.Location = new System.Drawing.Point(264, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 459);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fname_label.Location = new System.Drawing.Point(41, 40);
            this.fname_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(103, 25);
            this.fname_label.TabIndex = 11;
            this.fname_label.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone Number";
            // 
            // ViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(770, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.circularPictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewProfile";
            this.Text = "ViewProfile";
            this.Load += new System.EventHandler(this.ViewProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPictureBox circularPictureBox1;
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