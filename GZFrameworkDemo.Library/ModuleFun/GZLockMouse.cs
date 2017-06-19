using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.ModuleFun
{
    public class GZLockMouse
    {
        public struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
        /// <summary>
        /// 锁定鼠标
        /// </summary>
        /// <param name="Start"></param>
        /// <param name="End"></param>
        public static void Lock(Point Start, Point End)
        {
            Rect GZRect = new Rect()
            {
                Left = Start.X,
                Top = Start.Y,
                Right = End.X,
                Bottom = End.Y
            };
            ClipCursor(ref GZRect);
        }

        /// <summary>
        /// 锁定鼠标在指定句柄区域
        /// </summary>
        /// <param name="Handle"></param>
        public static void Lock(int Handle)
        {
            Rect formRect = new Rect();
            GetWindowRect(Handle, ref formRect);
            ClipCursor(ref formRect);
        }

        /// <summary>
        /// 锁定鼠标在指定RECT结构
        /// </summary>
        /// <param name="rt"></param>
        internal static void Lock(Rect rt)
        {
            ClipCursor(ref rt);
        }

        /// <summary>
        /// 释放鼠标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Unlock()
        {
            Rect GZRect = new Rect()
            {
                Left = 0,
                Top = 0,
                Bottom = Screen.PrimaryScreen.Bounds.Bottom,
                Right = Screen.PrimaryScreen.Bounds.Right
            };
            ReleaseCapture();
        }


        /// <summary>
        /// 获得指定句柄RECT结构
        /// </summary>
        /// <param name="h"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        [DllImport("User32")]
        public extern static int GetWindowRect(int h, ref Rect r);
        /// <summary>
        /// 指定区域锁定鼠标
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        [DllImport("User32")]
        public extern static int ClipCursor(ref Rect r);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


    }
}
