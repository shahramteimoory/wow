namespace Ui.Report
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCreditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDebtor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBallance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRun = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblAmount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAmountMoney = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatusMoney = new System.Windows.Forms.Label();
            this.dgvTransactionMoney = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCreditorM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDebtorM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBallanceM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatusM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTickM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionMoney)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToResizeColumns = false;
            this.dgvTransaction.AllowUserToResizeRows = false;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column15,
            this.cCreditor,
            this.cDebtor,
            this.cBallance,
            this.cStatus,
            this.cTick});
            this.dgvTransaction.Location = new System.Drawing.Point(6, 16);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersVisible = false;
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(679, 167);
            this.dgvTransaction.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DateTime";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 140;
            // 
            // Column15
            // 
            this.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column15.HeaderText = "Title";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cCreditor
            // 
            this.cCreditor.HeaderText = "Creditor";
            this.cCreditor.Name = "cCreditor";
            this.cCreditor.ReadOnly = true;
            this.cCreditor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cCreditor.Width = 60;
            // 
            // cDebtor
            // 
            this.cDebtor.HeaderText = "Debtor";
            this.cDebtor.Name = "cDebtor";
            this.cDebtor.ReadOnly = true;
            this.cDebtor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cDebtor.Width = 60;
            // 
            // cBallance
            // 
            this.cBallance.HeaderText = "Ballance";
            this.cBallance.Name = "cBallance";
            this.cBallance.ReadOnly = true;
            this.cBallance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cBallance.Width = 60;
            // 
            // cStatus
            // 
            this.cStatus.HeaderText = "Status";
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            this.cStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cStatus.Width = 65;
            // 
            // cTick
            // 
            this.cTick.HeaderText = "Column1";
            this.cTick.Name = "cTick";
            this.cTick.ReadOnly = true;
            this.cTick.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(258, 586);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 549);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(69, 559);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(50, 16);
            this.lblPlayerName.TabIndex = 7;
            this.lblPlayerName.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount Gold :";
            // 
            // dgvRun
            // 
            this.dgvRun.AllowUserToAddRows = false;
            this.dgvRun.AllowUserToDeleteRows = false;
            this.dgvRun.AllowUserToResizeColumns = false;
            this.dgvRun.AllowUserToResizeRows = false;
            this.dgvRun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column10,
            this.BoostID,
            this.Column11,
            this.Column12,
            this.Method,
            this.Column13,
            this.Column14});
            this.dgvRun.Location = new System.Drawing.Point(4, 384);
            this.dgvRun.Name = "dgvRun";
            this.dgvRun.ReadOnly = true;
            this.dgvRun.RowHeadersVisible = false;
            this.dgvRun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRun.Size = new System.Drawing.Size(679, 137);
            this.dgvRun.TabIndex = 9;
            this.dgvRun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRun_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PlayerID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "RunID";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // BoostID
            // 
            this.BoostID.HeaderText = "BoostID";
            this.BoostID.Name = "BoostID";
            this.BoostID.ReadOnly = true;
            this.BoostID.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Role";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 60;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Amount";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Method
            // 
            this.Method.HeaderText = "Method";
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            this.Method.Width = 80;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.HeaderText = "Dungeon";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            this.Column14.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column14.HeaderText = "ViewBoost";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column14.Width = 70;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(102, 587);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(50, 16);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Fury.Properties.Resources.desktop_wallpaper_deathwing_2019_games_world_of_warcraft;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(357, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 120);
            this.panel1.TabIndex = 11;
            // 
            // lblAmountMoney
            // 
            this.lblAmountMoney.AutoSize = true;
            this.lblAmountMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountMoney.Location = new System.Drawing.Point(103, 619);
            this.lblAmountMoney.Name = "lblAmountMoney";
            this.lblAmountMoney.Size = new System.Drawing.Size(50, 16);
            this.lblAmountMoney.TabIndex = 14;
            this.lblAmountMoney.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 619);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Amount Money :";
            // 
            // lblStatusMoney
            // 
            this.lblStatusMoney.AutoSize = true;
            this.lblStatusMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusMoney.Location = new System.Drawing.Point(249, 620);
            this.lblStatusMoney.Name = "lblStatusMoney";
            this.lblStatusMoney.Size = new System.Drawing.Size(47, 15);
            this.lblStatusMoney.TabIndex = 12;
            this.lblStatusMoney.Text = "label1";
            // 
            // dgvTransactionMoney
            // 
            this.dgvTransactionMoney.AllowUserToAddRows = false;
            this.dgvTransactionMoney.AllowUserToDeleteRows = false;
            this.dgvTransactionMoney.AllowUserToResizeColumns = false;
            this.dgvTransactionMoney.AllowUserToResizeRows = false;
            this.dgvTransactionMoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionMoney.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.cCreditorM,
            this.cDebtorM,
            this.cBallanceM,
            this.cStatusM,
            this.cTickM});
            this.dgvTransactionMoney.Location = new System.Drawing.Point(0, 19);
            this.dgvTransactionMoney.Name = "dgvTransactionMoney";
            this.dgvTransactionMoney.ReadOnly = true;
            this.dgvTransactionMoney.RowHeadersVisible = false;
            this.dgvTransactionMoney.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionMoney.Size = new System.Drawing.Size(679, 155);
            this.dgvTransactionMoney.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "DateTime";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cCreditorM
            // 
            this.cCreditorM.HeaderText = "Creditor";
            this.cCreditorM.Name = "cCreditorM";
            this.cCreditorM.ReadOnly = true;
            this.cCreditorM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cCreditorM.Width = 60;
            // 
            // cDebtorM
            // 
            this.cDebtorM.HeaderText = "Debtor";
            this.cDebtorM.Name = "cDebtorM";
            this.cDebtorM.ReadOnly = true;
            this.cDebtorM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cDebtorM.Width = 60;
            // 
            // cBallanceM
            // 
            this.cBallanceM.HeaderText = "Ballance";
            this.cBallanceM.Name = "cBallanceM";
            this.cBallanceM.ReadOnly = true;
            this.cBallanceM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cBallanceM.Width = 60;
            // 
            // cStatusM
            // 
            this.cStatusM.HeaderText = "Status";
            this.cStatusM.Name = "cStatusM";
            this.cStatusM.ReadOnly = true;
            this.cStatusM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cStatusM.Width = 65;
            // 
            // cTickM
            // 
            this.cTickM.HeaderText = "Column1";
            this.cTickM.Name = "cTickM";
            this.cTickM.ReadOnly = true;
            this.cTickM.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTransaction);
            this.groupBox1.Location = new System.Drawing.Point(-2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 189);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gold";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTransactionMoney);
            this.groupBox2.Location = new System.Drawing.Point(4, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 180);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Money";
            // 
            // frmReport
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvRun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAmountMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStatusMoney);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionMoney)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRun;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCreditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDebtor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBallance;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTick;
        private System.Windows.Forms.Label lblAmountMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatusMoney;
        private System.Windows.Forms.DataGridView dgvTransactionMoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewButtonColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCreditorM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDebtorM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBallanceM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatusM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTickM;
    }
}