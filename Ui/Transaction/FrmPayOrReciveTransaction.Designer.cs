namespace Ui.Transaction
{
    partial class FrmPayOrReciveTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPayOrReciveTransaction));
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblFrmType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gpTransaction = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcTransaction = new System.Windows.Forms.PictureBox();
            this.btnUploadFrpmPC = new System.Windows.Forms.Button();
            this.rbFromPC = new System.Windows.Forms.RadioButton();
            this.rbFromURL = new System.Windows.Forms.RadioButton();
            this.txtImageURL = new System.Windows.Forms.TextBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.rbMoney = new System.Windows.Forms.RadioButton();
            this.rbGold = new System.Windows.Forms.RadioButton();
            this.gpTransaction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(244, 47);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "label1";
            // 
            // lblFrmType
            // 
            this.lblFrmType.AutoSize = true;
            this.lblFrmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmType.Location = new System.Drawing.Point(213, 9);
            this.lblFrmType.Name = "lblFrmType";
            this.lblFrmType.Size = new System.Drawing.Size(79, 29);
            this.lblFrmType.TabIndex = 1;
            this.lblFrmType.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Fury.Properties.Resources.goldright;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(430, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 391);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Fury.Properties.Resources.goldleft;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 391);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PlayerName:";
            // 
            // gpTransaction
            // 
            this.gpTransaction.Controls.Add(this.rbMoney);
            this.gpTransaction.Controls.Add(this.rbGold);
            this.gpTransaction.Controls.Add(this.label3);
            this.gpTransaction.Controls.Add(this.txtAmount);
            this.gpTransaction.Controls.Add(this.label2);
            this.gpTransaction.Controls.Add(this.txtTitle);
            this.gpTransaction.Location = new System.Drawing.Point(115, 75);
            this.gpTransaction.Name = "gpTransaction";
            this.gpTransaction.Size = new System.Drawing.Size(308, 92);
            this.gpTransaction.TabIndex = 4;
            this.gpTransaction.TabStop = false;
            this.gpTransaction.Text = "Transaction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(64, 45);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(78, 20);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(64, 19);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(222, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(309, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcTransaction);
            this.groupBox1.Location = new System.Drawing.Point(115, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // pcTransaction
            // 
            this.pcTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcTransaction.InitialImage = null;
            this.pcTransaction.Location = new System.Drawing.Point(6, 19);
            this.pcTransaction.Name = "pcTransaction";
            this.pcTransaction.Size = new System.Drawing.Size(302, 101);
            this.pcTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcTransaction.TabIndex = 10;
            this.pcTransaction.TabStop = false;
            // 
            // btnUploadFrpmPC
            // 
            this.btnUploadFrpmPC.Location = new System.Drawing.Point(212, 171);
            this.btnUploadFrpmPC.Name = "btnUploadFrpmPC";
            this.btnUploadFrpmPC.Size = new System.Drawing.Size(92, 23);
            this.btnUploadFrpmPC.TabIndex = 11;
            this.btnUploadFrpmPC.Text = "UploadImage";
            this.btnUploadFrpmPC.UseVisualStyleBackColor = true;
            this.btnUploadFrpmPC.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbFromPC
            // 
            this.rbFromPC.AutoSize = true;
            this.rbFromPC.Checked = true;
            this.rbFromPC.Location = new System.Drawing.Point(121, 174);
            this.rbFromPC.Name = "rbFromPC";
            this.rbFromPC.Size = new System.Drawing.Size(65, 17);
            this.rbFromPC.TabIndex = 12;
            this.rbFromPC.TabStop = true;
            this.rbFromPC.Text = "From PC";
            this.rbFromPC.UseVisualStyleBackColor = true;
            this.rbFromPC.CheckedChanged += new System.EventHandler(this.rbFromPC_CheckedChanged);
            // 
            // rbFromURL
            // 
            this.rbFromURL.AutoSize = true;
            this.rbFromURL.Location = new System.Drawing.Point(121, 198);
            this.rbFromURL.Name = "rbFromURL";
            this.rbFromURL.Size = new System.Drawing.Size(73, 17);
            this.rbFromURL.TabIndex = 13;
            this.rbFromURL.Text = "From URL";
            this.rbFromURL.UseVisualStyleBackColor = true;
            this.rbFromURL.CheckedChanged += new System.EventHandler(this.rbFromURL_CheckedChanged);
            // 
            // txtImageURL
            // 
            this.txtImageURL.Enabled = false;
            this.txtImageURL.Location = new System.Drawing.Point(212, 197);
            this.txtImageURL.Name = "txtImageURL";
            this.txtImageURL.Size = new System.Drawing.Size(211, 20);
            this.txtImageURL.TabIndex = 14;
            this.txtImageURL.Leave += new System.EventHandler(this.txtImageURL_Leave);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtAmount;
            this.requiredFieldValidator1.ErrorMessage = "Please enter Amount Gold";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtTitle;
            this.requiredFieldValidator2.ErrorMessage = "Please Enter Title";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // rbMoney
            // 
            this.rbMoney.AutoSize = true;
            this.rbMoney.Location = new System.Drawing.Point(159, 46);
            this.rbMoney.Name = "rbMoney";
            this.rbMoney.Size = new System.Drawing.Size(57, 17);
            this.rbMoney.TabIndex = 77;
            this.rbMoney.Text = "Money";
            this.rbMoney.UseVisualStyleBackColor = true;
            // 
            // rbGold
            // 
            this.rbGold.AutoSize = true;
            this.rbGold.Checked = true;
            this.rbGold.Location = new System.Drawing.Point(222, 46);
            this.rbGold.Name = "rbGold";
            this.rbGold.Size = new System.Drawing.Size(47, 17);
            this.rbGold.TabIndex = 76;
            this.rbGold.TabStop = true;
            this.rbGold.Text = "Gold";
            this.rbGold.UseVisualStyleBackColor = true;
            // 
            // FrmPayOrReciveTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 391);
            this.Controls.Add(this.txtImageURL);
            this.Controls.Add(this.rbFromURL);
            this.Controls.Add(this.rbFromPC);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUploadFrpmPC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.gpTransaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFrmType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPayOrReciveTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPayOrReciveTransaction";
            this.Load += new System.EventHandler(this.FrmPayOrReciveTransaction_Load);
            this.gpTransaction.ResumeLayout(false);
            this.gpTransaction.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblFrmType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpTransaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUploadFrpmPC;
        private System.Windows.Forms.PictureBox pcTransaction;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.RadioButton rbFromPC;
        private System.Windows.Forms.RadioButton rbFromURL;
        private System.Windows.Forms.TextBox txtImageURL;
        private System.Windows.Forms.RadioButton rbMoney;
        private System.Windows.Forms.RadioButton rbGold;
    }
}