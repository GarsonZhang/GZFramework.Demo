using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library.MyControl
{
    [ToolboxItem(true)]
    public class DateEditYearMonth : DateEdit
    {
        public DateEditYearMonth()
        {

            this.Properties.DisplayFormat.FormatString = "y";
            this.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Properties.EditFormat.FormatString = "y";
            this.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Properties.Mask.EditMask = "y";
            this.Properties.ShowToday = false;
            this.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
        }

        public string GetYearMonth()
        {
            return this.DateTime.ToString("yyyy-MM");
        }
    }

    /*<15.2
     * 
     [ToolboxItem(true)]
    public class GZDateEdit : DateEdit
    {
        public GZDateEdit()
        {
            Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
        }
        protected override PopupBaseForm CreatePopupForm()
        {
            if (Properties.VistaDisplayMode == DevExpress.Utils.DefaultBoolean.True)
            {
                this.Properties.DisplayFormat.FormatString = "y";
                this.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                this.Properties.EditFormat.FormatString = "y";
                this.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                this.Properties.Mask.EditMask = "y";
                return new GZVistaPopupDateEditForm(this);
            }
            return base.CreatePopupForm();
        }
    }
    public class GZVistaPopupDateEditForm : VistaPopupDateEditForm
    {
        public GZVistaPopupDateEditForm(DateEdit ownerEdit) : base(ownerEdit) { }
        protected override DateEditCalendar CreateCalendar()
        {
            return new GZVistaDateEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue);
        }
    }
    public class GZVistaDateEditCalendar : VistaDateEditCalendar
    {
        public GZVistaDateEditCalendar(RepositoryItemDateEdit item, object editDate) : base(item, editDate) { }

        protected override void Init()
        {
            base.Init();
            this.View = DateEditCalendarViewType.YearInfo;
        }

        protected override void OnItemClick(DevExpress.XtraEditors.Calendar.CalendarHitInfo hitInfo)
        {
            DayNumberCellInfo cell = hitInfo.HitObject as DayNumberCellInfo;
            if (View == DateEditCalendarViewType.YearInfo)
            {
                DateTime dt = new DateTime(DateTime.Year, cell.Date.Month, CorrectDay(DateTime.Year, cell.Date.Month, DateTime.Day), DateTime.Hour, DateTime.Minute, DateTime.Second);
                OnDateTimeCommit(dt, false);
            }
            else
                base.OnItemClick(hitInfo);
        }
    }
     */
}
