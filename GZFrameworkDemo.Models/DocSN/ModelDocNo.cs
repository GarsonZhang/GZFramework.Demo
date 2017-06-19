using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GZFrameworkDemo.Models.Sys
{
    [InheritedExport(typeof(ModelDocNo))]
    public class ModelDocNo
    {
        /// <summary>
        /// 单据标识，系统自动生成切不可重复
        /// </summary>
        public string DocCode { get; set; }

        /// <summary>
        /// 单据名称
        /// </summary>
        public string DocName { get; set; }

        /// <summary>
        /// 单据头
        /// </summary>
        public string DocHeader { get; set; }
        /// <summary>
        /// 单据头间隔符号
        /// </summary>
        public string Separate { get; set; }

        private GZFrameworkDemo.Models.DocSN.GenerateDocSNRule _DocType = GZFrameworkDemo.Models.DocSN.GenerateDocSNRule.Up;
        /// <summary>
        /// 单据生成规则
        /// </summary>
        public GZFrameworkDemo.Models.DocSN.GenerateDocSNRule DocType { get { return _DocType; } set { _DocType = value; } }

        /// <summary>
        /// 自定义生成标记
        /// </summary>
        public string CustomerSeed { get; set; }

        public string DocRule
        {
            get
            {
                string RuleType = "";
                switch (DocType)
                {
                    case GZFrameworkDemo.Models.DocSN.GenerateDocSNRule.Up:
                        RuleType = "Up"; break;
                    case GZFrameworkDemo.Models.DocSN.GenerateDocSNRule.Year:
                        RuleType = "Year"; break;
                    case GZFrameworkDemo.Models.DocSN.GenerateDocSNRule.Year_Month:
                        RuleType = "Year-Month"; break;
                    case GZFrameworkDemo.Models.DocSN.GenerateDocSNRule.Year_Month_Day:
                        RuleType = "Year-Month-dd"; break;
                    case GZFrameworkDemo.Models.DocSN.GenerateDocSNRule.Custom:
                        RuleType = "Customer"; break;

                }
                return RuleType;
            }
        }


        private int _Length = 5;
        /// <summary>
        /// 单据长度
        /// </summary>
        public int Length { get { return _Length; } set { _Length = value; } }
    }


    public class SNDataHelper
    {
        [ImportMany(typeof(ModelDocNo))]
        public List<ModelDocNo> SNModels { get; set; }

        public void GetSNCollonection()
        {
            //AggregateCatalog用来合并多个catalog
            var catalog = new AggregateCatalog();

            ///使用当前程序集构造AssemblyCatalog,并添加
            ///AssemblyCatalog对于
            AssemblyCatalog assemblyCatalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            catalog.Catalogs.Add(assemblyCatalog);
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }

    }
}
