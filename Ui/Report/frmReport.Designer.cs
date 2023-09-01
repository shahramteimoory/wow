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
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblAmount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRun)).BeginInit();
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
            this.dgvTransaction.Location = new System.Drawing.Point(14, 12);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersVisible = false;
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(658, 177);
            this.dgvTransaction.TabIndex = 2;
            this.dgvTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellContentClick);
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
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(202, 396);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 366);
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
            this.label1.Location = new System.Drawing.Point(23, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(79, 348);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(50, 16);
            this.lblPlayerName.TabIndex = 7;
            this.lblPlayerName.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount :";
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
            this.Column13,
            this.Column14});
            this.dgvRun.Location = new System.Drawing.Point(14, 195);
            this.dgvRun.Name = "dgvRun";
            this.dgvRun.ReadOnly = true;
            this.dgvRun.RowHeadersVisible = false;
            this.dgvRun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRun.Size = new System.Drawing.Size(658, 110);
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
            this.Column12.HeaderText = "Gold";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
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
            this.lblAmount.Location = new System.Drawing.Point(79, 396);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(50, 16);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Fury.Properties.Resources.desktop_wallpaper_deathwing_2019_games_world_of_warcraft;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(357, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 120);
            this.panel1.TabIndex = 11;
            // 
            // frmReport
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.dgvRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRun)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewButtonColumn Column14;
    }
}