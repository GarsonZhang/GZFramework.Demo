using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GZFrameworkDemo.Library.ModuleFun;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.ModuleFun
{
    public class GZFunctionLayout : GZTableLayout
    {

        public PictureBox pic_img { get; private set; }
        public PictureBox pan_Add { get; private set; }


        Image backGround;
        public GZFunctionLayout(Control Container, int width, int height)
            : base(Container, width, height)
        {

            pic_img = GeneratePic(width / 2, height / 2);
            pan_Add = GeneratePic(width, height);
            

            var sbackGround = new Bitmap(pan_Container.Width, pan_Container.Height);
            using (Graphics gContainer = Graphics.FromImage(sbackGround)) //创建画板,这里的画板是由For
            {
                using (Pen pContainer = new Pen(Color.FromArgb(0xCC, 0xCC, 0xFF), 2))//定义了一个蓝色,宽度为的画笔
                {

                    #region 画图
                    for (int i = 0; i < GT.RowCount; i++)
                    {
                        for (int j = 0; j < GT.CellCount; j++)
                        {

                            Point pt = GT[i][j].Location;

                            //画左上角
                            gContainer.DrawLine(pContainer, pt.X, pt.Y, pt.X + 10, pt.Y);
                            gContainer.DrawLine(pContainer, pt.X, pt.Y, pt.X, pt.Y + 10);



                            //画右上角
                            pt.X += ControlWidth;
                            gContainer.DrawLine(pContainer, pt.X, pt.Y, pt.X - 10, pt.Y);
                            gContainer.DrawLine(pContainer, pt.X, pt.Y, pt.X, pt.Y + 10);

                            //画右下角
                            pt.Y += ControlHeight;
                            gContainer.DrawLine(pContainer, pt.X, pt.Y, pt.X - 10, pt.Y);
                            gContainer.DrawLine(pContainer, pt.X, pt.Y, pt.X, pt.Y - 10);

                            //画左下角
                            pt.X -= ControlWidth;
                            gContainer.DrawLine(pContainer, pt.X, pt.Y, pt.X + 10, pt.Y);
                            gContainer.DrawLine(pContainer, pt.X, pt.Y, pt.X, pt.Y - 10);
                        }
                    }
                    #endregion
                }
            }

            backGround = sbackGround;

            Bitmap bitmap = new Bitmap(ControlWidth, ControlHeight);
            using (Graphics g = Graphics.FromImage(bitmap)) //创建画板,这里的画板是由Form提供的.
            {
                using (Pen p = new Pen(Color.Blue, 2))//定义了一个蓝色,宽度为的画笔
                {
                    g.DrawLine(p, 0, 0, 10, 0);//在画板上画直线,起始坐标为(10,10),终点坐标为(100,100)
                    g.DrawLine(p, 0, 0, 0, 10);

                    g.DrawLine(p, 0, ControlHeight, 0, ControlHeight - 10);//在画板上画直线,起始坐标为(10,10),终点坐标为(100,100)
                    g.DrawLine(p, 0, ControlHeight, 10, ControlHeight);

                    g.DrawLine(p, ControlWidth, 0, ControlWidth - 10, 0);//在画板上画直线,起始坐标为(10,10),终点坐标为(100,100)
                    g.DrawLine(p, ControlWidth, 0, ControlWidth, 10);//在画板上画直线,起始坐标为(10,10),终点坐标为(100,100)

                    g.DrawLine(p, ControlWidth, ControlHeight, ControlWidth - 10, ControlHeight);//在画板上画直线,起始坐标为(10,10),终点坐标为(100,100)
                    g.DrawLine(p, ControlWidth, ControlHeight, ControlWidth, ControlHeight - 10);//在画板上画直线,起始坐标为(10,10),终点坐标为(100,100)

                    Point CenterPoint = new Point(ControlWidth / 2, ControlHeight / 2);

                    g.DrawLine(p, CenterPoint.X - 10, CenterPoint.Y, CenterPoint.X + 10, CenterPoint.Y);
                    g.DrawLine(p, CenterPoint.X, CenterPoint.Y - 10, CenterPoint.X, CenterPoint.Y + 10);

                }

            }


            pan_Add.Image = bitmap;


        }

        public override void ClearControl()
        {
            base.ClearControl();
            pan_Container.Controls.Add(pic_img);
            pan_Container.Controls.Add(pan_Add);
        }


        public override void SetControl(int Row, int Column, Control col)
        {
            base.SetControl(Row, Column, col);
            col.MouseDown += col_MouseDown;
            col.MouseMove += col_MouseMove;
            col.MouseUp += col_MouseUp;
        }


        PictureBox GeneratePic(int width, int height)
        {
            PictureBox pic = new PictureBox()
            {
                BackColor = Color.FromArgb(0xEB, 0xEC, 0xEF),
                Size = new System.Drawing.Size(width, height),
                TabStop = false,
                Visible = false,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            pic.BackColor = Color.Transparent;
            pan_Container.Controls.Add(pic);
            return pic;
        }

        public bool IsManage { get; set; }

        GZTableCell CellFrom;
        GZTableCell _CellTo;
        GZTableCell CellTo
        {
            get { return _CellTo; }
            set
            {
                if (_CellTo == value) return;//如果表格相同，不用处理
                if (_CellTo != null)//恢复单元格控件
                    _CellTo.ContainControl = _CellTo.Tag == null ? null : _CellTo.Tag as Control;

                pan_Add.Visible = false;
                if (value == CellFrom)
                    _CellTo = null;
                else
                {
                    if (value != null)
                    {
                        value.ContainControl = pan_Add;
                        pan_Add.Visible = true;
                    }
                    _CellTo = value;
                }
                //if (value != null && value != CellFrom)//判断和原始表格是否相同
                //{
                //    if (value.ContainControl != null) value.Tag = value.ContainControl;//备份控件
                //    value.ContainControl = pan_Add;
                //    pan_Add.Visible = true;
                //    _CellTo = value;
                //}
                //else
                //{
                //    if (value == null) pan_Add.Visible = false;
                //    _CellTo = null;
                //}


            }
        }

        Point _P = Point.Empty;
        Point Location = Point.Empty;
        bool _isMove = false;
        bool IsMove
        {
            get
            {
                return _isMove;
            }
            set
            {
                _isMove = value;
                //if (pan_Container is PanelControl)
                //    (pan_Container as PanelControl).ContentImage = _isMove == true ? backGround : null;
                pan_Container.BackgroundImage = _isMove == true ? backGround : null;
            }
        }
        void col_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsManage && e.Button == MouseButtons.Left)
            {
                Location = (sender as Control).Location;
                Point P = new Point(e.X + Location.X, e.Y + Location.Y);
                CellFrom = GT.GetCellByPoint(P);
                var CurrentCol = CellFrom.ContainControl;

                pic_img.Image = (CurrentCol as SimpleButton).Image;

                _P = new Point(e.X, e.Y);


                pic_img.Location = new Point(P.X - (pic_img.Width / 2), P.Y - (pic_img.Height / 2));




            }
        }

        void col_MouseMove(object sender, MouseEventArgs e)
        {
            //if (IsMove == false) return;
            if (IsManage && e.Button == MouseButtons.Left)
            {
                if (Math.Abs(e.X - _P.X) > 10 || Math.Abs(e.Y - _P.Y) > 10)
                {
                    if (IsMove == false)
                    {
                        if (pic_img.Visible == false) pic_img.Visible = true;

                        //GZFrameworkDemo.Library.ModuleFun.GZLockMouse.Lock((int)pan_Container.Handle);
                        IsMove = true;
                    }

                    Point p = new Point(e.X + Location.X, e.Y + Location.Y);
                    CellTo = GT.GetCellByPoint(p);
                    pic_img.Location = new Point(p.X - pic_img.Width / 2, p.Y - pic_img.Height / 2);
                }
                //pic_img.Location = new Point(pic_img.Left + e.X - _P.X, pic_img.Top + e.Y - _P.Y);
                //pic_img.Left += e.X - _P.X;
                //pic_img.Top += e.Y - _P.Y;
                //_P.X = e.X; _P.Y = e.Y;// = new Point(e.X, e.Y);
            }
        }

        void col_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMove == false) return;
            if (IsManage && e.Button == MouseButtons.Left)
            {
                if (CellTo != null)
                {
                    var v = CellFrom.ContainControl;
                    CellFrom.Tag = CellFrom.ContainControl = CellTo.Tag == null ? null : CellTo.Tag as Control;
                    CellTo.Tag = CellTo.ContainControl = v;
                    if (ControlCellChanged != null)
                    {
                        if (CellFrom.ContainControl != null)
                            ControlCellChanged(CellFrom);
                        if (CellTo.ContainControl != null)
                            ControlCellChanged(CellTo);
                    }
                }
                pic_img.Visible = false;
                pan_Add.Visible = false;
                _CellTo = null;
                //GZFrameworkDemo.Library.ModuleFun.GZLockMouse.Unlock();
                IsMove = false;
            }
        }


        public delegate void CellControlChanged(GZTableCell cell);

        public event CellControlChanged ControlCellChanged;

    }
}
