using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  SQLite;

namespace AppLog
{
    public class MyDataBase
    {
       public readonly SQLiteAsyncConnection db;

        //readonly SQLiteAsyncConnection db;
        public MyDataBase(string dbPath)
        {
            try
            {
                db = new SQLiteAsyncConnection(dbPath);
                db.CreateTableAsync<Logdata>().Wait(5000);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task<int> Log(Logdata item)
        {
            return db.InsertAsync(item);
        }
    }
}
