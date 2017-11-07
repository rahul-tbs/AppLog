using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  SQLite;
using AppLog.Model;


namespace AppLog
{
    public class MyDataBase
    {
       //public readonly SQLiteAsyncConnection db;

        readonly SQLiteAsyncConnection db;
        public MyDataBase(string dbPath)
        {
            try
            {
                db = new SQLiteAsyncConnection(dbPath);
                db.CreateTableAsync<Logdata>().Wait();
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

        public Task<List<Logdata>> GetAlluserAsync()
        {
            try
            {
                return db.Table<Logdata>().ToListAsync();
            }
            catch (Exception e)
            {
                throw e;

            }
           
        }

        public void Clearlog()
        {
            db.DropTableAsync<Logdata>();
            db.CreateTableAsync<Logdata>();
        }


    }
}
