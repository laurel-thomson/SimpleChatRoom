namespace ChatClient
{
    partial class ClientGUI
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
            this.components = new System.ComponentModel.Container();
            this.uxMessageTextBox = new System.Windows.Forms.TextBox();
            this.uxSendMessageButton = new System.Windows.Forms.Button();
            this.clientViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uxMessagesListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientViewModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxMessageTextBox
            // 
            this.uxMessageTextBox.Location = new System.Drawing.Point(641, 822);
            this.uxMessageTextBox.Name = "uxMessageTextBox";
            this.uxMessageTextBox.Size = new System.Drawing.Size(652, 44);
            this.uxMessageTextBox.TabIndex = 0;
            // 
            // uxSendMessageButton
            // 
            this.uxSendMessageButton.Location = new System.Drawing.Point(641, 906);
            this.uxSendMessageButton.Name = "uxSendMessageButton";
            this.uxSendMessageButton.Size = new System.Drawing.Size(652, 61);
            this.uxSendMessageButton.TabIndex = 1;
            this.uxSendMessageButton.Text = "Send Message!";
            this.uxSendMessageButton.UseVisualStyleBackColor = true;
            this.uxSendMessageButton.Click += new System.EventHandler(this.uxSendMessageButton_Click);
            // 
            // clientViewModelBindingSource1
            // 
            this.clientViewModelBindingSource1.DataMember = "Messages";
            this.clientViewModelBindingSource1.DataSource = typeof(ChatClient.ClientViewModel);
            // 
            // uxMessagesListBox
            // 
            this.uxMessagesListBox.DataSource = this.clientViewModelBindingSource1;
            this.uxMessagesListBox.FormattingEnabled = true;
            this.uxMessagesListBox.ItemHeight = 37;
            this.uxMessagesListBox.Location = new System.Drawing.Point(73, 42);
            this.uxMessagesListBox.Name = "uxMessagesListBox";
            this.uxMessagesListBox.Size = new System.Drawing.Size(1784, 707);
            this.uxMessagesListBox.TabIndex = 2;
            // 
            // ClientGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1937, 1037);
            this.Controls.Add(this.uxMessagesListBox);
            this.Controls.Add(this.uxSendMessageButton);
            this.Controls.Add(this.uxMessageTextBox);
            this.Name = "ClientGUI";
            this.Text = "ClientGUI";
            ((System.ComponentModel.ISupportInitialize)(this.clientViewModelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxMessageTextBox;
        private System.Windows.Forms.Button uxSendMessageButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientViewModelBindingSource1;
        private System.Windows.Forms.ListBox uxMessagesListBox;
    }
}