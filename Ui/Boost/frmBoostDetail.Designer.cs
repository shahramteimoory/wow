namespace Ui.Boost
{
    partial class frmBoostDetail
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAdvID = new System.Windows.Forms.Label();
            this.lblAdvName = new System.Windows.Forms.Label();
            this.dgvRuns = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLvl = new System.Windows.Forms.Label();
            this.LblDungeonName = new System.Windows.Forms.Label();
            this.lblPot = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDataTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuns)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(328, 266);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 23);
            this.btnClose.TabIndex = 83;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAdvID
            // 
            this.lblAdvID.AutoSize = true;
            this.lblAdvID.Location = new System.Drawing.Point(114, 16);
            this.lblAdvID.Name = "lblAdvID";
            this.lblAdvID.Size = new System.Drawing.Size(13, 13);
            this.lblAdvID.TabIndex = 82;
            this.lblAdvID.Text = "0";
            this.lblAdvID.Visible = false;
            // 
            // lblAdvName
            // 
            this.lblAdvName.AutoSize = true;
            this.lblAdvName.Location = new System.Drawing.Point(6, 16);
            this.lblAdvName.Name = "lblAdvName";
            this.lblAdvName.Size = new System.Drawing.Size(102, 13);
            this.lblAdvName.TabIndex = 81;
            this.lblAdvName.Text = "Advertiser: Shahram";
            // 
            // dgvRuns
            // 
            this.dgvRuns.AllowUserToAddRows = false;
            this.dgvRuns.AllowUserToDeleteRows = false;
            this.dgvRuns.AllowUserToResizeColumns = false;
            this.dgvRuns.AllowUserToResizeRows = false;
            this.dgvRuns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRuns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvRuns.Location = new System.Drawing.Point(135, 87);
            this.dgvRuns.Name = "dgvRuns";
            this.dgvRuns.Size = new System.Drawing.Size(464, 173);
            this.dgvRuns.TabIndex = 69;
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
            this.Column3.HeaderText = "Booster Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Role";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cut";
            this.Column5.Name = "Column5";
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.Location = new System.Drawing.Point(26, 40);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(35, 13);
            this.lblLvl.TabIndex = 84;
            this.lblLvl.Text = "label1";
            // 
            // LblDungeonName
            // 
            this.LblDungeonName.AutoSize = true;
            this.LblDungeonName.Location = new System.Drawing.Point(126, 40);
            this.LblDungeonName.Name = "LblDungeonName";
            this.LblDungeonName.Size = new System.Drawing.Size(35, 13);
            this.LblDungeonName.TabIndex = 85;
            this.LblDungeonName.Text = "label2";
            // 
            // lblPot
            // 
            this.lblPot.AutoSize = true;
            this.lblPot.Location = new System.Drawing.Point(327, 40);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(35, 13);
            this.lblPot.TabIndex = 86;
            this.lblPot.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDataTime);
            this.groupBox1.Controls.Add(this.lblAdvName);
            this.groupBox1.Controls.Add(this.lblPot);
            this.groupBox1.Controls.Add(this.lblAdvID);
            this.groupBox1.Controls.Add(this.LblDungeonName);
            this.groupBox1.Controls.Add(this.lblLvl);
            this.groupBox1.Location = new System.Drawing.Point(135, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 64);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boost Detail";
            // 
            // lblDataTime
            // 
            this.lblDataTime.AutoSize = true;
            this.lblDataTime.Location = new System.Drawing.Point(328, 16);
            this.lblDataTime.Name = "lblDataTime";
            this.lblDataTime.Size = new System.Drawing.Size(35, 13);
            this.lblDataTime.TabIndex = 87;
            this.lblDataTime.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Ui.Properties.Resources.Leftwalkery;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(605, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 295);
            this.panel2.TabIndex = 89;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Ui.Properties.Resources.right_dh;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 295);
            this.panel1.TabIndex = 88;
            // 
            // frmBoostDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 295);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRuns);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmBoostDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BoostDetail";
            this.Load += new System.EventHandler(this.frmBoostDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuns)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAdvID;
        private System.Windows.Forms.Label lblAdvName;
        private System.Windows.Forms.DataGridView dgvRuns;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.Label LblDungeonName;
        private System.Windows.Forms.Label lblPot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDataTime;
    }
}