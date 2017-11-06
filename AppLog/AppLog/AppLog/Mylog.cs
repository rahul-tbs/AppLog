using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppLog
{
   public class Mylog 
    {
        public void Log(string message=null)
        {
            Debug.WriteLine(message);
            var item = new Logdata
            {
                LogMessage = message,
                LogTimestamp = DateTime.Now
            };
            App.Database.Log(item);
            List<Logdata> LocalResult = App.Database.GetAlluserAsync().Result;
           
        }

    }
    public class Logdata
    {
        public string LogMessage { get; set; }

        public DateTime LogTimestamp { get; set; }
    }

}
