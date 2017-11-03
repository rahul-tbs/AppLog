using System.IO;
using AppLog.Droid;
using Xamarin.Forms;


[assembly: Dependency(typeof(Database_Droid))]
namespace AppLog.Droid
{
   public class Database_Droid : IDatabase
    {

        public string GetLocalFilePath(string filename)
        {
            try
            {
                string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                return Path.Combine(path, filename);
            }
            catch (System.Exception ex)
            {
                throw ex;

            }
        }
    }

}