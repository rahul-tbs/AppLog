using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppLog
{
    public partial class App : Application
    {
        public static MyDataBase database;
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
            //Mylog mylog = new Mylog();
            //mylog.Log("poonam");
        }

        public static MyDataBase Database => database ?? (database = new MyDataBase(DependencyService.Get<IDatabase>().GetLocalFilePath("Applog1.db3")));

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
