using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chome
{
    public partial class FrmWeb : DevExpress.XtraEditors.XtraForm
    {
        public FrmWeb()
        {
            InitializeComponent();
            CreateNewPage("","tp");
        }




        /// <summary>
        /// 创建页面
        /// </summary>
        /// <param name="url"></param>
        public void CreateNewPage(string url,string tp)
        {
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
            DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
            DevExpress.XtraBars.BarButtonItem barButtonItem1;
            DevExpress.XtraBars.BarButtonItem barButtonItem2;
            DevExpress.XtraBars.BarButtonItem barButtonItem3;
            DevExpress.XtraBars.BarButtonItem barButtonItem4;
            DevExpress.XtraBars.BarListItem barListItem1;
            DevExpress.XtraBars.BarEditItem barEditItem1;
            DevExpress.XtraBars.BarEditItem barEditItem2;
            DevExpress.XtraBars.BarButtonItem barButtonItem5;
            DevExpress.XtraBars.Bar bar1;
            DevExpress.XtraBars.BarDockControl barDockControlTop;
            DevExpress.XtraBars.BarManager barManager1;
            DevExpress.XtraBars.BarDockControl barDockControlBottom;
            DevExpress.XtraBars.BarDockControl barDockControlLeft;
            DevExpress.XtraBars.BarDockControl barDockControlRight;
            //添加工具栏地址栏还有浏览器组件
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeb));
            repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barListItem1 = new DevExpress.XtraBars.BarListItem();
            barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            bar1 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            ((System.ComponentModel.ISupportInitialize)(repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(barManager1)).BeginInit();
            SuspendLayout();
            // 
            // repositoryItemTextEdit1
            // 
            repositoryItemTextEdit1.AutoHeight = false;
            repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemComboBox1
            // 
            repositoryItemComboBox1.AutoHeight = false;
            repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemComboBox1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barButtonItem1
            // 
            barButtonItem2.Caption = "后退";
            barButtonItem1.Id = 0;
            barButtonItem1.ImageOptions.Image = global::Chome.Properties.Resources.backward_32x32;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "前进";
            barButtonItem2.Id = 1;
            barButtonItem2.ImageOptions.Image = global::Chome.Properties.Resources.forward_32x32;
            barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "刷新";
            barButtonItem3.Id = 2;
            barButtonItem3.ImageOptions.Image = global::Chome.Properties.Resources.reset_32x32;

            barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "主页";
            barButtonItem4.Id = 3;
            barButtonItem4.ImageOptions.Image = global::Chome.Properties.Resources.home_32x32;

            barButtonItem4.Name = "barButtonItem4";
            // 
            // barListItem1
            // 
            barListItem1.Caption = "barListItem1";
            barListItem1.Id = 4;
            barListItem1.Name = "barListItem1";
            // 
            // barEditItem1
            // 
            barEditItem1.Caption = "barEditItem1";
            barEditItem1.Edit = repositoryItemTextEdit1;
            barEditItem1.Id = 5;
            barEditItem1.Name = "barEditItem1";
            // 
            // barEditItem2
            // 
            barEditItem2.Caption = "barEditItem2";
            barEditItem2.Edit = repositoryItemComboBox1;
            barEditItem2.Id = 6;
            barEditItem2.Name = "barEditItem2";
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "Go";
            barButtonItem5.Id = 7;
            barButtonItem5.Name = "barButtonItem5";
            // 
            // bar1
            // 
            bar1.BarName = "Tools";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, barEditItem2, "", false, true, true, 518),
            new DevExpress.XtraBars.LinkPersistInfo(barButtonItem5)});
            bar1.Text = "Tools";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new System.Drawing.Size(995, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 633);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(995, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 633);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(995, 0);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 633);
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            bar1});
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            barButtonItem1,
            barButtonItem2,
            barButtonItem3,
            barButtonItem4,
            barListItem1,
            barEditItem1,
            barEditItem2,
            barButtonItem5});
            barManager1.MaxItemId = 8;
            barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            repositoryItemTextEdit1,
            repositoryItemComboBox1});

            //Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(995, 633);
            tpHome.Controls.Add(barDockControlLeft);
            tpHome.Controls.Add(barDockControlRight);
            tpHome.Controls.Add(barDockControlBottom);
            tpHome.Controls.Add(barDockControlTop);
            IsMdiContainer = true;
            Name = "FrmMain";
            Text = "Chome Explorer";
            ((System.ComponentModel.ISupportInitialize)(repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(barManager1)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

    }
}