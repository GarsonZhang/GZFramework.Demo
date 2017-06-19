using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.Common
{
    public class Msg
    {
        /// <summary>
        /// 打开对话框
        /// </summary>
        /// <param name="msg">本次对话内容</param>
        /// <returns></returns>
        public static bool AskQuestion(string msg)
        {
            DialogResult r;
            r = XtraMessageBox.Show(msg, "确认",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            return (r == DialogResult.Yes);
        }

        /// <summary>
        /// 显示系统异常
        /// </summary>
        /// <param name="e">系统异常</param>
        public static void ShowException(Exception e)
        {
            string s = e.Message;
            string innerMsg = string.Empty;

            if (e.InnerException != null)
            {
                innerMsg = e.InnerException.Message;
                s += "\n" + innerMsg;
            }

            Warning(s);
        }



        /// <summary>
        /// 警告提示框
        /// </summary>
        /// <param name="msg">警告内容</param>
        public static void Warning(string msg)
        {
            XtraMessageBox.Show(msg, "警告",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// 错误消息提示框
        /// </summary>
        /// <param name="msg">错误消息内容</param>
        public static void ShowError(string msg)
        {
            XtraMessageBox.Show(msg, "警告",
                MessageBoxButtons.OK,
                MessageBoxIcon.Hand,
                MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// 信息提示框
        /// </summary>
        /// <param name="msg">本次显示的消息</param>
        public static void ShowInformation(string msg)
        {
            XtraMessageBox.Show(msg, "信息",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1);
        }



    }
}
