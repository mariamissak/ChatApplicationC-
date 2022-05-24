
namespace ChatApplication
{
    partial class ListItem
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
            this.circularPictureBox1 = new ChatApplication.CircularPictureBox();
            this.chatRoomName_label = new System.Windows.Forms.Label();
            this.message_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
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
            this.circularPictureBox1.Location = new System.Drawing.Point(14, 8);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(122, 122);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox1.TabIndex = 0;
            this.circularPictureBox1.TabStop = false;
            // 
            // chatRoomName_label
            // 
            this.chatRoomName_label.Location = new System.Drawing.Point(168, 40);
            this.chatRoomName_label.Name = "chatRoomName_label";
            this.chatRoomName_label.Size = new System.Drawing.Size(438, 38);
            this.chatRoomName_label.TabIndex = 1;
            this.chatRoomName_label.Text = "ChatRoom Participants";
            // 
            // message_label
            // 
            this.message_label.Location = new System.Drawing.Point(168, 86);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(341, 25);
            this.message_label.TabIndex = 2;
            this.message_label.Text = "lastMessage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "SeenLabel";
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.chatRoomName_label);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(641, 141);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Label chatRoomName_label;
        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.Label label3;
    }
}
