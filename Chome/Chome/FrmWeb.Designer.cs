
namespace Chome
{
    partial class FrmWeb
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
            this.Tp = new DevExpress.XtraBars.Navigation.TabPane();
            ((System.ComponentModel.ISupportInitialize)(this.Tp)).BeginInit();
            this.SuspendLayout();
            // 
            // Tp
            // 
            this.Tp.AllowHtmlDraw = true;
            this.Tp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tp.Location = new System.Drawing.Point(0, 0);
            this.Tp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tp.Name = "Tp";
            this.Tp.RegularSize = new System.Drawing.Size(1142, 863);
            this.Tp.SelectedPage = null;
            this.Tp.Size = new System.Drawing.Size(1142, 863);
            this.Tp.TabIndex = 0;
            this.Tp.Text = "tabPane1";
            // 
            // FrmWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 863);
            this.Controls.Add(this.Tp);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmWeb";
            this.Text = "FrmWeb";
            ((System.ComponentModel.ISupportInitialize)(this.Tp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane Tp;
    }
}