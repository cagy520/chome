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
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using aichome;
using Npgsql;
using System.Text.RegularExpressions;

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
            if (!url.Contains("http://") && !url.Contains("https://")) return "http://" + url;
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

        private void writeTxt(string txt, string file)
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
                MessageBox.Show("无法存储历史记录" + ex.Message);
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
                string txt = rd.ReadToEnd();
                rd.Close();
                return txt;
            }
            catch (Exception)
            {
                //MessageBox.Show("无法存储历史记录" + ex.Message);
                return "";
            }
        }
        //SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        //private void spkInit()
        //{
        //    Choices preCmd = new Choices();
        //    preCmd.Add(new string[] { "name", "age" });
        //    GrammarBuilder gb = new GrammarBuilder();
        //    gb.Append(preCmd);
        //    Grammar gr = new Grammar(gb);
        //    recEngine.LoadGrammarAsync(gr);
        //    recEngine.SetInputToDefaultAudioDevice();
        //    recEngine.SpeechRecognized += recEngine_SpeechRecognized;
        //}
        private async Task fromMicAsync()
        {
            var speechConfig = SpeechConfig.FromSubscription("5aea227bdc4b45f6a8977d3a4dea1c350", "eastasia");
            speechConfig.SpeechRecognitionLanguage = "zh-CN";
            //speechConfig.EnableDictation();
            using var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            using var recognizer = new SpeechRecognizer(speechConfig, audioConfig);
            //Console.WriteLine("Speak into your microphone.");
            var result = await recognizer.RecognizeOnceAsync();
            txtInfo.Text = result.Text;
            //Console.WriteLine($"RECOGNIZED: Text={result.Text}");
            //if (result.Text.Contains("打开百度"))
            //{
            //    SynthesisToSpeakerAsync("好的，已经帮你打开了百度，但是能不能显示我就不知道了");
            //    load("https://www.baidu.com");
            //}
            LoadCode lc = new LoadCode();
            SynthesisToSpeakerAsync(GetRes(result.Text));
            
            btnSpk.Enabled = true;
        }



        private string GetRes(string t)
        {
            if (t == "") return "";
            t = Regex.Replace(t, "[ \\[ \\] \\^ \\-_*×――(^)（^）$%~!@#$…&%￥—+=<>《》!！??？:：•`·、。，；,.;\"‘’“”-]", "");
            string connString = "Host=fun.cagy.io;Port=2088;Username=postgres;Password=173542558;Database=chome";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("select an from qa where q ='"+t+"' limit 1", conn))
                {
                    string res = "";
                    try
                    {
                        res = cmd.ExecuteScalar().ToString();
                        conn.Close();
                        return res;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("插入数据库的异常:" + ex.Message + "sql:" + t);
                        conn.Close();
                    }
                    return "Sorry，没听明白你的意思，我可能还有点傻！";
                }
            }
        }

        private void btnSpk_Click(object sender, EventArgs e)
        {
            btnSpk.Enabled = false;
            fromMicAsync();
        }

        public async Task SynthesisToSpeakerAsync(string text)
        {
            if (text == "") return;
            var config = SpeechConfig.FromSubscription("5aea227bdc4b45f6a8977d3a4dea1c350", "eastasia");
            config.SpeechRecognitionLanguage = "zh-CN";
            config.SpeechSynthesisLanguage = "zh-CN";
            //https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/language-support#neural-voices
            //zh-CN-XiaoxiaoNeural 正常女
            //zh-CN-XiaoyouNeural 儿童
            //zh-CN-XiaomoNeural 高傲女
            //zh-CN-XiaoxuanNeural 科幻女
            //zh-CN-XiaohanNeural 普通正常女
            //zh-CN-XiaoruiNeural 难听熟女
            //zh-TW-HsiaoChenNeural Taiwan难听
            config.SpeechSynthesisVoiceName = "zh-CN-XiaoxiaoNeural";
            SpeechSynthesizer synthesizer = null;
            using (synthesizer = new SpeechSynthesizer(config))
            {
                using (var result = await synthesizer.SpeakTextAsync(text))
                {
                    if (result.Reason == ResultReason.SynthesizingAudioCompleted)
                    {
                        //textBox1.Text += $"识别读取文本： [{text}]\r\n";
                    }
                    else if (result.Reason == ResultReason.Canceled)
                    {
                        var cancellation = SpeechSynthesisCancellationDetails.FromResult(result);
                        //textBox1.Text += ($"CANCELED: Reason={cancellation.Reason}\r\n");

                        if (cancellation.Reason == CancellationReason.Error)
                        {
                            //textBox1.Text += ($"CANCELED: ErrorCode={cancellation.ErrorCode}\r\n");
                            //textBox1.Text += ($"CANCELED: ErrorDetails=[{cancellation.ErrorDetails}]\r\n");
                            //textBox1.Text += ($"CANCELED: Did you update the subscription info?\r\n");
                        }
                    }
                }
            }
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            //LoadCode lc = new LoadCode();
            //MessageBox.Show(lc.LoadModel());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCode fc = new FrmCode();
            fc.Show();
        }
    }
}
