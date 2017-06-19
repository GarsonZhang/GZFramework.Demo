using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    internal class DB_SQLite : IDB
    {

        public string ProviderName
        {
            get;
            set;
        }
        public string DataSource { get; set; }

        private bool _Pooling = true;
        public DB_SQLite()
        {
            ProviderName = "System.Data.SQLite";
        }

        public bool Pooling
        {
            get { return _Pooling; }
            set { _Pooling = value; }
        }
        public string password { get; set; }


        //连接字符串参考
        //string strCon = "Datasource=Test.db3;Pooling=true;FailIfMissing=false";
        //"NorthwindEF (SQLite)" connectionString="provider=System.Data.SQLite;metadata=Schemas\NorthwindEFModel.csdl|Schemas\NorthwindEFModel.msl|Schemas\NorthwindEFModel.SQLite.ssdl;Provider Connection String='Data Source=DB\northwindEF.db'"
        public string GetConnectionStr()
        {
            return String.Format("Data Source={0};Pooling=true;password={1}", DataSource, password);
        }


        /*
Basic（基本的）
    Data Source=filename;Version=3;
Using UTF16（使用UTF16编码）
    Data Source=filename;Version=3;UseUTF16Encoding=True;
With password（带密码的）
    Data Source=filename;Version=3;Password=myPassword;
Using the pre 3.3x database format（使用3.3x前数据库格式）
    Data Source=filename;Version=3;Legacy Format=True;
Read only connection（只读连接）
    Data Source=filename;Version=3;Read Only=True;
With connection pooling（设置连接池）
    Data Source=filename;Version=3;Pooling=False;Max Pool Size=100;
Using DateTime.Ticks as datetime format（）
    Data Source=filename;Version=3;DateTimeFormat=Ticks;

Store GUID as text（把Guid作为文本存储，默认是Binary）
    Data Source=filename;Version=3;BinaryGUID=False;
如果把Guid作为文本存储需要更多的存储空间

Specify cache size（指定Cache大小）
    Data Source=filename;Version=3;Cache Size=2000;

    Cache Size 单位是字节

Specify page size（指定页大小）
    Data Source=filename;Version=3;Page Size=1024;
    Page Size 单位是字节

Disable enlistment in distributed transactions
    Data Source=filename;Version=3;Enlist=N;
Disable create database behaviour（禁用创建数据库行为）
    Data Source=filename;Version=3;FailIfMissing=True;

默认情况下，如果数据库文件不存在，会自动创建一个新的，使用这个参数，将不会创建，而是抛出异常信息

Limit the size of database（限制数据库大小）
    Data Source=filename;Version=3;Max Page Count=5000;
    The Max Page Count is measured in pages. This parameter limits the maximum number of pages of the database.
Disable the Journal File （禁用日志回滚）
    Data Source=filename;Version=3;Journal Mode=Off;
    This one disables the rollback journal entirely.

Persist the Journal File（持久）
    Data Source=filename;Version=3;Journal Mode=Persist;


基本连接Sqlite数据库：
    Data Source=mydb.db;Version=3;
    --"Version" 的可能值： "2″ 指 SQLite 2.x (default)；"3″ 指 SQLite 3.x


连接同时创建一个新的Sqlite数据库：
    Data Source=mydb.db;Version=3;New=True;

启用压缩连接Sqlite数据库：
    Data Source=mydb.db;Version=3;Compress=True;

指定连接Sqlite数据库的缓存大小：
    Data Source=mydb.db;Version=3;Cache Size=3000;
*/
    }
}
