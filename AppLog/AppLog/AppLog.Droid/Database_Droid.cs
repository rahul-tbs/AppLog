using System.IO;
using AppLog.Droid;
using Xamarin.Forms;
using Environment = System.Environment;

[assembly: Dependency(typeof(Database_Droid))]
namespace AppLog.Droid
{
   public class Database_Droid : IDatabase
    {

        public string GetLocalFilePath(string filename)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                return Path.Combine(path, filename);
            }
            catch (System.Exception ex)
            {
                throw ex;

            }
        }
    }

}