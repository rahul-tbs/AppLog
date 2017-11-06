using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLog;
using Xamarin.Forms;

namespace testpackapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Mylog d=new Mylog();
            d.Log("right");
        }
    }
}
