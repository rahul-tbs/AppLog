using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppLog.Model;
namespace AppLog
{
   public class Mylog 
    {
        public void Log(string message=null)
        {
           
            var item = new Logdata
            {
                LogMessage = message,
                LogTimestamp = DateTime.Now.ToString()
            };
            App.Database.Log(item);
           // Getdata();
        }


        public async Task<List<Logdata>> Getdata()
        {
            List<Logdata> LocalResult =  App.Database.GetAlluserAsync().Result;
            return LocalResult;
        }


    }

   

}
