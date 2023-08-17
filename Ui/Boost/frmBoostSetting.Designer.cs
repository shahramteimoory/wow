namespace Ui.Boost
{
    partial class frmBoostSetting
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
            this.dgvBoostList = new System.Windows.Forms.DataGridView();
            this.BoostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DungeonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoostDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDetailBoost = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.chbToDate = new System.Windows.Forms.CheckBox();
            this.chbFromDate = new System.Windows.Forms.CheckBox();
            this.btnDateFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoostList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBoostList
            // 
            this.dgvBoostList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoostList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BoostID,
            this.PlayerID,
            this.DungeonID,
            this.Gold,
            this.Lvl,
            this.BoostDateTime});
            this.dgvBoostList.Location = new System.Drawing.Point(22, 171);
            this.dgvBoostList.Name = "dgvBoostList";
            this.dgvBoostList.Size = new System.Drawing.Size(539, 171);
            this.dgvBoostList.TabIndex = 0;
            // 
            // BoostID
            // 
            this.BoostID.DataPropertyName = "BoostID";
            this.BoostID.HeaderText = "BoostID";
            this.BoostID.Name = "BoostID";
            this.BoostID.Visible = false;
            // 
            // PlayerID
            // 
            this.PlayerID.DataPropertyName = "PlayerID";
            this.PlayerID.HeaderText = "AdvertiserName";
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.Width = 120;
            // 
            // DungeonID
            // 
            this.DungeonID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DungeonID.DataPropertyName = "DungeonID";
            this.DungeonID.HeaderText = "DungeonName";
            this.DungeonID.Name = "DungeonID";
            // 
            // Gold
            // 
            this.Gold.DataPropertyName = "Gold";
            this.Gold.HeaderText = "Pot";
            this.Gold.Name = "Gold";
            this.Gold.Width = 80;
            // 
            // Lvl
            // 
            this.Lvl.DataPropertyName = "Lvl";
            this.Lvl.HeaderText = "Lvl";
            this.Lvl.Name = "Lvl";
            this.Lvl.Width = 40;
            // 
            // BoostDateTime
            // 
            this.BoostDateTime.DataPropertyName = "DateTime";
            this.BoostDateTime.HeaderText = "DateTime";
            this.BoostDateTime.Name = "BoostDateTime";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDetailBoost,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(579, 93);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDetailBoost
            // 
            this.btnDetailBoost.Image = global::Ui.Properties.Resources.Edit1;
            this.btnDetailBoost.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDetailBoost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDetailBoost.Name = "btnDetailBoost";
            this.btnDetailBoost.Size = new System.Drawing.Size(85, 90);
            this.btnDetailBoost.Text = "View Detail";
            this.btnDetailBoost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDetailBoost.Click += new System.EventHandler(this.btnDetailBoost_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Ui.Properties.Resources.icons8_delete_100;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 90);
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.dateTo);
            this.gbFilter.Controls.Add(this.dateFrom);
            this.gbFilter.Controls.Add(this.chbToDate);
            this.gbFilter.Controls.Add(this.chbFromDate);
            this.gbFilter.Controls.Add(this.btnDateFilter);
            this.gbFilter.Controls.Add(this.label4);
            this.gbFilter.Controls.Add(this.txtfilter);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Location = new System.Drawing.Point(22, 96);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(539, 69);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // dateTo
            // 
            this.dateTo.Enabled = false;
            this.dateTo.Location = new System.Drawing.Point(312, 43);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTo.TabIndex = 15;
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Enabled = false;
            this.dateFrom.Location = new System.Drawing.Point(312, 19);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateFrom.TabIndex = 4;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // chbToDate
            // 
            this.chbToDate.AutoSize = true;
            this.chbToDate.Location = new System.Drawing.Point(226, 46);
            this.chbToDate.Name = "chbToDate";
            this.chbToDate.Size = new System.Drawing.Size(63, 17);
            this.chbToDate.TabIndex = 14;
            this.chbToDate.Text = "To date";
            this.chbToDate.UseVisualStyleBackColor = true;
            this.chbToDate.CheckedChanged += new System.EventHandler(this.chbToDate_CheckedChanged);
            // 
            // chbFromDate
            // 
            this.chbFromDate.AutoSize = true;
            this.chbFromDate.Location = new System.Drawing.Point(226, 20);
            this.chbFromDate.Name = "chbFromDate";
            this.chbFromDate.Size = new System.Drawing.Size(75, 17);
            this.chbFromDate.TabIndex = 13;
            this.chbFromDate.Text = "From Date";
            this.chbFromDate.UseVisualStyleBackColor = true;
            this.chbFromDate.CheckedChanged += new System.EventHandler(this.chbFromDate_CheckedChanged);
            // 
            // btnDateFilter
            // 
            this.btnDateFilter.Location = new System.Drawing.Point(118, 27);
            this.btnDateFilter.Name = "btnDateFilter";
            this.btnDateFilter.Size = new System.Drawing.Size(75, 23);
            this.btnDateFilter.TabIndex = 12;
            this.btnDateFilter.Text = "DateFilter";
            this.btnDateFilter.UseVisualStyleBackColor = true;
            this.btnDateFilter.Click += new System.EventHandler(this.btnDateFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "*Developer note(pref use advertiser Name)";
            // 
            // txtfilter
            // 
            this.txtfilter.Location = new System.Drawing.Point(12, 29);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Size = new System.Drawing.Size(100, 20);
            this.txtfilter.TabIndex = 10;
            this.txtfilter.TextChanged += new System.EventHandler(this.txtfilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = " Filter";
            // 
            // frmBoostSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 354);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvBoostList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmBoostSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Boost Setting";
            this.Load += new System.EventHandler(this.frmBoostSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoostList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBoostList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDetailBoost;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDateFilter;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.CheckBox chbToDate;
        private System.Windows.Forms.CheckBox chbFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DungeonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoostDateTime;
    }
}