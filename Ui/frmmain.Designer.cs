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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnPlayer = new System.Windows.Forms.ToolStripButton();
            this.btnDungeon = new System.Windows.Forms.ToolStripButton();
            this.btnBoost = new System.Windows.Forms.ToolStripButton();
            this.btnBoostList = new System.Windows.Forms.ToolStripButton();
            this.btnTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWowTokenPrice = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chengToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlayer,
            this.btnDungeon,
            this.btnBoost,
            this.btnBoostList,
            this.btnTransaction,
            this.btnReport});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(804, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlayer.Image = global::Fury.Properties.Resources.Add_user_P;
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
            this.btnDungeon.Image = global::Fury.Properties.Resources.ezgif_com_webp_to_png__1_;
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
            this.btnBoost.Image = global::Fury.Properties.Resources.Thunder;
            this.btnBoost.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBoost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoost.Name = "btnBoost";
            this.btnBoost.Size = new System.Drawing.Size(43, 59);
            this.btnBoost.Text = "Boost";
            this.btnBoost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoost.Click += new System.EventHandler(this.btnBoost_Click);
            // 
            // btnBoostList
            // 
            this.btnBoostList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoostList.Image = global::Fury.Properties.Resources.list;
            this.btnBoostList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBoostList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoostList.Name = "btnBoostList";
            this.btnBoostList.Size = new System.Drawing.Size(62, 59);
            this.btnBoostList.Text = "Boost List";
            this.btnBoostList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoostList.Click += new System.EventHandler(this.btnBoostList_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Image = global::Fury.Properties.Resources.Gold_2;
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
            this.btnReport.Image = global::Fury.Properties.Resources.Report;
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
            this.lblWowTokenPrice,
            this.toolStripStatusLabel2,
            this.lblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 520);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(181, 17);
            this.toolStripStatusLabel1.Text = "                         Wow Token Price : ";
            // 
            // lblWowTokenPrice
            // 
            this.lblWowTokenPrice.Name = "lblWowTokenPrice";
            this.lblWowTokenPrice.Size = new System.Drawing.Size(118, 17);
            this.lblWowTokenPrice.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel2.Text = "                           ";
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(118, 17);
            this.lblVersion.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Fury.Properties.Resources.dfm5ypq_f2e10d2a_c527_444a_b3b4_7e550a2cf252;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 456);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chengToolStripMenuItem,
            this.aboutMeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // chengToolStripMenuItem
            // 
            this.chengToolStripMenuItem.Name = "chengToolStripMenuItem";
            this.chengToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.chengToolStripMenuItem.Text = "Change owner";
            this.chengToolStripMenuItem.Click += new System.EventHandler(this.chengToolStripMenuItem_Click);
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.aboutMeToolStripMenuItem.Text = "About Me";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.toolStripMenuItem1.Text = "       ";
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 542);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton btnDungeon;
        private System.Windows.Forms.ToolStripButton btnBoost;
        private System.Windows.Forms.ToolStripButton btnTransaction;
        private System.Windows.Forms.ToolStripButton btnReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chengToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnBoostList;
        private System.Windows.Forms.ToolStripStatusLabel lblWowTokenPrice;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    }
}