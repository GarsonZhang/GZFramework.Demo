using FastReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.ReportServer
{
    public interface IReport
    {
        Report PrepareReport();
    }
}
