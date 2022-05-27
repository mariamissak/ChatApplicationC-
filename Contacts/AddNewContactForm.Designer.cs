
namespace ChatApplication.Contacts
{
    partial class AddNewContactForm
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
            this.AddContactbutton = new ChatApplication.RoundedButton();
            this.cancelButton = new ChatApplication.RoundedButton();
            this.phoneNumber_txt = new ChatApplication.TextBoxG();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddContactbutton
            // 
            this.AddContactbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddContactbutton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddContactbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddContactbutton.BorderColor = System.Drawing.Color.White;
            this.AddContactbutton.BorderRadius = 30;
            this.AddContactbutton.BorderSize = 2;
            this.AddContactbutton.FlatAppearance.BorderSize = 0;
            this.AddContactbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddContactbutton.ForeColor = System.Drawing.Color.White;
            this.AddContactbutton.Location = new System.Drawing.Point(298, 288);
            this.AddContactbutton.Name = "AddContactbutton";
            this.AddContactbutton.Size = new System.Drawing.Size(167, 63);
            this.AddContactbutton.TabIndex = 8;
            this.AddContactbutton.Text = "Add";
            this.AddContactbutton.TextColor = System.Drawing.Color.White;
            this.AddContactbutton.UseVisualStyleBackColor = false;
            this.AddContactbutton.Click += new System.EventHandler(this.AddContactbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelButton.BorderColor = System.Drawing.Color.White;
            this.cancelButton.BorderRadius = 30;
            this.cancelButton.BorderSize = 2;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(547, 288);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(167, 63);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextColor = System.Drawing.Color.White;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            this.phoneNumber_txt.Location = new System.Drawing.Point(340, 184);
            this.phoneNumber_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneNumber_txt.Multiline = false;
            this.phoneNumber_txt.Name = "phoneNumber_txt";
            this.phoneNumber_txt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.phoneNumber_txt.PasswordChar = false;
            this.phoneNumber_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.phoneNumber_txt.PlaceholderText = "";
            this.phoneNumber_txt.Size = new System.Drawing.Size(374, 39);
            this.phoneNumber_txt.TabIndex = 10;
            this.phoneNumber_txt.Texts = "";
            this.phoneNumber_txt.UnderlinedStyle = false;
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber_label.Location = new System.Drawing.Point(184, 190);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(140, 25);
            this.phoneNumber_label.TabIndex = 11;
            this.phoneNumber_label.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(298, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter phone number of person you want to add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(365, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 54);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add Contact";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.Lavender;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.MediumVioletRed;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.IconSize = 125;
            this.iconPictureBox1.Location = new System.Drawing.Point(39, 128);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(129, 125);
            this.iconPictureBox1.TabIndex = 14;
            this.iconPictureBox1.TabStop = false;
            // 
            // AddNewContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(969, 460);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumber_label);
            this.Controls.Add(this.phoneNumber_txt);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.AddContactbutton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddNewContactForm";
            this.Text = "Add New Contact";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();


            this.AddContactbutton = new ChatApplication.RoundedButton();
            this.cancelButton = new ChatApplication.RoundedButton();
            this.phoneNumber_txt = new ChatApplication.TextBoxG();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddContactbutton
            // 
            this.AddContactbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddContactbutton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddContactbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddContactbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddContactbutton.BorderRadius = 20;
            this.AddContactbutton.BorderSize = 0;
            this.AddContactbutton.FlatAppearance.BorderSize = 0;
            this.AddContactbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactbutton.ForeColor = System.Drawing.Color.White;
            this.AddContactbutton.Location = new System.Drawing.Point(327, 209);
            this.AddContactbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddContactbutton.Name = "AddContactbutton";
            this.AddContactbutton.Size = new System.Drawing.Size(97, 56);
            this.AddContactbutton.TabIndex = 8;
            this.AddContactbutton.Text = "Add";
            this.AddContactbutton.TextColor = System.Drawing.Color.White;
            this.AddContactbutton.UseVisualStyleBackColor = false;
            this.AddContactbutton.Click += new System.EventHandler(this.AddContactbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelButton.BorderRadius = 20;
            this.cancelButton.BorderSize = 0;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(20, 300);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 56);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "cancel";
            this.cancelButton.TextColor = System.Drawing.Color.White;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            this.phoneNumber_txt.Location = new System.Drawing.Point(231, 141);
            this.phoneNumber_txt.Multiline = false;
            this.phoneNumber_txt.Name = "phoneNumber_txt";
            this.phoneNumber_txt.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.phoneNumber_txt.PasswordChar = false;
            this.phoneNumber_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.phoneNumber_txt.PlaceholderText = "";
            this.phoneNumber_txt.Size = new System.Drawing.Size(299, 31);
            this.phoneNumber_txt.TabIndex = 10;
            this.phoneNumber_txt.Texts = "";
            this.phoneNumber_txt.UnderlinedStyle = false;
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Location = new System.Drawing.Point(95, 152);
            this.phoneNumber_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(108, 20);
            this.phoneNumber_label.TabIndex = 11;
            this.phoneNumber_label.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Phone number of person you want to add: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddNewContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumber_label);
            this.Controls.Add(this.phoneNumber_txt);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.AddContactbutton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddNewContactForm";
            this.Text = "Add New Contact";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private RoundedButton AddContactbutton;
        private RoundedButton cancelButton;
        private TextBoxG phoneNumber_txt;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}