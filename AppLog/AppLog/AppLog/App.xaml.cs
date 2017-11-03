﻿using System;
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
            Mylog mylog = new Mylog();
            mylog.Log("hello Testing");
        }

        public static MyDataBase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MyDataBase(DependencyService.Get<IDatabase>().GetLocalFilePath("Applog1.db3"));
                }
                return database;
            }
        }

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
