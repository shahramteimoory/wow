namespace Ui.Player
{
    partial class frmPlayerManger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayerManger));
            this.txtInsertPlayer = new System.Windows.Forms.TextBox();
            this.btnInsertPlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerSearch = new System.Windows.Forms.TextBox();
            this.dgvPlayerList = new System.Windows.Forms.DataGridView();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRecovery = new System.Windows.Forms.ToolStripButton();
            this.btnHardDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInsertPlayer
            // 
            this.txtInsertPlayer.Location = new System.Drawing.Point(213, 103);
            this.txtInsertPlayer.Name = "txtInsertPlayer";
            this.txtInsertPlayer.Size = new System.Drawing.Size(170, 20);
            this.txtInsertPlayer.TabIndex = 36;
            // 
            // btnInsertPlayer
            // 
            this.btnInsertPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertPlayer.Location = new System.Drawing.Point(389, 101);
            this.btnInsertPlayer.Name = "btnInsertPlayer";
            this.btnInsertPlayer.Size = new System.Drawing.Size(137, 25);
            this.btnInsertPlayer.TabIndex = 37;
            this.btnInsertPlayer.Text = "Insert New Player";
            this.btnInsertPlayer.UseVisualStyleBackColor = true;
            this.btnInsertPlayer.Click += new System.EventHandler(this.btnInsertPlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 35;
            this.label1.Text = "Player Manger";
            // 
            // txtPlayerSearch
            // 
            this.txtPlayerSearch.Location = new System.Drawing.Point(302, 192);
            this.txtPlayerSearch.Name = "txtPlayerSearch";
            this.txtPlayerSearch.Size = new System.Drawing.Size(181, 20);
            this.txtPlayerSearch.TabIndex = 33;
            this.txtPlayerSearch.TextChanged += new System.EventHandler(this.txtPlayerSearch_TextChanged);
            // 
            // dgvPlayerList
            // 
            this.dgvPlayerList.AllowUserToAddRows = false;
            this.dgvPlayerList.AllowUserToDeleteRows = false;
            this.dgvPlayerList.AllowUserToResizeColumns = false;
            this.dgvPlayerList.AllowUserToResizeRows = false;
            this.dgvPlayerList.CausesValidation = false;
            this.dgvPlayerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerID,
            this.Column1,
            this.clmPlayer,
            this.clmEdit,
            this.clmDelete});
            this.dgvPlayerList.Location = new System.Drawing.Point(179, 218);
            this.dgvPlayerList.MultiSelect = false;
            this.dgvPlayerList.Name = "dgvPlayerList";
            this.dgvPlayerList.ReadOnly = true;
            this.dgvPlayerList.RowHeadersVisible = false;
            this.dgvPlayerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayerList.Size = new System.Drawing.Size(367, 231);
            this.dgvPlayerList.TabIndex = 32;
            this.dgvPlayerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayerList_CellContentClick);
            // 
            // PlayerID
            // 
            this.PlayerID.DataPropertyName = "PlayerID";
            this.PlayerID.HeaderText = "PlayerID";
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.ReadOnly = true;
            this.PlayerID.Visible = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 50;
            // 
            // clmPlayer
            // 
            this.clmPlayer.DataPropertyName = "FullName";
            this.clmPlayer.HeaderText = "Player FullName";
            this.clmPlayer.Name = "clmPlayer";
            this.clmPlayer.ReadOnly = true;
            this.clmPlayer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmPlayer.Width = 200;
            // 
            // clmEdit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            this.clmEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmEdit.HeaderText = "Edit";
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmEdit.Width = 60;
            // 
            // clmDelete
            // 
            this.clmDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.clmDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmDelete.HeaderText = "Delete";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Fury.Properties.Resources.Right;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(546, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 449);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Fury.Properties.Resources.Left;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 449);
            this.panel1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRecovery,
            this.btnHardDelete,
            this.toolStripLabel1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(179, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(367, 38);
            this.toolStrip1.TabIndex = 48;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRecovery
            // 
            this.btnRecovery.Image = global::Fury.Properties.Resources.recovery_arrow;
            this.btnRecovery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(59, 35);
            this.btnRecovery.Text = "Recovery";
            this.btnRecovery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // btnHardDelete
            // 
            this.btnHardDelete.Image = global::Fury.Properties.Resources.social_media;
            this.btnHardDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHardDelete.Name = "btnHardDelete";
            this.btnHardDelete.Size = new System.Drawing.Size(70, 35);
            this.btnHardDelete.Text = "HardDelete";
            this.btnHardDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHardDelete.Click += new System.EventHandler(this.btnHardDelete_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(97, 35);
            this.toolStripLabel1.Text = "                              ";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Fury.Properties.Resources.plus_sign;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(94, 35);
            this.toolStripButton2.Text = "Insert Character";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtInsertPlayer;
            this.requiredFieldValidator1.ErrorMessage = "Please Enter Player Name";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // frmPlayerManger
            // 
            this.AcceptButton = this.btnInsertPlayer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 449);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInsertPlayer);
            this.Controls.Add(this.btnInsertPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerSearch);
            this.Controls.Add(this.dgvPlayerList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPlayerManger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Player Manger";
            this.Load += new System.EventHandler(this.frmPlayerManger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInsertPlayer;
        private System.Windows.Forms.Button btnInsertPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayerSearch;
        private System.Windows.Forms.DataGridView dgvPlayerList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRecovery;
        private System.Windows.Forms.ToolStripButton btnHardDelete;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlayer;
        private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
    }
}