namespace Ui
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnBoostSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnPlayer = new System.Windows.Forms.ToolStripButton();
            this.btnDungeon = new System.Windows.Forms.ToolStripButton();
            this.btnBoost = new System.Windows.Forms.ToolStripButton();
            this.btnTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateShamsi = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetAllDate = new System.Windows.Forms.Button();
            this.cbxReset = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetting,
            this.toolStripLabel1,
            this.btnBoostSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(868, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSetting
            // 
            this.btnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(48, 22);
            this.btnSetting.Text = "Setting";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel1.Text = "             ";
            // 
            // btnBoostSetting
            // 
            this.btnBoostSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBoostSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnBoostSetting.Image")));
            this.btnBoostSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoostSetting.Name = "btnBoostSetting";
            this.btnBoostSetting.Size = new System.Drawing.Size(81, 22);
            this.btnBoostSetting.Text = "Boost Setting";
            this.btnBoostSetting.Click += new System.EventHandler(this.btnBoostSetting_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlayer,
            this.btnDungeon,
            this.btnBoost,
            this.btnTransaction,
            this.btnReport});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(868, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlayer.Image = global::Ui.Properties.Resources.Add_user_P;
            this.btnPlayer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(43, 59);
            this.btnPlayer.Text = "Player";
            this.btnPlayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPlayer.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnDungeon
            // 
            this.btnDungeon.Image = global::Ui.Properties.Resources.ezgif_com_webp_to_png__1_;
            this.btnDungeon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDungeon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDungeon.Name = "btnDungeon";
            this.btnDungeon.Size = new System.Drawing.Size(60, 59);
            this.btnDungeon.Text = "Dungeon";
            this.btnDungeon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDungeon.Click += new System.EventHandler(this.btnDungeon_Click);
            // 
            // btnBoost
            // 
            this.btnBoost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBoost.Image = global::Ui.Properties.Resources.Thunder;
            this.btnBoost.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBoost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoost.Name = "btnBoost";
            this.btnBoost.Size = new System.Drawing.Size(43, 59);
            this.btnBoost.Text = "Boost";
            this.btnBoost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoost.Click += new System.EventHandler(this.btnBoost_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Image = global::Ui.Properties.Resources.Gold_2;
            this.btnTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(71, 59);
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransaction.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.Image = global::Ui.Properties.Resources.Report;
            this.btnReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(46, 59);
            this.btnReport.Text = "Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.lblVersion,
            this.lblDateShamsi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 586);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(118, 17);
            this.lblDate.Text = "toolStripStatusLabel1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 17);
            this.lblTime.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(124, 17);
            this.toolStripStatusLabel1.Text = "                                       ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(283, 17);
            this.toolStripStatusLabel2.Text = "                                                                                 " +
    "           ";
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(118, 17);
            this.lblVersion.Text = "toolStripStatusLabel3";
            // 
            // lblDateShamsi
            // 
            this.lblDateShamsi.Name = "lblDateShamsi";
            this.lblDateShamsi.Size = new System.Drawing.Size(118, 15);
            this.lblDateShamsi.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Ui.Properties.Resources.dfm5ypq_f2e10d2a_c527_444a_b3b4_7e550a2cf252;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cbxReset);
            this.panel1.Controls.Add(this.btnResetAllDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 521);
            this.panel1.TabIndex = 2;
            // 
            // btnResetAllDate
            // 
            this.btnResetAllDate.Location = new System.Drawing.Point(766, 430);
            this.btnResetAllDate.Name = "btnResetAllDate";
            this.btnResetAllDate.Size = new System.Drawing.Size(99, 27);
            this.btnResetAllDate.TabIndex = 1;
            this.btnResetAllDate.Text = "Reset All Date";
            this.btnResetAllDate.UseVisualStyleBackColor = true;
            this.btnResetAllDate.Visible = false;
            this.btnResetAllDate.Click += new System.EventHandler(this.btnResetAllDate_Click);
            // 
            // cbxReset
            // 
            this.cbxReset.AutoSize = true;
            this.cbxReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxReset.Location = new System.Drawing.Point(804, 482);
            this.cbxReset.Name = "cbxReset";
            this.cbxReset.Size = new System.Drawing.Size(61, 14);
            this.cbxReset.TabIndex = 2;
            this.cbxReset.Text = "Dont toch this ";
            this.cbxReset.UseVisualStyleBackColor = true;
            this.cbxReset.CheckedChanged += new System.EventHandler(this.cbxReset_CheckedChanged);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 608);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblDateShamsi;
        private System.Windows.Forms.ToolStripButton btnDungeon;
        private System.Windows.Forms.ToolStripButton btnBoost;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnBoostSetting;
        private System.Windows.Forms.ToolStripButton btnTransaction;
        private System.Windows.Forms.ToolStripButton btnReport;
        private System.Windows.Forms.ToolStripButton btnSetting;
        private System.Windows.Forms.Button btnResetAllDate;
        private System.Windows.Forms.CheckBox cbxReset;
    }
}