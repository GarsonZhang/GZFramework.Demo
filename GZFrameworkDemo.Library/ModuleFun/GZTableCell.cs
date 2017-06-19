using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.ModuleFun
{
    public class GZTableCell
    {
        private int _Width;
        private int _Height;
        //private Point _Location;
        private bool _IsUsed = false;
        private int _ColIndex;
        private int _RowIndex;
        /// <summary>
        /// 单元格宽度
        /// </summary>
        public int Width { get { return _Width; } }
        /// <summary>
        /// 单元格高度
        /// </summary>
        public int Height { get { return _Height; } }

        public Point Location
        {
            get
            {
                int W = (Width * ColIndex) + 20;
                int H = Height * RowIndex;
                return new Point(W, H);
            }
        }

        public bool IsUsed { get { return _IsUsed; } set { _IsUsed = value; } }

        public int ColIndex { get { return _ColIndex; } }

        public int RowIndex { get { return _RowIndex; } }

        public object Tag { get; set; }

        public override string ToString()
        {
            return ContainControl == null ? "NULL" : ContainControl.ToString();
        }

        /// <summary>
        /// 构造函数,指定第几行第几列
        /// </summary>
        /// <param name="Width">单元格宽度</param>
        /// <param name="Height">单元格高度</param>
        public GZTableCell(int Width, int Height, int RowIndex, int ColIndex)
        {
            _Width = Width;
            _Height = Height;
            _RowIndex = RowIndex;
            _ColIndex = ColIndex;
        }

        private Control _ContainControl;
        public Control ContainControl
        {
            get { return _ContainControl; }
            set
            {
                _ContainControl = value;
                UpdateControl();
            }
        }

        public void UpdateControl()
        {
            if (_ContainControl != null)
            {
                _ContainControl.Location = this.Location;
                this.IsUsed = true;
            }
            else
            {
                this.IsUsed = false;
            }
        }
    }
}
