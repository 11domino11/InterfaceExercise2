using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAcessType(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                default:
                    return null;
            }
        }
    }
}
