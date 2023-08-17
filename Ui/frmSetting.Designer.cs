namespace Ui
{
    partial class frmSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOwnerChange = new System.Windows.Forms.TextBox();
            this.btnOwnerChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner Name";
            // 
            // txtOwnerChange
            // 
            this.txtOwnerChange.Location = new System.Drawing.Point(87, 20);
            this.txtOwnerChange.Name = "txtOwnerChange";
            this.txtOwnerChange.Size = new System.Drawing.Size(160, 20);
            this.txtOwnerChange.TabIndex = 1;
            // 
            // btnOwnerChange
            // 
            this.btnOwnerChange.Location = new System.Drawing.Point(102, 46);
            this.btnOwnerChange.Name = "btnOwnerChange";
            this.btnOwnerChange.Size = new System.Drawing.Size(118, 25);
            this.btnOwnerChange.TabIndex = 2;
            this.btnOwnerChange.Text = "Owner Change";
            this.btnOwnerChange.UseVisualStyleBackColor = true;
            this.btnOwnerChange.Click += new System.EventHandler(this.btnOwnerChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "_shahram";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DiscordTag:";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 113);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOwnerChange);
            this.Controls.Add(this.txtOwnerChange);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOwnerChange;
        private System.Windows.Forms.Button btnOwnerChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}