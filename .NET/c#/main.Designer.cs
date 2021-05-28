
namespace ErrorToText
{
    partial class fmMain
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
            this.laTitle = new System.Windows.Forms.Label();
            this.laErrorValue = new System.Windows.Forms.Label();
            this.edErrorValue = new System.Windows.Forms.TextBox();
            this.cbUseLocalFile = new System.Windows.Forms.CheckBox();
            this.btGetErrorInfo = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Location = new System.Drawing.Point(12, 20);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(382, 13);
            this.laTitle.TabIndex = 0;
            this.laTitle.Text = "Enter error code in HEX or DEC in the Edit Box below. HEX should start with 0x.";
            // 
            // laErrorValue
            // 
            this.laErrorValue.AutoSize = true;
            this.laErrorValue.Location = new System.Drawing.Point(12, 53);
            this.laErrorValue.Name = "laErrorValue";
            this.laErrorValue.Size = new System.Drawing.Size(61, 13);
            this.laErrorValue.TabIndex = 1;
            this.laErrorValue.Text = "Error value:";
            // 
            // edErrorValue
            // 
            this.edErrorValue.Location = new System.Drawing.Point(79, 50);
            this.edErrorValue.Name = "edErrorValue";
            this.edErrorValue.Size = new System.Drawing.Size(107, 20);
            this.edErrorValue.TabIndex = 2;
            this.edErrorValue.Text = "0x00000000";
            // 
            // cbUseLocalFile
            // 
            this.cbUseLocalFile.AutoSize = true;
            this.cbUseLocalFile.Location = new System.Drawing.Point(203, 52);
            this.cbUseLocalFile.Name = "cbUseLocalFile";
            this.cbUseLocalFile.Size = new System.Drawing.Size(86, 17);
            this.cbUseLocalFile.TabIndex = 3;
            this.cbUseLocalFile.Text = "Use local file";
            this.cbUseLocalFile.UseVisualStyleBackColor = true;
            // 
            // btGetErrorInfo
            // 
            this.btGetErrorInfo.Location = new System.Drawing.Point(299, 75);
            this.btGetErrorInfo.Name = "btGetErrorInfo";
            this.btGetErrorInfo.Size = new System.Drawing.Size(95, 23);
            this.btGetErrorInfo.TabIndex = 4;
            this.btGetErrorInfo.Text = "Get Error Info";
            this.btGetErrorInfo.UseVisualStyleBackColor = true;
            this.btGetErrorInfo.Click += new System.EventHandler(this.btGetErrorInfo_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(12, 104);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(382, 329);
            this.lbInfo.TabIndex = 5;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btGetErrorInfo);
            this.Controls.Add(this.cbUseLocalFile);
            this.Controls.Add(this.edErrorValue);
            this.Controls.Add(this.laErrorValue);
            this.Controls.Add(this.laTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get WCL Error Infor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.Label laErrorValue;
        private System.Windows.Forms.TextBox edErrorValue;
        private System.Windows.Forms.CheckBox cbUseLocalFile;
        private System.Windows.Forms.Button btGetErrorInfo;
        private System.Windows.Forms.ListBox lbInfo;
    }
}

