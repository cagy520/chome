
namespace chome
{
    partial class FrmCode
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
            this.contextMenuStripEx1 = new ICSharpCode.TextEditor.UserControls.ContextMenuStripEx();
            this.textEditorControlEx1 = new ICSharpCode.TextEditor.TextEditorControlEx();
            this.SuspendLayout();
            // 
            // contextMenuStripEx1
            // 
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Size = new System.Drawing.Size(61, 4);
            // 
            // textEditorControlEx1
            // 
            //this.textEditorControlEx1.FoldingStrategy = null;
            this.textEditorControlEx1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEditorControlEx1.Location = new System.Drawing.Point(0, 12);
            this.textEditorControlEx1.Name = "textEditorControlEx1";
            this.textEditorControlEx1.Size = new System.Drawing.Size(1049, 587);
            //this.textEditorControlEx1.SyntaxHighlighting = null;
            this.textEditorControlEx1.TabIndex = 1;
            this.textEditorControlEx1.Text = "textEditorControlEx1";
            // 
            // FrmCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 602);
            this.Controls.Add(this.textEditorControlEx1);
            this.Name = "FrmCode";
            this.Text = "FrmCode";
            this.ResumeLayout(false);

        }

        #endregion
        private ICSharpCode.TextEditor.UserControls.ContextMenuStripEx contextMenuStripEx1;
        private ICSharpCode.TextEditor.TextEditorControlEx textEditorControlEx1;
    }
}