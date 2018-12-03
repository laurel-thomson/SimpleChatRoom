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
            this.uxMessagesDGV = new System.Windows.Forms.DataGridView();
            this.clientViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uxMessagesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientViewModelBindingSource1)).BeginInit();
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
            // uxMessagesDGV
            // 
            this.uxMessagesDGV.AllowUserToAddRows = false;
            this.uxMessagesDGV.AllowUserToDeleteRows = false;
            this.uxMessagesDGV.AllowUserToResizeColumns = false;
            this.uxMessagesDGV.AllowUserToResizeRows = false;
            this.uxMessagesDGV.AutoGenerateColumns = false;
            this.uxMessagesDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.uxMessagesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMessagesDGV.ColumnHeadersVisible = false;
            this.uxMessagesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.uxMessagesDGV.DataSource = this.clientViewModelBindingSource1;
            this.uxMessagesDGV.Location = new System.Drawing.Point(72, 36);
            this.uxMessagesDGV.Name = "uxMessagesDGV";
            this.uxMessagesDGV.ReadOnly = true;
            this.uxMessagesDGV.RowHeadersVisible = false;
            this.uxMessagesDGV.RowTemplate.Height = 46;
            this.uxMessagesDGV.Size = new System.Drawing.Size(653, 259);
            this.uxMessagesDGV.TabIndex = 2;
            // 
            // clientViewModelBindingSource1
            // 
            this.clientViewModelBindingSource1.DataMember = "Messages";
            this.clientViewModelBindingSource1.DataSource = typeof(ChatClient.ClientViewModel);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ClientGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.uxMessagesDGV);
            this.Controls.Add(this.uxSendMessageButton);
            this.Controls.Add(this.uxMessageTextBox);
            this.Name = "ClientGUI";
            this.Text = "ClientGUI";
            ((System.ComponentModel.ISupportInitialize)(this.uxMessagesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientViewModelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxMessageTextBox;
        private System.Windows.Forms.Button uxSendMessageButton;
        private System.Windows.Forms.DataGridView uxMessagesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientViewModelBindingSource1;
    }
}