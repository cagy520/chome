using ICSharpCode.TextEditor.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chome
{
    public partial class FrmCode : Form
    {
        public FrmCode()
        {
            InitializeComponent();
            textEditorControlEx1.ShowEOLMarkers = false;
            textEditorControlEx1.ShowHRuler = false;
            textEditorControlEx1.ShowInvalidLines = false;
            textEditorControlEx1.ShowMatchingBracket = true;
            textEditorControlEx1.ShowSpaces = false;
            textEditorControlEx1.ShowTabs = false;
            textEditorControlEx1.ShowVRuler = false;
            textEditorControlEx1.AllowCaretBeyondEOL = false;
            textEditorControlEx1.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
            textEditorControlEx1.Encoding = Encoding.GetEncoding("UTF-8");
        }
    }
}
