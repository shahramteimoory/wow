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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayerManger));
            this.txtInsertPlayer = new System.Windows.Forms.TextBox();
            this.btnInsertPlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerSearch = new System.Windows.Forms.TextBox();
            this.dgvPlayerList = new System.Windows.Forms.DataGridView();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInsertPlayer
            // 
            this.txtInsertPlayer.Location = new System.Drawing.Point(185, 75);
            this.txtInsertPlayer.Name = "txtInsertPlayer";
            this.txtInsertPlayer.Size = new System.Drawing.Size(170, 20);
            this.txtInsertPlayer.TabIndex = 36;
            // 
            // btnInsertPlayer
            // 
            this.btnInsertPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertPlayer.Location = new System.Drawing.Point(361, 73);
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
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 35;
            this.label1.Text = "Player Manger";
            // 
            // txtPlayerSearch
            // 
            this.txtPlayerSearch.Location = new System.Drawing.Point(265, 125);
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
            this.clmPlayer,
            this.clmEdit,
            this.clmDelete});
            this.dgvPlayerList.Location = new System.Drawing.Point(180, 151);
            this.dgvPlayerList.MultiSelect = false;
            this.dgvPlayerList.Name = "dgvPlayerList";
            this.dgvPlayerList.ReadOnly = true;
            this.dgvPlayerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayerList.Size = new System.Drawing.Size(322, 228);
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
            // clmPlayer
            // 
            this.clmPlayer.DataPropertyName = "FullName";
            this.clmPlayer.HeaderText = "Player FullName";
            this.clmPlayer.Name = "clmPlayer";
            this.clmPlayer.ReadOnly = true;
            this.clmPlayer.Width = 150;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = "Edit";
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmEdit.Width = 60;
            // 
            // clmDelete
            // 
            this.clmDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDelete.HeaderText = "Delete";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Ui.Properties.Resources.Right;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(504, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 378);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Ui.Properties.Resources.Left;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 378);
            this.panel1.TabIndex = 30;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtInsertPlayer;
            this.requiredFieldValidator1.ErrorMessage = "Please Enter Player Name";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search :";
            // 
            // frmPlayerManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInsertPlayer);
            this.Controls.Add(this.btnInsertPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerSearch);
            this.Controls.Add(this.dgvPlayerList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmPlayerManger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Player Manger";
            this.Load += new System.EventHandler(this.frmPlayerManger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerList)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlayer;
        private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.Label label2;
    }
}