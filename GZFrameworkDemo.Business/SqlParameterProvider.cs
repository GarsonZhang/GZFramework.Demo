using GZDBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business
{
    public class SqlParameterProvider : DbParameterBase
    {

        //DbParameter GenerateParmeter(string parameterName, object value);

        //DbParameter GenerateParmeter(string parameterName, SqlDbType dbType);

        //DbParameter GenerateParmeter(string parameterName, SqlDbType dbType, int size);

        //DbParameter GenerateParmeter(string parameterName, SqlDbType dbType, int size, string sourceColumn);
        //protected abstract DbParameter GenerateParmeter(string parameterName, SqlDbType dbType, int size, string sourceColumn, ParameterDirection direction);

        //DbParameter GenerateParmeter(string parameterName, SqlDbType dbType, int size, ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, DataRowVersion sourceVersion, object value);

        //DbParameter SqlParameter(string parameterName, SqlDbType dbType, int size, ParameterDirection direction, byte precision, byte scale, string sourceColumn, DataRowVersion sourceVersion, bool sourceColumnNullMapping, object value, string xmlSchemaCollectionDatabase, string xmlSchemaCollectionOwningSchema, string xmlSchemaCollectionName);
        public void AddParameter(string parameterName, object value)
        {
            SqlParameter parm = new SqlParameter(parameterName, value);
            AddParameter(parm);
        }
        public void AddParameter(string parameterName, SqlDbType dbType, object value)
        {
            SqlParameter parm = new SqlParameter(parameterName, dbType);
            parm.Value = value;
            AddParameter(parm);
        }

        public void AddParameter(string parameterName, SqlDbType dbType, int size, object value)
        {
            SqlParameter parm = new SqlParameter(parameterName, dbType, size);
            parm.Value = value;
            AddParameter(parm);
        }
        public void AddParameter(string parameterName, SqlDbType dbType, int size, object value, ParameterDirection direction)
        {
            SqlParameter parm = new SqlParameter(parameterName, dbType, size);
            parm.Value = value;
            parm.Direction = direction;
            AddParameter(parm);
        }
        public void AddParameter(string parameterName, SqlDbType dbType, int size, object value, string sourceColumn)
        {
            SqlParameter parm = new SqlParameter(parameterName, dbType, size, sourceColumn);
            parm.Value = value;
            AddParameter(parm);
        }
    }
}
