namespace Fury.Player
{
    partial class frmRecoveryPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecoveryPlayer));
            this.dgvRecoveryPlayer = new System.Windows.Forms.DataGridView();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recovery = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtPlayerFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecoveryPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecoveryPlayer
            // 
            this.dgvRecoveryPlayer.AllowUserToAddRows = false;
            this.dgvRecoveryPlayer.AllowUserToDeleteRows = false;
            this.dgvRecoveryPlayer.AllowUserToResizeColumns = false;
            this.dgvRecoveryPlayer.AllowUserToResizeRows = false;
            this.dgvRecoveryPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecoveryPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerID,
            this.PlayerFullName,
            this.Recovery});
            this.dgvRecoveryPlayer.Location = new System.Drawing.Point(0, 35);
            this.dgvRecoveryPlayer.Name = "dgvRecoveryPlayer";
            this.dgvRecoveryPlayer.ReadOnly = true;
            this.dgvRecoveryPlayer.RowHeadersVisible = false;
            this.dgvRecoveryPlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecoveryPlayer.Size = new System.Drawing.Size(248, 186);
            this.dgvRecoveryPlayer.TabIndex = 0;
            this.dgvRecoveryPlayer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecoveryPlayer_CellContentClick);
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
            // Recovery
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            this.Recovery.DefaultCellStyle = dataGridViewCellStyle1;
            this.Recovery.HeaderText = "Recovery";
            this.Recovery.Name = "Recovery";
            this.Recovery.ReadOnly = true;
            this.Recovery.Width = 70;
            // 
            // txtPlayerFilter
            // 
            this.txtPlayerFilter.Location = new System.Drawing.Point(12, 9);
            this.txtPlayerFilter.Name = "txtPlayerFilter";
            this.txtPlayerFilter.Size = new System.Drawing.Size(226, 20);
            this.txtPlayerFilter.TabIndex = 1;
            this.txtPlayerFilter.TextChanged += new System.EventHandler(this.txtPlayerFilter_TextChanged);
            // 
            // frmRecoveryPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 226);
            this.Controls.Add(this.txtPlayerFilter);
            this.Controls.Add(this.dgvRecoveryPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecoveryPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recovery";
            this.Load += new System.EventHandler(this.frmRecoveryPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecoveryPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecoveryPlayer;
        private System.Windows.Forms.TextBox txtPlayerFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerFullName;
        private System.Windows.Forms.DataGridViewButtonColumn Recovery;
    }
}