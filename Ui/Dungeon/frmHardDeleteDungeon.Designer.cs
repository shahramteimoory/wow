namespace Fury.Dungeon
{
    partial class frmHardDeleteDungeon
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
            this.dgvDeletedDungeon = new System.Windows.Forms.DataGridView();
            this.txtFilterDeleted = new System.Windows.Forms.TextBox();
            this.DungeonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedDungeon)).BeginInit();
            this.SuspendLayout();
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
            this.Delete});
            this.dgvDeletedDungeon.Location = new System.Drawing.Point(12, 38);
            this.dgvDeletedDungeon.Name = "dgvDeletedDungeon";
            this.dgvDeletedDungeon.ReadOnly = true;
            this.dgvDeletedDungeon.RowHeadersVisible = false;
            this.dgvDeletedDungeon.Size = new System.Drawing.Size(219, 229);
            this.dgvDeletedDungeon.TabIndex = 0;
            this.dgvDeletedDungeon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeletedDungeon_CellContentClick);
            // 
            // txtFilterDeleted
            // 
            this.txtFilterDeleted.Location = new System.Drawing.Point(12, 12);
            this.txtFilterDeleted.Name = "txtFilterDeleted";
            this.txtFilterDeleted.Size = new System.Drawing.Size(218, 20);
            this.txtFilterDeleted.TabIndex = 1;
            this.txtFilterDeleted.TextChanged += new System.EventHandler(this.txtFilterDeleted_TextChanged);
            // 
            // DungeonID
            // 
            this.DungeonID.DataPropertyName = "DungeonID";
            this.DungeonID.HeaderText = "DungeonID";
            this.DungeonID.Name = "DungeonID";
            this.DungeonID.ReadOnly = true;
            this.DungeonID.Visible = false;
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmName.DataPropertyName = "Name";
            this.clmName.HeaderText = "Dungeon Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 60;
            // 
            // frmHardDeleteDungeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 269);
            this.Controls.Add(this.txtFilterDeleted);
            this.Controls.Add(this.dgvDeletedDungeon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHardDeleteDungeon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hard Delete";
            this.Load += new System.EventHandler(this.frmHardDeleteDungeon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedDungeon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeletedDungeon;
        private System.Windows.Forms.TextBox txtFilterDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn DungeonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}