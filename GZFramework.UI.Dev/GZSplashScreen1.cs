using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace GZFramework.UI.Dev
{
    public partial class GZ_SplashScreen1 : SplashScreen
    {
        public GZ_SplashScreen1()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
            SplashScreenCommand command = (SplashScreenCommand)cmd;
            if (command == SplashScreenCommand.Setinfo)
            {
                Info pos = (Info)arg;
                //progressBarControl1.Position = pos.Pos;
                labelControl2.Text = pos.LabelText;
            }
        }

        #endregion

        public enum SplashScreenCommand
        {
            Setinfo
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 0x01;
            const int HTCAPTION = 0x02;
            if (m.Msg == WM_NCHITTEST)
            {
                this.DefWndProc(ref m);
                if (m.Result.ToInt32() == HTCLIENT)
                    m.Result = new IntPtr(HTCAPTION);
                else
                    base.WndProc(ref m);
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            //this.Activate();
        }

        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
        private const int HT_CLIENT = 0x1;

        private void pictureEdit2_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).Capture = false;
            Message msg = Message.Create(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            WndProc(ref   msg);
        }

    }

    public class Info
    {
        /// <summary>
        /// 滚动条的位置信息
        /// </summary>
        public int Pos { get; set; }
        /// <summary>
        /// 混动条上对应的文字信息
        /// </summary>
        public string LabelText { get; set; }
    }
    
}