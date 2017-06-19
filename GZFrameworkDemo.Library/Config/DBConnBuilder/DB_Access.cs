using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    internal class DB_Access :IDB
    {
        /*
 采用独占方式进行连接：

    "Driver={Microsoft Access Driver (*.mdb)}; DBQ=C:\App1\你的数据库名.mdb; Exclusive=1; Uid=你的用户名; Pwd=你的密码;"

    MS ACCESS OLEDB & OleDbConnection （.NET下的OleDb接口）进行链接

    普通方式（最常用）连接ACCESS数据库：

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\你的数据库名.mdb; User Id=admin; Password="

    使用工作组方式（系统数据库）连接ACCESS数据库：

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\你的数据库名.mdb; Jet OLEDB:System Database=c:\App1\你的系统数据库名.mdw"

    连接到带有密码的ACCESS数据库：

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\你的数据库名.mdb; Jet OLEDB:Database Password=你的密码"

    连接到处于局域网主机上的ACCESS数据库：

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=\\Server_Name\Share_Name\Share_Path\你的数据库名.mdb"

    连接到处于远程服务器上的ACCESS数据库：

    "Provider=MS Remote; Remote Server=http://远程服务器IP; Remote Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\你的数据库名.mdb"

    MS ACCESS ODBC开放式接口连接字符串

    标准链接：

    "Driver= {MicrosoftAccessDriver(*.mdb)};DBQ=C:\App1\你的数据库名.mdb;Uid=你的用户名;Pwd=你的密码;"

    如果ACCESS数据库未设置用户名和密码，请留空。下同。

    WorkGroup方式（工作组方式）连接：

    "Driver={Microsoft Access Driver (*.mdb)}; Dbq=C:\App1\你的数据库名.mdb; SystemDB=C:\App1\你的数据库名.mdw;"

    采用独占方式进行连接：

    "Driver={Microsoft Access Driver (*.mdb)}; DBQ=C:\App1\你的数据库名.mdb; Exclusive=1; Uid=你的用户名; Pwd=你的密码;"

    MS ACCESS OLEDB & OleDbConnection （.NET下的OleDb接口）进行链接

    普通方式（最常用）连接ACCESS数据库：

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\你的数据库名.mdb; User Id=admin; Password="

    使用工作组方式（系统数据库）连接ACCESS数据库：

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\你的数据库名.mdb; Jet OLEDB:System Database=c:\App1\你的系统数据库名.mdw"

    连接到带有密码的ACCESS数据库：

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\你的数据库名.mdb; Jet OLEDB:Database Password=你的密码"

    连接到处于局域网主机上的ACCESS数据库：

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=\\Server_Name\Share_Name\Share_Path\你的数据库名.mdb"

    连接到处于远程服务器上的ACCESS数据库：

    "Provider=MS Remote; Remote Server=http://远程服务器IP; Remote Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\你的数据库名.mdb"

     

    ___________________________________

    打開Access的方式
    Access的打開方式有兩种,一种是以獨占式方式打開,另一种共享方式,如果以獨占式式打開,那么其它的程式在就只能讀這個文件,而不能update和delete.如果設定了數据庫密碼,C#就連不上了.默認的是以共享方式打開的.
    設定Access的密碼
    Access的密碼有2种,分別由如下方式設定,
    (1)"工具”->"安全"->"设置数据库密码"
    (2)"工具"->"安全"->"用户与组的账户"
    手動打開Access文件時,會首先提示輸入用戶名和密碼,然后再提示輸入數据庫密碼.
    C#連接Access的方式
    (1)無數据庫密碼時(有沒有用戶密碼該方法都可以),這种方式以共享方式打開.
    OleDbConnection dbconn=new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data source=D:\Testdb.mdb;");
    (2)有數据庫密碼時(有沒有用戶密碼該方法都可以),這种方式以獨占式方式打開.
    OleDbConnection   dbconn   =   new   OleDbConnection(@"Provider=Microsoft.Jet.OleDB.4.0;Data Source=D:\Testdb.mdb;Jet OleDb:DataBase Password=12345");  
    (3)在數据庫密碼和用戶密碼都有時,可以用該方法,但用戶密碼處就算設有密碼也必須為空,這种方式也將以獨占式方式打開.
    OleDbConnection   dbconn   =   new   OleDbConnection(@"Provider=Microsoft.Jet.OleDB.4.0;Data Source=D:\Testdb.mdb;Jet OleDb:DataBase Password=12345;Persist Security Info=true;password=;user id=Admin");
 */
        //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + "员工信息.mdb" + ";Persist Security Info=False
        public string ProviderName
        {
            get;
            set;
        }

        public string DataSource { get; set; }

        public string UserID { get; set; }
        public string Password { get; set; }
        
        public DB_Access()
        {
            ProviderName = "System.Data.OleDb";
        }

        public string GetConnectionStr()
        {
            //"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\你的数据库名.mdb; User Id=admin; Password="
            return String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};User Id={1}; Password={2}", DataSource, UserID, Password);
        }
    }
}
