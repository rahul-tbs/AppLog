using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppLog.Model;
using Newtonsoft.Json;

namespace AppLog
{
    public class Mylog
    {


        public void Log(string message = null)
        {

            var item = new Logdata
            {
                LogMessage = message,
                LogTimestamp = DateTime.Now.ToString()
            };
            App.Database.Log(item);
            // Sendlog("http://192.168.1.252:5000/api/Log");
            // Getdata();
        }


        public async Task<List<Logdata>> Getdata()
        {
            List<Logdata> LocalResult = App.Database.GetAlluserAsync().Result;
            return LocalResult;
        }

        public async void Sendlog(string logserverpath)
        {
            try
            {
               // int flag = 0;
                var client = new HttpClient();
                List<Logdata> LocalResult = App.Database.GetAlluserAsync().Result;
                var Saveupdate = new PostLogdata
                {
                    saveLogdata = LocalResult
                };
                var serelizedList = JsonConvert.SerializeObject(Saveupdate);
                var content = new StringContent(serelizedList, Encoding.UTF8, "application/json");
                var results = await client.PostAsync(logserverpath,
                    content);
                if (results.IsSuccessStatusCode)
                {
                    //var tokenJson = await results.Content.ReadAsStringAsync();
                    //dynamic tl = JsonConvert.DeserializeObject(tokenJson);
                    //if (tl.ToString() == "1")
                    //{
                        //flag = 1;
                        App.Database.Clearlog();
                   // }
                }
               // return flag;
            }
            catch (TaskCanceledException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw e;
            }
        }







    }



}
