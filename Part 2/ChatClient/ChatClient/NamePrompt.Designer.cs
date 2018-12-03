namespace ChatClient
{
    partial class NamePrompt
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
            this.uxNameTextBox = new System.Windows.Forms.TextBox();
            this.uxOKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxNameTextBox
            // 
            this.uxNameTextBox.Location = new System.Drawing.Point(78, 135);
            this.uxNameTextBox.Name = "uxNameTextBox";
            this.uxNameTextBox.Size = new System.Drawing.Size(659, 44);
            this.uxNameTextBox.TabIndex = 0;
            // 
            // uxOKButton
            // 
            this.uxOKButton.Location = new System.Drawing.Point(78, 221);
            this.uxOKButton.Name = "uxOKButton";
            this.uxOKButton.Size = new System.Drawing.Size(658, 73);
            this.uxOKButton.TabIndex = 1;
            this.uxOKButton.Text = "OK";
            this.uxOKButton.UseVisualStyleBackColor = true;
            this.uxOKButton.Click += new System.EventHandler(this.uxOKButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter your chat name:";
            // 
            // NamePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxOKButton);
            this.Controls.Add(this.uxNameTextBox);
            this.Name = "NamePrompt";
            this.Text = "Welcome to the Chat Room!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxNameTextBox;
        private System.Windows.Forms.Button uxOKButton;
        private System.Windows.Forms.Label label1;
    }
}