using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Models
{
    public class Loginer
    {
        private static Loginer _Current;

        /// <summary>
        /// 当前登录账号信息
        /// </summary>
        public static Loginer CurrentLoginer
        {
            get
            {
                if (_Current == null)
                {
                    _Current = new Loginer();
                }
                return _Current;
            }
        }

        /// <summary>
        /// 当前登录用户名
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 是否当前账套管理员
        /// </summary>
        public bool IsDBAdmin { get; set; }

        /// <summary>
        /// 是否当前账套锁定账户
        /// </summary>
        public bool IsDBLock { get; set; }

        /// <summary>
        /// 是否系统总管理员
        /// </summary>
        public bool IsSysAdmin { get; set; }
        /// <summary>
        /// 系统锁定
        /// </summary>
        public bool IsSysLock { get; set; }

        /// <summary>
        /// 当前登录数据库
        /// </summary>
        public string LoginDBCode { get; set; }

        public string SystemDBCode { get; set; }

        ///// <summary>
        ///// 设置当前用户信息
        ///// </summary>
        ///// <param name="sAccount"></param>
        ///// <param name="sIsAdmin"></param>
        ///// <param name="sDBName"></param>
        ///// <param name="sSystemDBName"></param>
        //public void SetAccount(string sAccount, string sUserName, bool sIsAdmin, string sLoginDBName)
        //{
        //    Account = sAccount;
        //    UserName = sUserName;
        //    IsDBAdmin = sIsAdmin;
        //    LoginDBCode = sLoginDBName;
        //}

    }
}
