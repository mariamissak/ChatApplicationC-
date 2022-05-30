
namespace ChatApplication
{
    partial class MessageDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.message_time_label = new System.Windows.Forms.Label();
            this.seen_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date/Time";
            // 
            // message_time_label
            // 
            this.message_time_label.AutoSize = true;
            this.message_time_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.message_time_label.Location = new System.Drawing.Point(192, 18);
            this.message_time_label.Name = "message_time_label";
            this.message_time_label.Size = new System.Drawing.Size(102, 25);
            this.message_time_label.TabIndex = 1;
            this.message_time_label.Text = "Date/Time";
            this.message_time_label.Click += new System.EventHandler(this.message_time_label_Click);
            // 
            // seen_label
            // 
            this.seen_label.AutoSize = true;
            this.seen_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seen_label.Location = new System.Drawing.Point(192, 84);
            this.seen_label.Name = "seen_label";
            this.seen_label.Size = new System.Drawing.Size(102, 25);
            this.seen_label.TabIndex = 2;
            this.seen_label.Text = "Date/Time";
            // 
            // MessageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 194);
            this.Controls.Add(this.seen_label);
            this.Controls.Add(this.message_time_label);
            this.Controls.Add(this.label1);
            this.Name = "MessageDetails";
            this.Text = "MessageDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label message_time_label;
        private System.Windows.Forms.Label seen_label;
    }
}