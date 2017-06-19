using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.Controls
{
    [Description("为GridView初始化设置")]
    [ProvideProperty("ShowLineNumber", typeof(GridView))]
    [ProvideProperty("LineNumberFormatString", typeof(GridView))]
    [ProvideProperty("AllowCellEmpty", typeof(GridView))]
    [ProvideProperty("CaptionToUnboundColumn", typeof(GridView))]
    [ProvideProperty("EnableDataEmptyWarning", typeof(GridView))]
    public partial class GridViewSettingl : Component, IExtenderProvider
    {
        private Dictionary<GridView, GridViewShowLine> StyleList = null;
        public GridViewSettingl()
        {
            InitializeComponent();
            StyleList = new Dictionary<GridView, GridViewShowLine>();
        }

        public GridViewSettingl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            StyleList = new Dictionary<GridView, GridViewShowLine>();
        }

        #region EnableDataEmptyWarning
        [Category("扩展")]
        [Description("是否显示空数据提示"), DefaultValue(false)]
        public bool GetEnableDataEmptyWarning(GridView gv)
        {
            if (StyleList.ContainsKey(gv))
            {
                return StyleList[gv].EnableDataEmptyWarning;
            }
            return false;
        }
        public void SetEnableDataEmptyWarning(GridView gv, bool EnableDataEmptyWarning)
        {
            if (!StyleList.ContainsKey(gv))
            {
                StyleList.Add(gv, new GridViewShowLine()
                {
                    EnableDataEmptyWarning = EnableDataEmptyWarning
                });
            }
            else
            {
                StyleList[gv].EnableDataEmptyWarning = EnableDataEmptyWarning;
            }
            gv.CustomDrawEmptyForeground -= new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(gv_CustomDrawEmptyForeground);
            if (EnableDataEmptyWarning == true)
                gv.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(gv_CustomDrawEmptyForeground);
        }

        private void gv_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            DataView bindingSource = gv.DataSource as DataView;
            if (bindingSource != null && bindingSource.Count == 0)
            {
                string str = "数据为空!";
                Font f = new Font("宋体", 10, FontStyle.Bold);

                Rectangle r = new Rectangle(gv.GridControl.Width / 2 - 100, gv.GridControl.Height / 2, e.Bounds.Right - 5, e.Bounds.Height - 5);
                e.Graphics.DrawString(str, f, Brushes.Red, r);
            }
        }
        #endregion


        #region 行号格式化字符串
        [Category("扩展")]
        [Description("行号格式化字符串"), DefaultValue("{0}")]
        public string GetLineNumberFormatString(GridView gv)
        {
            if (StyleList.ContainsKey(gv))
            {
                return StyleList[gv].LineNumberFormatString;
            }
            return "{0}";
        }
        public void SetLineNumberFormatString(GridView gv, string lineNoFormatString)
        {
            if (!StyleList.ContainsKey(gv))
            {
                StyleList.Add(gv, new GridViewShowLine()
                {
                    LineNumberFormatString = lineNoFormatString
                });
            }
            else
            {
                StyleList[gv].LineNumberFormatString = lineNoFormatString;
            }
        }
        #endregion



        #region 是否显示行号
        [Category("扩展")]
        [Description("是否显示行号"), DefaultValue(false)]
        public bool GetShowLineNumber(GridView dgv)
        {
            if (StyleList.ContainsKey(dgv))
            {
                return StyleList[dgv].EnableLineNumber;
            }
            return false;
        }
        public void SetShowLineNumber(GridView dgv, bool enableLineNo)
        {
            if (!StyleList.ContainsKey(dgv))
            {
                StyleList.Add(dgv, new GridViewShowLine()
                {
                    EnableLineNumber = enableLineNo
                });
            }
            else
            {
                StyleList[dgv].EnableLineNumber = enableLineNo;
            }
            dgv.CustomDrawRowIndicator -= gridView1_CustomDrawRowIndicator;
            if (enableLineNo)
            {
                //dgv.IndicatorWidth = 35;
                dgv.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;
            }
            else
            {
                dgv.IndicatorWidth = -1;
            }
        }
        #endregion

        #region 转换空单元格为DBNull.Value
        [Category("扩展")]
        [Description("转换空单元格为DBNull.Value"), DefaultValue(false)]
        public bool GetAllowCellEmpty(GridView dgv)
        {
            if (StyleList.ContainsKey(dgv))
            {
                return StyleList[dgv].AllowCellEmpty;

            }
            return false;
        }

        public void SetAllowCellEmpty(GridView dgv, bool allowcellempty)
        {
            if (!StyleList.ContainsKey(dgv))
            {
                StyleList.Add(dgv, new GridViewShowLine()
                {
                    AllowCellEmpty = allowcellempty
                });
            }
            else
            {
                StyleList[dgv].AllowCellEmpty = allowcellempty;
            }
            dgv.ValidatingEditor -= dgv_ValidatingEditor;
            if (allowcellempty)
                dgv.ValidatingEditor += dgv_ValidatingEditor;
        }
        #endregion

        #region 转换空单元格为DBNull.Value
        [Category("扩展")]
        [Description("Caption绑定到类型为String的UnboundColumn列"), DefaultValue(false)]
        public bool GetCaptionToUnboundColumn(GridView dgv)
        {
            if (StyleList.ContainsKey(dgv))
            {
                return StyleList[dgv].CaptionToUnboundColumn;

            }
            return false;
        }

        public void SetCaptionToUnboundColumn(GridView dgv, bool captiontounboundcolumn)
        {
            if (!StyleList.ContainsKey(dgv))
            {
                StyleList.Add(dgv, new GridViewShowLine()
                {
                    CaptionToUnboundColumn = captiontounboundcolumn
                });
            }
            else
            {
                StyleList[dgv].CaptionToUnboundColumn = captiontounboundcolumn;
            }
            if (CheckDesingModel.IsDesingMode) return;
            if (captiontounboundcolumn)
            {
                foreach (GridColumn gc in dgv.Columns)
                {
                    if (gc.UnboundType == UnboundColumnType.String)
                    {
                        gc.UnboundExpression = String.Format("'{0}'", gc.Caption);
                    }
                }
            }
        }
        #endregion

        void dgv_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (e.Value == null || e.Value.Equals(string.Empty))
            {
                e.Value = DBNull.Value;
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                var gv = sender as GridView;
                if (StyleList.ContainsKey(gv))
                {
                    string info = string.Format(StyleList[gv].LineNumberFormatString, e.RowHandle + 1) + e.Info.DisplayText;

                    if (e.RowHandle == gv.RowCount - 1)
                    {

                        if (StyleList[gv].IsRefresh(gv.RowCount))
                        {
                            StyleList[gv].PreRowCount = gv.RowCount;
                            Graphics vGraphics = e.Graphics;
                            SizeF vSizeF = vGraphics.MeasureString(info + "00", e.Appearance.Font);
                            int dStrLength = Convert.ToInt32(Math.Ceiling(vSizeF.Width)) + 2;
                            if (gv.IndicatorWidth != dStrLength)
                            {
                                gv.IndicatorWidth = dStrLength;
                                gv.RefreshData();
                            }
                        }
                    }

                    e.Info.DisplayText = info;


                }
                else
                    e.Info.DisplayText = (e.RowHandle + 1).ToString() + e.Info.DisplayText;
            }
        }




        #region IExtenderProvider 成员
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool CanExtend(object extendee)
        {
            return (extendee is GridView);
        }
        #endregion
    }

    internal class GridViewShowLine
    {
        private bool enableLineNo = false;
        /// <summary>
        /// 是否显示行号
        /// </summary> 
        [DefaultValue(false)]
        public bool EnableLineNumber
        {
            get
            {
                return enableLineNo;
            }
            set
            {
                enableLineNo = value;
            }
        }

        private string lineNoFormatString = "{0}";
        /// <summary>
        /// 行号显示格式化
        /// </summary>
        [DefaultValue("{0}")]
        public string LineNumberFormatString
        {
            get
            {
                return lineNoFormatString;
            }
            set
            {
                lineNoFormatString = value;
            }
        }

        private bool allowcellempty = false;
        /// <summary>
        /// 是否显示行号
        /// </summary> 
        [DefaultValue(false)]
        public bool AllowCellEmpty
        {
            get
            {
                return allowcellempty;
            }
            set
            {
                allowcellempty = value;
            }
        }

        private bool captiontounboundcolumn = false;
        /// <summary>
        /// 职位String的Unbound列显示显示Caption值
        /// </summary> 
        [DefaultValue(false)]
        public bool CaptionToUnboundColumn
        {
            get
            {
                return captiontounboundcolumn;
            }
            set
            {
                captiontounboundcolumn = value;
            }
        }
        private bool _EnableDataEmptyWarning = false;
        /// <summary>
        /// 显示空值提醒
        /// </summary>
        [DefaultValue(false)]
        public bool EnableDataEmptyWarning
        {
            get
            {
                return _EnableDataEmptyWarning;
            }
            set
            {
                _EnableDataEmptyWarning = value;
            }
        }

        internal int PreRowCount
        {
            get;
            set;
        }

        internal bool IsRefresh(int RowCount)
        {
            return LogLength(PreRowCount) != LogLength(RowCount);
        }


        private int LogLength(int i)
        {
            return (int)Math.Log10(i) + 1;
        }


    }
}
