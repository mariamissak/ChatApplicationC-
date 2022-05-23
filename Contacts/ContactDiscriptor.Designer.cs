
namespace ChatApplication.Contacts
{
    partial class ContactDiscriptor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.profilePicture = new ChatApplication.CircularPictureBox();
            this.contactName = new System.Windows.Forms.Label();
            this.bio = new System.Windows.Forms.Label();
            this.storyViewButton = new ChatApplication.RoundedButton();
            this.mobileNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
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
            this.profilePicture.Location = new System.Drawing.Point(180, 2);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(203, 203);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.profilePicture_Click);
            // 
            // contactName
            // 
            this.contactName.AutoSize = true;
            this.contactName.Location = new System.Drawing.Point(263, 220);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(39, 15);
            this.contactName.TabIndex = 4;
            this.contactName.Text = "Name";
            this.contactName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.contactName.Click += new System.EventHandler(this.contactName_Click);
            // 
            // bio
            // 
            this.bio.AutoSize = true;
            this.bio.Location = new System.Drawing.Point(263, 273);
            this.bio.Name = "bio";
            this.bio.Size = new System.Drawing.Size(38, 15);
            this.bio.TabIndex = 5;
            this.bio.Text = "label1";
            this.bio.Click += new System.EventHandler(this.bio_Click);
            // 
            // storyViewButton
            // 
            this.storyViewButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.storyViewButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.storyViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.storyViewButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.storyViewButton.BorderRadius = 20;
            this.storyViewButton.BorderSize = 0;
            this.storyViewButton.FlatAppearance.BorderSize = 0;
            this.storyViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storyViewButton.ForeColor = System.Drawing.Color.White;
            this.storyViewButton.Location = new System.Drawing.Point(242, 375);
            this.storyViewButton.Margin = new System.Windows.Forms.Padding(2);
            this.storyViewButton.Name = "storyViewButton";
            this.storyViewButton.Size = new System.Drawing.Size(85, 42);
            this.storyViewButton.TabIndex = 6;
            this.storyViewButton.Text = "View Stories";
            this.storyViewButton.TextColor = System.Drawing.Color.White;
            this.storyViewButton.UseVisualStyleBackColor = false;
            this.storyViewButton.Click += new System.EventHandler(this.storyViewButton_Click);
            // 
            // mobileNumber
            // 
            this.mobileNumber.AutoSize = true;
            this.mobileNumber.Location = new System.Drawing.Point(263, 247);
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.Size = new System.Drawing.Size(38, 15);
            this.mobileNumber.TabIndex = 7;
            this.mobileNumber.Text = "label1";
            // 
            // ContactDiscriptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mobileNumber);
            this.Controls.Add(this.storyViewButton);
            this.Controls.Add(this.bio);
            this.Controls.Add(this.contactName);
            this.Controls.Add(this.profilePicture);
            this.Name = "ContactDiscriptor";
            this.Size = new System.Drawing.Size(578, 461);
            this.Load += new System.EventHandler(this.ContactDiscriptor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPictureBox profilePicture;
        private System.Windows.Forms.Label contactName;
        private System.Windows.Forms.Label bio;
        private RoundedButton storyViewButton;
        private System.Windows.Forms.Label mobileNumber;
    }
}
