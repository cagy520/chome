
namespace chome
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUrl = new System.Windows.Forms.ComboBox();
            this.btnSpk = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAI = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(-1, 42);
            this.webView21.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1375, 693);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(916, 9);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(73, 25);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // cboUrl
            // 
            this.cboUrl.FormattingEnabled = true;
            this.cboUrl.Location = new System.Drawing.Point(226, 9);
            this.cboUrl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboUrl.Name = "cboUrl";
            this.cboUrl.Size = new System.Drawing.Size(686, 25);
            this.cboUrl.TabIndex = 4;
            // 
            // btnSpk
            // 
            this.btnSpk.Location = new System.Drawing.Point(1012, 9);
            this.btnSpk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSpk.Name = "btnSpk";
            this.btnSpk.Size = new System.Drawing.Size(73, 25);
            this.btnSpk.TabIndex = 6;
            this.btnSpk.Text = "语音识别";
            this.btnSpk.UseVisualStyleBackColor = true;
            this.btnSpk.Click += new System.EventHandler(this.btnSpk_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 734);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1374, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtInfo
            // 
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // btnAI
            // 
            this.btnAI.Location = new System.Drawing.Point(1161, 9);
            this.btnAI.Name = "btnAI";
            this.btnAI.Size = new System.Drawing.Size(75, 23);
            this.btnAI.TabIndex = 10;
            this.btnAI.Text = "加载语义分析";
            this.btnAI.UseVisualStyleBackColor = true;
            this.btnAI.Click += new System.EventHandler(this.btnAI_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1266, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 756);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAI);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSpk);
            this.Controls.Add(this.cboUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.webView21);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmMain";
            this.Text = "Chome Explorer";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUrl;
        private System.Windows.Forms.Button btnSpk;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtInfo;
        private System.Windows.Forms.Button btnAI;
        private System.Windows.Forms.Button button1;
    }
}

