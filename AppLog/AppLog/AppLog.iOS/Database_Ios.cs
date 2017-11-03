using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AppLog.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(Database_Ios))]
namespace AppLog.iOS
{
   public class Database_Ios : IDatabase
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }
    }
}