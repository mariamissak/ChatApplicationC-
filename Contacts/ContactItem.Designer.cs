
namespace ChatApplication.Contacts
{
    partial class ContactItem
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
            this.lastSeen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.profilePicture.BorderColor = System.Drawing.Color.RoyalBlue;
            this.profilePicture.BorderColor2 = System.Drawing.Color.HotPink;
            this.profilePicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profilePicture.BorderSize = 2;
            this.profilePicture.GradientAngle = 50F;
            this.profilePicture.Location = new System.Drawing.Point(3, 10);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(163, 163);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 1;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.profilePicture_Click);
            // 
            // contactName
            // 
            this.contactName.BackColor = System.Drawing.Color.Transparent;
            this.contactName.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactName.Location = new System.Drawing.Point(173, 58);
            this.contactName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(116, 38);
            this.contactName.TabIndex = 2;
            this.contactName.Text = "label1";
            this.contactName.Click += new System.EventHandler(this.contactName_Click);
            // 
            // lastSeen
            // 
            this.lastSeen.BackColor = System.Drawing.Color.Transparent;
            this.lastSeen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastSeen.Location = new System.Drawing.Point(173, 120);
            this.lastSeen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastSeen.Name = "lastSeen";
            this.lastSeen.Size = new System.Drawing.Size(223, 30);
            this.lastSeen.TabIndex = 3;
            this.lastSeen.Text = "label2";
            this.lastSeen.Click += new System.EventHandler(this.lastSeen_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(429, 192);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContactItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.contactName);
            this.Controls.Add(this.lastSeen);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ContactItem";
            this.Size = new System.Drawing.Size(429, 197);
            this.Load += new System.EventHandler(this.ContactItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularPictureBox profilePicture;
        private System.Windows.Forms.Label contactName;
        private System.Windows.Forms.Label lastSeen;
        private System.Windows.Forms.Button button1;
    }
}
