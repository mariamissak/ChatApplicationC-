
namespace ChatApplication
{
    partial class MessageItem
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
            this.message_label = new System.Windows.Forms.Label();
            this.date_time_label = new System.Windows.Forms.Label();
            this.is_seen_label = new System.Windows.Forms.Label();
            this.user_message_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // message_label
            // 
            this.message_label.Location = new System.Drawing.Point(31, 70);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(399, 59);
            this.message_label.TabIndex = 0;
            this.message_label.Text = "Message";
            // 
            // date_time_label
            // 
            this.date_time_label.AutoSize = true;
            this.date_time_label.Location = new System.Drawing.Point(31, 129);
            this.date_time_label.Name = "date_time_label";
            this.date_time_label.Size = new System.Drawing.Size(94, 25);
            this.date_time_label.TabIndex = 1;
            this.date_time_label.Text = "Date/Time";
            // 
            // is_seen_label
            // 
            this.is_seen_label.AutoSize = true;
            this.is_seen_label.Location = new System.Drawing.Point(31, 180);
            this.is_seen_label.Name = "is_seen_label";
            this.is_seen_label.Size = new System.Drawing.Size(68, 25);
            this.is_seen_label.TabIndex = 2;
            this.is_seen_label.Text = "Is Seen";
            // 
            // user_message_label
            // 
            this.user_message_label.Location = new System.Drawing.Point(31, 11);
            this.user_message_label.Name = "user_message_label";
            this.user_message_label.Size = new System.Drawing.Size(399, 59);
            this.user_message_label.TabIndex = 3;
            this.user_message_label.Text = "User";
            this.user_message_label.Click += new System.EventHandler(this.user_message_label_Click);
            // 
            // MessageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.user_message_label);
            this.Controls.Add(this.is_seen_label);
            this.Controls.Add(this.date_time_label);
            this.Controls.Add(this.message_label);
            this.Name = "MessageItem";
            this.Size = new System.Drawing.Size(468, 266);
            this.Load += new System.EventHandler(this.MessageItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.Label date_time_label;
        private System.Windows.Forms.Label is_seen_label;
        private System.Windows.Forms.Label user_message_label;
    }
}