namespace ChatClient
{
    partial class JoinRoomPrompt
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
            this.uxChatRoomsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uxChatRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uxChatRoomsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxChatRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxChatRoomsDGV
            // 
            this.uxChatRoomsDGV.AutoGenerateColumns = false;
            this.uxChatRoomsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxChatRoomsDGV.ColumnHeadersVisible = false;
            this.uxChatRoomsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.uxChatRoomsDGV.DataSource = this.uxChatRoomBindingSource;
            this.uxChatRoomsDGV.Location = new System.Drawing.Point(49, 129);
            this.uxChatRoomsDGV.Name = "uxChatRoomsDGV";
            this.uxChatRoomsDGV.RowHeadersVisible = false;
            this.uxChatRoomsDGV.RowTemplate.Height = 46;
            this.uxChatRoomsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxChatRoomsDGV.Size = new System.Drawing.Size(699, 264);
            this.uxChatRoomsDGV.TabIndex = 0;
            this.uxChatRoomsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxChatRoomsDGV_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double click a chat room below to join:";
            // 
            // uxChatRoomBindingSource
            // 
            this.uxChatRoomBindingSource.DataMember = "ChatRooms";
            this.uxChatRoomBindingSource.DataSource = typeof(ChatClient.ClientViewModel);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // JoinRoomPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxChatRoomsDGV);
            this.Name = "JoinRoomPrompt";
            this.Text = "Join a Chat Room!";
            ((System.ComponentModel.ISupportInitialize)(this.uxChatRoomsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxChatRoomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxChatRoomsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource uxChatRoomBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}