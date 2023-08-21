namespace Ui.Boost
{
    partial class frmBoostManger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoostManger));
            this.cbDungeonName = new System.Windows.Forms.ComboBox();
            this.cbDungeonLvl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGoldPot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbRole = new System.Windows.Forms.GroupBox();
            this.TANK = new System.Windows.Forms.Panel();
            this.HEAL = new System.Windows.Forms.Panel();
            this.DPS = new System.Windows.Forms.Panel();
            this.txtPlayerNameFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insert = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSaveBoost = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chbOwner = new System.Windows.Forms.CheckBox();
            this.lblAdvName = new System.Windows.Forms.Label();
            this.lblAdvID = new System.Windows.Forms.Label();
            this.dgvRuns = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chbAutoCompute = new System.Windows.Forms.CheckBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.gbRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuns)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDungeonName
            // 
            this.cbDungeonName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDungeonName.FormattingEnabled = true;
            this.cbDungeonName.Location = new System.Drawing.Point(281, 29);
            this.cbDungeonName.Name = "cbDungeonName";
            this.cbDungeonName.Size = new System.Drawing.Size(206, 21);
            this.cbDungeonName.TabIndex = 37;
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
            this.cbDungeonLvl.Location = new System.Drawing.Point(222, 29);
            this.cbDungeonLvl.Name = "cbDungeonLvl";
            this.cbDungeonLvl.Size = new System.Drawing.Size(49, 21);
            this.cbDungeonLvl.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Dungeon Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Lvl";
            // 
            // txtGoldPot
            // 
            this.txtGoldPot.Location = new System.Drawing.Point(504, 30);
            this.txtGoldPot.Name = "txtGoldPot";
            this.txtGoldPot.Size = new System.Drawing.Size(131, 20);
            this.txtGoldPot.TabIndex = 42;
            this.txtGoldPot.TextChanged += new System.EventHandler(this.txtGoldPot_TextChanged);
            this.txtGoldPot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoldPot_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Pot Gold";
            // 
            // gbRole
            // 
            this.gbRole.Controls.Add(this.TANK);
            this.gbRole.Controls.Add(this.HEAL);
            this.gbRole.Controls.Add(this.DPS);
            this.gbRole.Location = new System.Drawing.Point(9, 103);
            this.gbRole.Name = "gbRole";
            this.gbRole.Size = new System.Drawing.Size(52, 158);
            this.gbRole.TabIndex = 44;
            this.gbRole.TabStop = false;
            this.gbRole.Text = "Roles";
            // 
            // TANK
            // 
            this.TANK.BackgroundImage = global::Fury.Properties.Resources.Tank1;
            this.TANK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TANK.Location = new System.Drawing.Point(6, 63);
            this.TANK.Name = "TANK";
            this.TANK.Size = new System.Drawing.Size(42, 30);
            this.TANK.TabIndex = 45;
            this.TANK.Click += new System.EventHandler(this.btnSelectRole_Click);
            // 
            // HEAL
            // 
            this.HEAL.BackgroundImage = global::Fury.Properties.Resources.Healer;
            this.HEAL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            // txtPlayerNameFilter
            // 
            this.txtPlayerNameFilter.Location = new System.Drawing.Point(67, 77);
            this.txtPlayerNameFilter.Name = "txtPlayerNameFilter";
            this.txtPlayerNameFilter.Size = new System.Drawing.Size(194, 20);
            this.txtPlayerNameFilter.TabIndex = 45;
            this.txtPlayerNameFilter.TextChanged += new System.EventHandler(this.txtPlayerNameFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Player Name Filter";
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerID,
            this.FullName,
            this.Insert});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlayers.Location = new System.Drawing.Point(67, 106);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(194, 144);
            this.dgvPlayers.TabIndex = 47;
            this.dgvPlayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayers_CellContentClick);
            // 
            // PlayerID
            // 
            this.PlayerID.DataPropertyName = "PlayerID";
            this.PlayerID.HeaderText = "PlayerID";
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.ReadOnly = true;
            this.PlayerID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "PlayerName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Insert
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Insert.DefaultCellStyle = dataGridViewCellStyle2;
            this.Insert.HeaderText = "Insert";
            this.Insert.Name = "Insert";
            this.Insert.ReadOnly = true;
            this.Insert.Text = "Insert";
            this.Insert.Width = 50;
            // 
            // btnSaveBoost
            // 
            this.btnSaveBoost.Location = new System.Drawing.Point(401, 256);
            this.btnSaveBoost.Name = "btnSaveBoost";
            this.btnSaveBoost.Size = new System.Drawing.Size(249, 23);
            this.btnSaveBoost.TabIndex = 48;
            this.btnSaveBoost.Text = "Save";
            this.btnSaveBoost.UseVisualStyleBackColor = true;
            this.btnSaveBoost.Click += new System.EventHandler(this.btnSaveBoost_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(161, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(234, 23);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chbOwner
            // 
            this.chbOwner.AutoSize = true;
            this.chbOwner.Checked = true;
            this.chbOwner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbOwner.Location = new System.Drawing.Point(13, 32);
            this.chbOwner.Name = "chbOwner";
            this.chbOwner.Size = new System.Drawing.Size(71, 17);
            this.chbOwner.TabIndex = 50;
            this.chbOwner.Text = "It\'s Mine?";
            this.chbOwner.UseVisualStyleBackColor = true;
            this.chbOwner.CheckedChanged += new System.EventHandler(this.chbOwner_CheckedChanged);
            // 
            // lblAdvName
            // 
            this.lblAdvName.AutoSize = true;
            this.lblAdvName.Location = new System.Drawing.Point(90, 33);
            this.lblAdvName.Name = "lblAdvName";
            this.lblAdvName.Size = new System.Drawing.Size(87, 13);
            this.lblAdvName.TabIndex = 51;
            this.lblAdvName.Text = "Advertiser: its me";
            // 
            // lblAdvID
            // 
            this.lblAdvID.AutoSize = true;
            this.lblAdvID.Location = new System.Drawing.Point(198, 33);
            this.lblAdvID.Name = "lblAdvID";
            this.lblAdvID.Size = new System.Drawing.Size(13, 13);
            this.lblAdvID.TabIndex = 52;
            this.lblAdvID.Text = "0";
            this.lblAdvID.Visible = false;
            // 
            // dgvRuns
            // 
            this.dgvRuns.AllowUserToAddRows = false;
            this.dgvRuns.AllowUserToDeleteRows = false;
            this.dgvRuns.AllowUserToResizeColumns = false;
            this.dgvRuns.AllowUserToResizeRows = false;
            this.dgvRuns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRuns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvRuns.Location = new System.Drawing.Point(267, 86);
            this.dgvRuns.Name = "dgvRuns";
            this.dgvRuns.RowHeadersVisible = false;
            this.dgvRuns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRuns.Size = new System.Drawing.Size(383, 164);
            this.dgvRuns.TabIndex = 53;
            this.dgvRuns.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRuns_CellContentClick);
            this.dgvRuns.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvRuns_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PlayerID";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RoleID";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "PlayerName";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Role";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cut";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column6
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column6.HeaderText = "Delete";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Text = "Delete";
            this.Column6.Width = 60;
            // 
            // chbAutoCompute
            // 
            this.chbAutoCompute.AutoSize = true;
            this.chbAutoCompute.Checked = true;
            this.chbAutoCompute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAutoCompute.Location = new System.Drawing.Point(504, 56);
            this.chbAutoCompute.Name = "chbAutoCompute";
            this.chbAutoCompute.Size = new System.Drawing.Size(93, 17);
            this.chbAutoCompute.TabIndex = 54;
            this.chbAutoCompute.Text = "Auto Compute";
            this.chbAutoCompute.UseVisualStyleBackColor = true;
            this.chbAutoCompute.CheckedChanged += new System.EventHandler(this.chbAutoCompute_CheckedChanged);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtGoldPot;
            this.requiredFieldValidator1.ErrorMessage = "Please Enter Pot";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // frmBoostManger
            // 
            this.AcceptButton = this.btnSaveBoost;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(662, 288);
            this.Controls.Add(this.chbAutoCompute);
            this.Controls.Add(this.dgvRuns);
            this.Controls.Add(this.lblAdvID);
            this.Controls.Add(this.lblAdvName);
            this.Controls.Add(this.chbOwner);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveBoost);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerNameFilter);
            this.Controls.Add(this.gbRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGoldPot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDungeonLvl);
            this.Controls.Add(this.cbDungeonName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmBoostManger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Boost Manger";
            this.Load += new System.EventHandler(this.frmBoostManger_Load);
            this.gbRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDungeonName;
        private System.Windows.Forms.ComboBox cbDungeonLvl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGoldPot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbRole;
        private System.Windows.Forms.Panel TANK;
        private System.Windows.Forms.Panel HEAL;
        private System.Windows.Forms.Panel DPS;
        private System.Windows.Forms.TextBox txtPlayerNameFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Button btnSaveBoost;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chbOwner;
        private System.Windows.Forms.Label lblAdvName;
        private System.Windows.Forms.Label lblAdvID;
        private System.Windows.Forms.DataGridView dgvRuns;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.CheckBox chbAutoCompute;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewButtonColumn Insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}