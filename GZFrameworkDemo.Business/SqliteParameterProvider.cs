using GZDBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace ClothingPSISQLite.BusinessSQLite
{
    public class SqliteParameterProvider : DbParameterBase
    {

        public void AddParameter(string parameterName, object value)
        {
            SQLiteParameter parm = new SQLiteParameter(parameterName, value);
            AddParameter(parm);
            //System.Data.SQLite.SQLiteParameter p = new System.Data.SQLite.SQLiteParameter();
            //p.DbType
        }
        public void AddParameter(string parameterName, DbType dbType, object value)
        {
            SQLiteParameter parm = new SQLiteParameter(parameterName, dbType);
            parm.Value = value;
            AddParameter(parm);
        }

        public void AddParameter(string parameterName, DbType dbType, int size, object value)
        {
            SQLiteParameter parm = new SQLiteParameter(parameterName, dbType, size);
            parm.Value = value;
            AddParameter(parm);
        }
        //public void AddParameter(string parameterName, DbType dbType, int size, object value, ParameterDirection direction)
        //{
        //    SQLiteParameter parm = new SQLiteParameter(parameterName, dbType, size);
        //    parm.Value = value;
        //    parm.Direction = direction;
        //    AddParameter(parm);
        //}
        public void AddParameter(string parameterName, DbType dbType, int size, object value, string sourceColumn)
        {
            SQLiteParameter parm = new SQLiteParameter(parameterName, dbType, size, sourceColumn);
            parm.Value = value;
            AddParameter(parm);
        }
    }
}
