
namespace ChatApplication
{
    partial class ContactsStories
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.storyContact1 = new ChatApplication.StoryContact();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedButton2 = new ChatApplication.RoundedButton();
            this.textBoxg1 = new ChatApplication.TextBoxG();
            this.roundedButton1 = new ChatApplication.RoundedButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.storyContact1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 701);
            this.panel2.TabIndex = 4;
            // 
            // storyContact1
            // 
            this.storyContact1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.storyContact1.Icon = null;
            this.storyContact1.Location = new System.Drawing.Point(15, 84);
            this.storyContact1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.storyContact1.Name = "storyContact1";
            this.storyContact1.SContact = null;
            this.storyContact1.SContactName = null;
            this.storyContact1.Size = new System.Drawing.Size(491, 162);
            this.storyContact1.TabIndex = 0;
            this.storyContact1.TimePublished = null;
            this.storyContact1.Load += new System.EventHandler(this.storyContact1_Load);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 254);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(491, 411);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.roundedButton2);
            this.panel1.Controls.Add(this.textBoxg1);
            this.panel1.Controls.Add(this.roundedButton1);
            this.panel1.Location = new System.Drawing.Point(525, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 688);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ChatApplication.Properties.Resources.colors;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(147, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 404);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add Story Text:";
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton2.BorderRadius = 20;
            this.roundedButton2.BorderSize = 0;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(201, 592);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(188, 50);
            this.roundedButton2.TabIndex = 7;
            this.roundedButton2.Text = "Add Story";
            this.roundedButton2.TextColor = System.Drawing.Color.White;
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // textBoxg1
            // 
            this.textBoxg1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxg1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxg1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxg1.BorderRadius = 0;
            this.textBoxg1.BorderSize = 2;
            this.textBoxg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxg1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxg1.Location = new System.Drawing.Point(151, 550);
            this.textBoxg1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxg1.Multiline = false;
            this.textBoxg1.Name = "textBoxg1";
            this.textBoxg1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxg1.PasswordChar = false;
            this.textBoxg1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxg1.PlaceholderText = "";
            this.textBoxg1.Size = new System.Drawing.Size(300, 35);
            this.textBoxg1.TabIndex = 6;
            this.textBoxg1.Texts = "";
            this.textBoxg1.UnderlinedStyle = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton1.BorderRadius = 20;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(201, 51);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(188, 50);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.Text = "Upload Image";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.iconButton1.IconColor = System.Drawing.Color.PaleVioletRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 60;
            this.iconButton1.Location = new System.Drawing.Point(15, 11);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(57, 59);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ContactsStories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ContactsStories";
            this.Text = "ContactsStories";
            this.Load += new System.EventHandler(this.ContactsStories_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private StoryContact storyContact1;
        private RoundedButton roundedButton1;
        private TextBoxG textBoxg1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private RoundedButton roundedButton2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}