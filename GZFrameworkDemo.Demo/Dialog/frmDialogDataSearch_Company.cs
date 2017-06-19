using GZPSI.Library.SearchTextEdit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZPSI.Demo.Dialog
{
    public partial class frmDialogDataSearch_Company : frmDialogDataSearchBase
    {
        public frmDialogDataSearch_Company()
        {
            InitializeComponent();

        }

        protected override void SetFocus()
        {
            gridView1.Focus();
        }

        protected override bool ValidateForSelect()
        {
            return gridView1.FocusedRowHandle >= 0;
        }

        public override object GetSelect(out object EditValue, out bool Success)
        {
            Success = true;
            DataModel d = new Dialog.frmDialogDataSearch_Company.DataModel();
            DataRow dr = gridView1.GetFocusedDataRow();
            d.DWBH = dr["dwbh"].ToString();
            EditValue = d.DWMC = dr["dwmc"].ToString();

            DataTable detail = DataSource.Tables[1].DefaultView.ToTable();
            if (detail.Rows.Count > 0)
            {
                d.XKZH = detail.Rows[0]["xkzh"].ToString();
                d.XKZYXQ = Convert.ToDateTime(detail.Rows[0]["xkzyxq"]);
            }
            return d;
        }


        DataSet DataSource;
        private void frmDialogDataSearch_Company_Load(object sender, EventArgs e)
        {
            DataSource = getDataSource();
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
            DataSource.Tables[1].DefaultView.RowFilter = "1=2";//初始化许可证号不显示任何数据
            gridControl2.DataSource = DataSource.Tables[1];
            gridControl1.DataSource = DataSource.Tables[0];

        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
            {
                gridControl2.DataSource = null;//清空许可证号数据源
                return;
            }

            //显示当前许可证号
            DataSource.Tables[1].DefaultView.RowFilter = $"dwbh={gridView1.GetFocusedRowCellValue("dwbh")}";
        }

        DataSet getDataSource()
        {
            DataSet ds = new DataSet();
            DataTable dtMain = new DataTable();

            dtMain.Columns.Add("dwbh", typeof(string));
            dtMain.Columns.Add("dwmc", typeof(string));
            dtMain.Columns.Add("lxr", typeof(string));
            dtMain.Columns.Add("ckdz", typeof(string));
            dtMain.Columns.Add("zjm", typeof(string));

            dtMain.Rows.Add("001", "武汉神武科技", "张三", "上海", "WHSWKJ");
            dtMain.Rows.Add("002", "苏州园林医药", "李四", "北京", "SZYLYY");
            dtMain.Rows.Add("003", "北京利丰制药", "王五", "深圳", "BJLFZY");
            dtMain.Rows.Add("004", "河北武警医院", "贺六", "天津", "HBWJYY");
            dtMain.Rows.Add("005", "上海永久自行车", "赵七", "南京", "SHYJZXC");

            ds.Tables.Add(dtMain);

            DataTable dtDetail = new DataTable();
            dtDetail.Columns.Add("dwbh", typeof(string));
            dtDetail.Columns.Add("xkzh", typeof(string));
            dtDetail.Columns.Add("xkzyxq", typeof(DateTime));

            dtDetail.Rows.Add("001", "xkz00152637", DateTime.Now.AddDays(1));
            dtDetail.Rows.Add("002", "xkz00152567", DateTime.Now.AddMonths(1));
            dtDetail.Rows.Add("003", "xkz00152689", DateTime.Now.AddYears(1));

            ds.Tables.Add(dtDetail);
            return ds;
        }

        public class DataModel
        {
            /// <summary>
            /// 单位号
            /// </summary>
            public string DWBH { get; set; }
            /// <summary>
            /// 单位名称
            /// </summary>
            public string DWMC { get; set; }
            /// <summary>
            /// 许可证号
            /// </summary>
            public string XKZH { get; set; }
            /// <summary>
            /// 许可证有效期
            /// </summary>
            public DateTime XKZYXQ { get; set; }
        }
    }
}
