namespace Fury.Player
{
    partial class frmHardDeletePlayer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPlayerHardDelete = new System.Windows.Forms.DataGridView();
            this.txtPlayerFilter = new System.Windows.Forms.TextBox();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HardDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerHardDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayerHardDelete
            // 
            this.dgvPlayerHardDelete.AllowUserToAddRows = false;
            this.dgvPlayerHardDelete.AllowUserToDeleteRows = false;
            this.dgvPlayerHardDelete.AllowUserToResizeColumns = false;
            this.dgvPlayerHardDelete.AllowUserToResizeRows = false;
            this.dgvPlayerHardDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerHardDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerID,
            this.PlayerFullName,
            this.HardDelete});
            this.dgvPlayerHardDelete.Location = new System.Drawing.Point(2, 30);
            this.dgvPlayerHardDelete.Name = "dgvPlayerHardDelete";
            this.dgvPlayerHardDelete.ReadOnly = true;
            this.dgvPlayerHardDelete.RowHeadersVisible = false;
            this.dgvPlayerHardDelete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayerHardDelete.Size = new System.Drawing.Size(208, 160);
            this.dgvPlayerHardDelete.TabIndex = 0;
            this.dgvPlayerHardDelete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayerHardDelete_CellContentClick);
            // 
            // txtPlayerFilter
            // 
            this.txtPlayerFilter.Location = new System.Drawing.Point(11, 4);
            this.txtPlayerFilter.Name = "txtPlayerFilter";
            this.txtPlayerFilter.Size = new System.Drawing.Size(189, 20);
            this.txtPlayerFilter.TabIndex = 1;
            this.txtPlayerFilter.TextChanged += new System.EventHandler(this.txtPlayerFilter_TextChanged);
            // 
            // PlayerID
            // 
            this.PlayerID.DataPropertyName = "PlayerID";
            this.PlayerID.HeaderText = "PlayerID";
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.ReadOnly = true;
            this.PlayerID.Visible = false;
            // 
            // PlayerFullName
            // 
            this.PlayerFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlayerFullName.DataPropertyName = "FullName";
            this.PlayerFullName.HeaderText = "FullName";
            this.PlayerFullName.Name = "PlayerFullName";
            this.PlayerFullName.ReadOnly = true;
            // 
            // HardDelete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            this.HardDelete.DefaultCellStyle = dataGridViewCellStyle1;
            this.HardDelete.HeaderText = "HardDelete";
            this.HardDelete.Name = "HardDelete";
            this.HardDelete.ReadOnly = true;
            this.HardDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HardDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HardDelete.Width = 70;
            // 
            // frmHardDeletePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 198);
            this.Controls.Add(this.txtPlayerFilter);
            this.Controls.Add(this.dgvPlayerHardDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmHardDeletePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hard Delete Player";
            this.Load += new System.EventHandler(this.frmHardDeletePlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerHardDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayerHardDelete;
        private System.Windows.Forms.TextBox txtPlayerFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerFullName;
        private System.Windows.Forms.DataGridViewButtonColumn HardDelete;
    }
}