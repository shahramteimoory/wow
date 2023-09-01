namespace Fury.Dungeon
{
    partial class frmRecoveryDungeon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecoveryDungeon));
            this.txtFilterDeleted = new System.Windows.Forms.TextBox();
            this.dgvDeletedDungeon = new System.Windows.Forms.DataGridView();
            this.DungeonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recovery = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedDungeon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterDeleted
            // 
            this.txtFilterDeleted.Location = new System.Drawing.Point(3, 3);
            this.txtFilterDeleted.Name = "txtFilterDeleted";
            this.txtFilterDeleted.Size = new System.Drawing.Size(218, 20);
            this.txtFilterDeleted.TabIndex = 3;
            this.txtFilterDeleted.TextChanged += new System.EventHandler(this.txtFilterDeleted_TextChanged);
            // 
            // dgvDeletedDungeon
            // 
            this.dgvDeletedDungeon.AllowUserToAddRows = false;
            this.dgvDeletedDungeon.AllowUserToDeleteRows = false;
            this.dgvDeletedDungeon.AllowUserToResizeColumns = false;
            this.dgvDeletedDungeon.AllowUserToResizeRows = false;
            this.dgvDeletedDungeon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedDungeon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DungeonID,
            this.clmName,
            this.Recovery});
            this.dgvDeletedDungeon.Location = new System.Drawing.Point(3, 39);
            this.dgvDeletedDungeon.Name = "dgvDeletedDungeon";
            this.dgvDeletedDungeon.ReadOnly = true;
            this.dgvDeletedDungeon.RowHeadersVisible = false;
            this.dgvDeletedDungeon.Size = new System.Drawing.Size(218, 225);
            this.dgvDeletedDungeon.TabIndex = 2;
            this.dgvDeletedDungeon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeletedDungeon_CellContentClick);
            // 
            // DungeonID
            // 
            this.DungeonID.DataPropertyName = "DungeonID";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            this.DungeonID.DefaultCellStyle = dataGridViewCellStyle1;
            this.DungeonID.HeaderText = "DungeonID";
            this.DungeonID.Name = "DungeonID";
            this.DungeonID.ReadOnly = true;
            this.DungeonID.Visible = false;
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmName.DataPropertyName = "Name";
            this.clmName.HeaderText = "DungeonName";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Recovery
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            this.Recovery.DefaultCellStyle = dataGridViewCellStyle2;
            this.Recovery.HeaderText = "Recovery";
            this.Recovery.Name = "Recovery";
            this.Recovery.ReadOnly = true;
            this.Recovery.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Recovery.Width = 60;
            // 
            // frmRecoveryDungeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 267);
            this.Controls.Add(this.txtFilterDeleted);
            this.Controls.Add(this.dgvDeletedDungeon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecoveryDungeon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recovery";
            this.Load += new System.EventHandler(this.frmRecoveryDungeon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedDungeon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilterDeleted;
        private System.Windows.Forms.DataGridView dgvDeletedDungeon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DungeonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewButtonColumn Recovery;
    }
}