using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AppLog.Model
{
   public class Logdata
    {
        [PrimaryKey, AutoIncrement]
        public Int64 ID { get; set; }
        public string LogMessage { get; set; }
        public string LogTimestamp { get; set; }
    }

    public class PostLogdata
    {
       
        public List<Logdata> saveLogdata { get; set; }
      
    }

}
