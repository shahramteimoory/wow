﻿namespace Ui.Transaction
{
    partial class frmTransactionDetail
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
            this.dgvTransactionDetail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pcTransactionDetail = new System.Windows.Forms.PictureBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.llblLink = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcTransactionDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransactionDetail
            // 
            this.dgvTransactionDetail.AllowUserToAddRows = false;
            this.dgvTransactionDetail.AllowUserToDeleteRows = false;
            this.dgvTransactionDetail.AllowUserToResizeColumns = false;
            this.dgvTransactionDetail.AllowUserToResizeRows = false;
            this.dgvTransactionDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvTransactionDetail.Location = new System.Drawing.Point(99, 12);
            this.dgvTransactionDetail.MultiSelect = false;
            this.dgvTransactionDetail.Name = "dgvTransactionDetail";
            this.dgvTransactionDetail.ReadOnly = true;
            this.dgvTransactionDetail.RowHeadersVisible = false;
            this.dgvTransactionDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionDetail.Size = new System.Drawing.Size(450, 150);
            this.dgvTransactionDetail.TabIndex = 0;
            this.dgvTransactionDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionDetail_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TransactionID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 130F;
            this.Column2.HeaderText = "Player Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 80F;
            this.Column4.HeaderText = "Type";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 110F;
            this.Column5.HeaderText = "DateTime";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Title";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "image";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Select";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.pcTransactionDetail);
            this.groupBox1.Location = new System.Drawing.Point(99, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Image";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(172, 152);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pcTransactionDetail
            // 
            this.pcTransactionDetail.Image = global::Ui.Properties.Resources.images__1_;
            this.pcTransactionDetail.InitialImage = global::Ui.Properties.Resources.images__1_;
            this.pcTransactionDetail.Location = new System.Drawing.Point(6, 19);
            this.pcTransactionDetail.Name = "pcTransactionDetail";
            this.pcTransactionDetail.Size = new System.Drawing.Size(438, 127);
            this.pcTransactionDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcTransactionDetail.TabIndex = 0;
            this.pcTransactionDetail.TabStop = false;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(105, 168);
            this.TxtTitle.Multiline = true;
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.ReadOnly = true;
            this.TxtTitle.Size = new System.Drawing.Size(450, 24);
            this.TxtTitle.TabIndex = 0;
            this.TxtTitle.Text = "Title";
            // 
            // llblLink
            // 
            this.llblLink.AutoSize = true;
            this.llblLink.Location = new System.Drawing.Point(102, 194);
            this.llblLink.Name = "llblLink";
            this.llblLink.Size = new System.Drawing.Size(59, 13);
            this.llblLink.TabIndex = 3;
            this.llblLink.TabStop = true;
            this.llblLink.Text = "Image Link";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Ui.Properties.Resources.goldright;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(555, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 390);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Ui.Properties.Resources.goldleft;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 390);
            this.panel1.TabIndex = 2;
            // 
            // frmTransactionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 390);
            this.Controls.Add(this.llblLink);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTransactionDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "frmTransactionDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transaction Details";
            this.Load += new System.EventHandler(this.frmTransactionDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcTransactionDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactionDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcTransactionDetail;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.LinkLabel llblLink;
    }
}