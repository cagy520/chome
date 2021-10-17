using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chome
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            load(uri(cboUrl.Text));
            history(uri(cboUrl.Text));
            cboUrl.Items.Add(uri(cboUrl.Text));
        }

        /// <summary>
        /// 格式化URL地址
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string uri(string url)
        {
            if (!url.Contains("http://")) return  "http://" + url;
            return url;
        }
        private void load(string url)
        {
            try
            {
                this.webView21.Source = new System.Uri(url, System.UriKind.Absolute);
            }
            catch (Exception)
            {
                //MessageBox.Show("无法加载页面:"+ex.Message);
            }
        }

        private void history(string url)
        {
            string history = loadTxt("history.ini");
            if (history.Contains(url)) return;//判断重复就不写文件
            string urls = url + "\r\n" + history;
            writeTxt(urls, "history.ini");
        }

        private void writeTxt(string txt,string file)
        {
            if (txt == "") return;
            try
            {
                StreamWriter sw = new StreamWriter(file);
                sw.Write(txt);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法存储历史记录"+ex.Message);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            loadHistory();
        }

        private void loadHistory()
        {
            string txt = loadTxt("history.ini");
            if (txt == "") return;
            string[] txts = txt.Split("\r\n");
            cboUrl.Items.AddRange(txts);

        }
        private string loadTxt(string file)
        {
            try
            {
                StreamReader rd = new StreamReader(file, true);
                string txt=rd.ReadToEnd();
                rd.Close();
                return txt;
            }
            catch (Exception)
            {
                //MessageBox.Show("无法存储历史记录" + ex.Message);
                return "";
            }
        }
    }
}
