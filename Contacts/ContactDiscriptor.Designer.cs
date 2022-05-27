
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
            this.chatButton = new ChatApplication.RoundedButton();
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
            this.profilePicture.Location = new System.Drawing.Point(257, 27);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(290, 290);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.profilePicture_Click);
            // 
            // contactName
            // 
            this.contactName.AutoSize = true;
            this.contactName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactName.Location = new System.Drawing.Point(78, 55);
            this.contactName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(62, 25);
            this.contactName.TabIndex = 4;
            this.contactName.Text = "Name";
            this.contactName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.contactName.Click += new System.EventHandler(this.contactName_Click);
            // 
            // bio
            // 
            this.bio.AutoSize = true;
            this.bio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bio.Location = new System.Drawing.Point(78, 143);
            this.bio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bio.Name = "bio";
            this.bio.Size = new System.Drawing.Size(39, 25);
            this.bio.TabIndex = 5;
            this.bio.Text = "bio";
            this.bio.Click += new System.EventHandler(this.bio_Click);
            // 
            // storyViewButton
            // 
            this.storyViewButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.storyViewButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.storyViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.storyViewButton.BorderColor = System.Drawing.Color.White;
            this.storyViewButton.BorderRadius = 30;
            this.storyViewButton.BorderSize = 2;
            this.storyViewButton.FlatAppearance.BorderSize = 0;
            this.storyViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storyViewButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storyViewButton.ForeColor = System.Drawing.Color.White;
            this.storyViewButton.Location = new System.Drawing.Point(329, 654);
            this.storyViewButton.Name = "storyViewButton";
            this.storyViewButton.Size = new System.Drawing.Size(145, 55);
            this.storyViewButton.TabIndex = 6;
            this.storyViewButton.Text = "View Stories";
            this.storyViewButton.TextColor = System.Drawing.Color.White;
            this.storyViewButton.UseVisualStyleBackColor = false;
            this.storyViewButton.Click += new System.EventHandler(this.storyViewButton_Click);
            // 
            // mobileNumber
            // 
            this.mobileNumber.AutoSize = true;
            this.mobileNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mobileNumber.Location = new System.Drawing.Point(78, 100);
            this.mobileNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.Size = new System.Drawing.Size(139, 25);
            this.mobileNumber.TabIndex = 7;
            this.mobileNumber.Text = "mobileNumber";
            // 
            // chatButton
            // 
            this.chatButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.chatButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.chatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
<<<<<<< aftermergingontacts
            this.chatButton.BorderColor = System.Drawing.Color.White;
            this.chatButton.BorderRadius = 30;
            this.chatButton.BorderSize = 2;
            this.chatButton.FlatAppearance.BorderSize = 0;
            this.chatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chatButton.ForeColor = System.Drawing.Color.White;
            this.chatButton.Location = new System.Drawing.Point(329, 581);
            this.chatButton.Name = "chatButton";
            this.chatButton.Size = new System.Drawing.Size(145, 55);
            this.chatButton.TabIndex = 8;
            this.chatButton.Text = "Chat";
            this.chatButton.TextColor = System.Drawing.Color.White;
            this.chatButton.UseVisualStyleBackColor = false;
            this.chatButton.Click += new System.EventHandler(this.chatButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.mobileNumber);
            this.groupBox1.Controls.Add(this.bio);
            this.groupBox1.Controls.Add(this.contactName);
            this.groupBox1.Location = new System.Drawing.Point(276, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 236);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // ContactDiscriptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chatButton);
            this.Controls.Add(this.storyViewButton);
            this.Controls.Add(this.profilePicture);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ContactDiscriptor";
            this.Size = new System.Drawing.Size(826, 768);
            this.Load += new System.EventHandler(this.ContactDiscriptor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularPictureBox profilePicture;
        private System.Windows.Forms.Label contactName;
        private System.Windows.Forms.Label bio;
        private RoundedButton storyViewButton;
        private System.Windows.Forms.Label mobileNumber;
        private RoundedButton chatButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
