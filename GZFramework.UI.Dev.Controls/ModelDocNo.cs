using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFramework.UI.Dev.Controls.Model
{
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

        private GenerateDocSNRule _DocType = GenerateDocSNRule.直接递增;
        /// <summary>
        /// 单据生成规则
        /// </summary>
        public GenerateDocSNRule DocType { get { return _DocType; } set { _DocType = value; } }


        private int _Length = 5;
        /// <summary>
        /// 单据长度
        /// </summary>
        public int Length { get { return _Length; } set { _Length = value; } }
    }

    public enum GenerateDocSNRule
    {
        年,
        年_月,
        年_月_日,
        直接递增
    }
}
