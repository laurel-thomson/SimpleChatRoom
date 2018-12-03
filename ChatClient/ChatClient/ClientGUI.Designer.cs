﻿namespace ChatClient
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
            this.uxMessageTextBox = new System.Windows.Forms.TextBox();
            this.uxSendMessageButton = new System.Windows.Forms.Button();
            this.uxDisplayMessagesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxMessageTextBox
            // 
            this.uxMessageTextBox.Location = new System.Drawing.Point(72, 330);
            this.uxMessageTextBox.Name = "uxMessageTextBox";
            this.uxMessageTextBox.Size = new System.Drawing.Size(652, 44);
            this.uxMessageTextBox.TabIndex = 0;
            // 
            // uxSendMessageButton
            // 
            this.uxSendMessageButton.Location = new System.Drawing.Point(72, 400);
            this.uxSendMessageButton.Name = "uxSendMessageButton";
            this.uxSendMessageButton.Size = new System.Drawing.Size(652, 61);
            this.uxSendMessageButton.TabIndex = 1;
            this.uxSendMessageButton.Text = "Send Message!";
            this.uxSendMessageButton.UseVisualStyleBackColor = true;
            this.uxSendMessageButton.Click += new System.EventHandler(this.uxSendMessageButton_Click);
            // 
            // uxDisplayMessagesTextBox
            // 
            this.uxDisplayMessagesTextBox.Location = new System.Drawing.Point(72, 46);
            this.uxDisplayMessagesTextBox.Multiline = true;
            this.uxDisplayMessagesTextBox.Name = "uxDisplayMessagesTextBox";
            this.uxDisplayMessagesTextBox.Size = new System.Drawing.Size(652, 253);
            this.uxDisplayMessagesTextBox.TabIndex = 2;
            // 
            // ClientGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.uxDisplayMessagesTextBox);
            this.Controls.Add(this.uxSendMessageButton);
            this.Controls.Add(this.uxMessageTextBox);
            this.Name = "ClientGUI";
            this.Text = "ClientGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxMessageTextBox;
        private System.Windows.Forms.Button uxSendMessageButton;
        private System.Windows.Forms.TextBox uxDisplayMessagesTextBox;
    }
}