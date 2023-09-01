namespace Ui.Dungeon
{
    partial class frmDungeonManger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDungeonManger));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsertDungeon = new System.Windows.Forms.TextBox();
            this.btnInsertDungeon = new System.Windows.Forms.Button();
            this.dgvDungeons = new System.Windows.Forms.DataGridView();
            this.DungeonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DungeonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recoveryHardDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRecoveryDungeon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHardDeleteDungeon = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDungeons)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Fury.Properties.Resources.RightDungeon;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(528, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 400);
            this.panel2.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Fury.Properties.Resources.LeftDungeon;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 400);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 36);
            this.label1.TabIndex = 36;
            this.label1.Text = "Dungeon Manger";
            // 
            // txtInsertDungeon
            // 
            this.txtInsertDungeon.Location = new System.Drawing.Point(6, 28);
            this.txtInsertDungeon.Name = "txtInsertDungeon";
            this.txtInsertDungeon.Size = new System.Drawing.Size(216, 20);
            this.txtInsertDungeon.TabIndex = 38;
            // 
            // btnInsertDungeon
            // 
            this.btnInsertDungeon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertDungeon.Location = new System.Drawing.Point(228, 24);
            this.btnInsertDungeon.Name = "btnInsertDungeon";
            this.btnInsertDungeon.Size = new System.Drawing.Size(95, 26);
            this.btnInsertDungeon.TabIndex = 39;
            this.btnInsertDungeon.Text = "Insert New";
            this.btnInsertDungeon.UseVisualStyleBackColor = true;
            this.btnInsertDungeon.Click += new System.EventHandler(this.btnInsertDungeon_Click);
            // 
            // dgvDungeons
            // 
            this.dgvDungeons.AllowUserToAddRows = false;
            this.dgvDungeons.AllowUserToDeleteRows = false;
            this.dgvDungeons.AllowUserToResizeColumns = false;
            this.dgvDungeons.AllowUserToResizeRows = false;
            this.dgvDungeons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDungeons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DungeonID,
            this.DungeonName,
            this.Edit,
            this.Delete});
            this.dgvDungeons.Location = new System.Drawing.Point(173, 191);
            this.dgvDungeons.Name = "dgvDungeons";
            this.dgvDungeons.ReadOnly = true;
            this.dgvDungeons.RowHeadersVisible = false;
            this.dgvDungeons.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDungeons.Size = new System.Drawing.Size(355, 211);
            this.dgvDungeons.TabIndex = 40;
            this.dgvDungeons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDungeons_CellContentClick);
            // 
            // DungeonID
            // 
            this.DungeonID.DataPropertyName = "DungeonID";
            this.DungeonID.HeaderText = "DungeonID";
            this.DungeonID.Name = "DungeonID";
            this.DungeonID.ReadOnly = true;
            this.DungeonID.Visible = false;
            // 
            // DungeonName
            // 
            this.DungeonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DungeonName.DataPropertyName = "Name";
            this.DungeonName.HeaderText = "Name";
            this.DungeonName.Name = "DungeonName";
            this.DungeonName.ReadOnly = true;
            this.DungeonName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.FillWeight = 60F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Width = 60;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FillWeight = 60F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 60;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtInsertDungeon;
            this.requiredFieldValidator1.ErrorMessage = "Please enter Dungeon Name";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(264, 165);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 20);
            this.txtSearch.TabIndex = 41;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInsertDungeon);
            this.groupBox1.Controls.Add(this.btnInsertDungeon);
            this.groupBox1.Location = new System.Drawing.Point(191, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 67);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "InsertNew Dungeon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Search :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recoveryHardDeleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(175, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(353, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recoveryHardDeleteToolStripMenuItem
            // 
            this.recoveryHardDeleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRecoveryDungeon,
            this.btnHardDeleteDungeon});
            this.recoveryHardDeleteToolStripMenuItem.Name = "recoveryHardDeleteToolStripMenuItem";
            this.recoveryHardDeleteToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.recoveryHardDeleteToolStripMenuItem.Text = "Recovery / Hard Delete";
            // 
            // btnRecoveryDungeon
            // 
            this.btnRecoveryDungeon.Name = "btnRecoveryDungeon";
            this.btnRecoveryDungeon.Size = new System.Drawing.Size(188, 22);
            this.btnRecoveryDungeon.Text = "Recovery Dungeon";
            this.btnRecoveryDungeon.Click += new System.EventHandler(this.btnRecoveryDungeon_Click);
            // 
            // btnHardDeleteDungeon
            // 
            this.btnHardDeleteDungeon.Name = "btnHardDeleteDungeon";
            this.btnHardDeleteDungeon.Size = new System.Drawing.Size(188, 22);
            this.btnHardDeleteDungeon.Text = "Hard Delete Dungeon";
            this.btnHardDeleteDungeon.Click += new System.EventHandler(this.btnHardDeleteDungeon_Click);
            // 
            // frmDungeonManger
            // 
            this.AcceptButton = this.btnInsertDungeon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 400);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDungeons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDungeonManger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DungeonManger";
            this.Load += new System.EventHandler(this.frmDungeonManger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDungeons)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsertDungeon;
        private System.Windows.Forms.Button btnInsertDungeon;
        private System.Windows.Forms.DataGridView dgvDungeons;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recoveryHardDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRecoveryDungeon;
        private System.Windows.Forms.ToolStripMenuItem btnHardDeleteDungeon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DungeonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DungeonName;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}