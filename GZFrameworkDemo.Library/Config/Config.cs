
using GZDBHelper;
using GZFrameworkDemo.Library.Config.DBConnBuilder;

namespace GZFrameworkDemo.Library.Config
{
    public class Config
    {
        private static Config _intance;
        public static Config Intentce
        {
            get
            {
                if (_intance == null)
                    _intance = new Config();
                return _intance;
            }
        }

        DBConfig dbconfig;

        public void LoadDBList()
        {
            if (dbconfig != null)
                dbconfig.RefreshDBList();
        }
        public Config Init()
        {
            dbconfig = new DBConfig();
            //GZFramework.DB.Core.Config.DBConfig = new ClothingPSI.Library.Config.DBConnBuilder.DBConfig();
            GZFramework.DB.DataBaseFactoryEx.CreateDataBaseEvent += DataBaseFactoryEx_CreateDataBaseEvent;
            GZFramework.DB.Config.DefaultConflictOption = System.Data.ConflictOption.CompareAllSearchableValues;

            new Library.Config.RibbonButtons.RiibonButtonsConfig();

            return this;
        }
        private Config()
        {

        }

        private IDatabase DataBaseFactoryEx_CreateDataBaseEvent(string DBCode)
        {
            return dbconfig.GetDBConnectionInfo(DBCode);
        }
    }

}
