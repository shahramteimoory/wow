namespace Ui.Boost
{
    partial class frmBoostEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoostEdit));
            this.dgvRuns = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insert = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlayerNameFilter = new System.Windows.Forms.TextBox();
            this.gbRole = new System.Windows.Forms.GroupBox();
            this.TANK = new System.Windows.Forms.Panel();
            this.HEAL = new System.Windows.Forms.Panel();
            this.DPS = new System.Windows.Forms.Panel();
            this.lblAdvID = new System.Windows.Forms.Label();
            this.lblAdvName = new System.Windows.Forms.Label();
            this.chbOwner = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGoldPot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDungeonLvl = new System.Windows.Forms.ComboBox();
            this.cbDungeonName = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chbAutoCompute = new System.Windows.Forms.CheckBox();
            this.rbGold = new System.Windows.Forms.RadioButton();
            this.rbMoney = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.gbRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRuns
            // 
            this.dgvRuns.AllowUserToAddRows = false;
            this.dgvRuns.AllowUserToResizeColumns = false;
            this.dgvRuns.AllowUserToResizeRows = false;
            this.dgvRuns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRuns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8});
            this.dgvRuns.Location = new System.Drawing.Point(264, 68);
            this.dgvRuns.Name = "dgvRuns";
            this.dgvRuns.RowHeadersVisible = false;
            this.dgvRuns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRuns.Size = new System.Drawing.Size(500, 173);
            this.dgvRuns.TabIndex = 54;
            this.dgvRuns.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRuns_CellContentClick);
            this.dgvRuns.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvRuns_RowsRemoved);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "RunID";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PlayerID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RoleID";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "PlayerName";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Role";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cut";
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column8.HeaderText = "Delete";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 70;
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AllowUserToResizeColumns = false;
            this.dgvPlayers.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Insert});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayers.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlayers.Location = new System.Drawing.Point(64, 97);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(194, 144);
            this.dgvPlayers.TabIndex = 58;
            this.dgvPlayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayers_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlayerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PlayerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PlayerName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Insert
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.Insert.DefaultCellStyle = dataGridViewCellStyle3;
            this.Insert.HeaderText = "Insert";
            this.Insert.Name = "Insert";
            this.Insert.ReadOnly = true;
            this.Insert.Text = "Insert";
            this.Insert.Width = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Player Name Filter";
            // 
            // txtPlayerNameFilter
            // 
            this.txtPlayerNameFilter.Location = new System.Drawing.Point(64, 68);
            this.txtPlayerNameFilter.Name = "txtPlayerNameFilter";
            this.txtPlayerNameFilter.Size = new System.Drawing.Size(194, 20);
            this.txtPlayerNameFilter.TabIndex = 56;
            // 
            // gbRole
            // 
            this.gbRole.Controls.Add(this.TANK);
            this.gbRole.Controls.Add(this.HEAL);
            this.gbRole.Controls.Add(this.DPS);
            this.gbRole.Location = new System.Drawing.Point(6, 94);
            this.gbRole.Name = "gbRole";
            this.gbRole.Size = new System.Drawing.Size(52, 148);
            this.gbRole.TabIndex = 55;
            this.gbRole.TabStop = false;
            this.gbRole.Text = "Roles";
            // 
            // TANK
            // 
            this.TANK.BackgroundImage = global::Fury.Properties.Resources.Tank1;
            this.TANK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TANK.Location = new System.Drawing.Point(6, 63);
            this.TANK.Name = "TANK";
            this.TANK.Size = new System.Drawing.Size(42, 30);
            this.TANK.TabIndex = 45;
            this.TANK.Click += new System.EventHandler(this.btnSelectRole_Click);
            // 
            // HEAL
            // 
            this.HEAL.BackgroundImage = global::Fury.Properties.Resources.Healer;
            this.HEAL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HEAL.Location = new System.Drawing.Point(6, 108);
            this.HEAL.Name = "HEAL";
            this.HEAL.Size = new System.Drawing.Size(42, 30);
            this.HEAL.TabIndex = 45;
            this.HEAL.Click += new System.EventHandler(this.btnSelectRole_Click);
            // 
            // DPS
            // 
            this.DPS.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DPS.BackgroundImage = global::Fury.Properties.Resources.DPS1;
            this.DPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DPS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DPS.Location = new System.Drawing.Point(6, 19);
            this.DPS.Name = "DPS";
            this.DPS.Size = new System.Drawing.Size(42, 30);
            this.DPS.TabIndex = 45;
            this.DPS.Click += new System.EventHandler(this.btnSelectRole_Click);
            // 
            // lblAdvID
            // 
            this.lblAdvID.AutoSize = true;
            this.lblAdvID.Location = new System.Drawing.Point(181, 27);
            this.lblAdvID.Name = "lblAdvID";
            this.lblAdvID.Size = new System.Drawing.Size(13, 13);
            this.lblAdvID.TabIndex = 67;
            this.lblAdvID.Text = "0";
            this.lblAdvID.Visible = false;
            // 
            // lblAdvName
            // 
            this.lblAdvName.AutoSize = true;
            this.lblAdvName.Location = new System.Drawing.Point(9, 7);
            this.lblAdvName.Name = "lblAdvName";
            this.lblAdvName.Size = new System.Drawing.Size(87, 13);
            this.lblAdvName.TabIndex = 66;
            this.lblAdvName.Text = "Advertiser: its me";
            // 
            // chbOwner
            // 
            this.chbOwner.AutoSize = true;
            this.chbOwner.Checked = true;
            this.chbOwner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbOwner.Location = new System.Drawing.Point(12, 25);
            this.chbOwner.Name = "chbOwner";
            this.chbOwner.Size = new System.Drawing.Size(71, 17);
            this.chbOwner.TabIndex = 65;
            this.chbOwner.Text = "It\'s Mine?";
            this.chbOwner.UseVisualStyleBackColor = true;
            this.chbOwner.CheckedChanged += new System.EventHandler(this.chbOwner_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Pot Gold";
            // 
            // txtGoldPot
            // 
            this.txtGoldPot.Location = new System.Drawing.Point(487, 24);
            this.txtGoldPot.Name = "txtGoldPot";
            this.txtGoldPot.Size = new System.Drawing.Size(110, 20);
            this.txtGoldPot.TabIndex = 63;
            this.txtGoldPot.TextChanged += new System.EventHandler(this.txtGoldPot_TextChanged);
            this.txtGoldPot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoldPot_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Lvl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Dungeon Name";
            // 
            // cbDungeonLvl
            // 
            this.cbDungeonLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDungeonLvl.FormattingEnabled = true;
            this.cbDungeonLvl.Items.AddRange(new object[] {
            "0",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27"});
            this.cbDungeonLvl.Location = new System.Drawing.Point(202, 23);
            this.cbDungeonLvl.Name = "cbDungeonLvl";
            this.cbDungeonLvl.Size = new System.Drawing.Size(49, 21);
            this.cbDungeonLvl.TabIndex = 59;
            // 
            // cbDungeonName
            // 
            this.cbDungeonName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDungeonName.FormattingEnabled = true;
            this.cbDungeonName.Location = new System.Drawing.Point(257, 23);
            this.cbDungeonName.Name = "cbDungeonName";
            this.cbDungeonName.Size = new System.Drawing.Size(206, 21);
            this.cbDungeonName.TabIndex = 60;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(603, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 23);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chbAutoCompute
            // 
            this.chbAutoCompute.AutoSize = true;
            this.chbAutoCompute.Location = new System.Drawing.Point(511, 45);
            this.chbAutoCompute.Name = "chbAutoCompute";
            this.chbAutoCompute.Size = new System.Drawing.Size(93, 17);
            this.chbAutoCompute.TabIndex = 69;
            this.chbAutoCompute.Text = "Auto Compute";
            this.chbAutoCompute.UseVisualStyleBackColor = true;
            this.chbAutoCompute.CheckedChanged += new System.EventHandler(this.chbAutoCompute_CheckedChanged);
            // 
            // rbGold
            // 
            this.rbGold.AutoSize = true;
            this.rbGold.Checked = true;
            this.rbGold.Location = new System.Drawing.Point(415, 45);
            this.rbGold.Name = "rbGold";
            this.rbGold.Size = new System.Drawing.Size(47, 17);
            this.rbGold.TabIndex = 70;
            this.rbGold.TabStop = true;
            this.rbGold.Text = "Gold";
            this.rbGold.UseVisualStyleBackColor = true;
            // 
            // rbMoney
            // 
            this.rbMoney.AutoSize = true;
            this.rbMoney.Location = new System.Drawing.Point(352, 45);
            this.rbMoney.Name = "rbMoney";
            this.rbMoney.Size = new System.Drawing.Size(57, 17);
            this.rbMoney.TabIndex = 71;
            this.rbMoney.Text = "Money";
            this.rbMoney.UseVisualStyleBackColor = true;
            // 
            // frmBoostEdit
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 251);
            this.Controls.Add(this.rbMoney);
            this.Controls.Add(this.rbGold);
            this.Controls.Add(this.chbAutoCompute);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAdvID);
            this.Controls.Add(this.lblAdvName);
            this.Controls.Add(this.chbOwner);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGoldPot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbDungeonLvl);
            this.Controls.Add(this.cbDungeonName);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPlayerNameFilter);
            this.Controls.Add(this.gbRole);
            this.Controls.Add(this.dgvRuns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBoostEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Boost Edit";
            this.Load += new System.EventHandler(this.frmBoostEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.gbRole.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRuns;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlayerNameFilter;
        private System.Windows.Forms.GroupBox gbRole;
        private System.Windows.Forms.Panel TANK;
        private System.Windows.Forms.Panel HEAL;
        private System.Windows.Forms.Panel DPS;
        private System.Windows.Forms.Label lblAdvID;
        private System.Windows.Forms.Label lblAdvName;
        private System.Windows.Forms.CheckBox chbOwner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGoldPot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDungeonLvl;
        private System.Windows.Forms.ComboBox cbDungeonName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chbAutoCompute;
        private System.Windows.Forms.RadioButton rbGold;
        private System.Windows.Forms.RadioButton rbMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn Insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
    }
}