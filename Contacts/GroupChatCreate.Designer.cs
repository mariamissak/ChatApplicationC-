
namespace ChatApplication.Contacts
{
    partial class GroupChatCreate
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
            this.CheckContactsCheckBoxsList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateGroupChatButton = new ChatApplication.RoundedButton();
            this.back_btn = new ChatApplication.RoundedButton();
            this.SuspendLayout();
            // 
            // CheckContactsCheckBoxsList
            // 
            this.CheckContactsCheckBoxsList.FormattingEnabled = true;
            this.CheckContactsCheckBoxsList.Location = new System.Drawing.Point(165, 77);
            this.CheckContactsCheckBoxsList.Name = "CheckContactsCheckBoxsList";
            this.CheckContactsCheckBoxsList.Size = new System.Drawing.Size(237, 418);
            this.CheckContactsCheckBoxsList.TabIndex = 0;
            this.CheckContactsCheckBoxsList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "contacts";
            // 
            // CreateGroupChatButton
            // 
            this.CreateGroupChatButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CreateGroupChatButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.CreateGroupChatButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CreateGroupChatButton.BorderRadius = 20;
            this.CreateGroupChatButton.BorderSize = 0;
            this.CreateGroupChatButton.FlatAppearance.BorderSize = 0;
            this.CreateGroupChatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateGroupChatButton.ForeColor = System.Drawing.Color.White;
            this.CreateGroupChatButton.Location = new System.Drawing.Point(207, 501);
            this.CreateGroupChatButton.Name = "CreateGroupChatButton";
            this.CreateGroupChatButton.Size = new System.Drawing.Size(150, 40);
            this.CreateGroupChatButton.TabIndex = 4;
            this.CreateGroupChatButton.Text = "create";
            this.CreateGroupChatButton.TextColor = System.Drawing.Color.White;
            this.CreateGroupChatButton.UseVisualStyleBackColor = false;
            this.CreateGroupChatButton.Click += new System.EventHandler(this.CreateGroupChatButton_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.back_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.back_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.back_btn.BorderRadius = 20;
            this.back_btn.BorderSize = 0;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(13, 13);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(150, 40);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "back";
            this.back_btn.TextColor = System.Drawing.Color.White;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // GroupChatCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 608);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.CreateGroupChatButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckContactsCheckBoxsList);
            this.Name = "GroupChatCreate";
            this.Text = "GroupChatCreate";
            this.Load += new System.EventHandler(this.GroupChatCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckContactsCheckBoxsList;
        private System.Windows.Forms.Label label2;
        private RoundedButton CreateGroupChatButton;
        private RoundedButton back_btn;
    }
}