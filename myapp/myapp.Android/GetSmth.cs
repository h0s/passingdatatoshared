using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using myapp;
using myapp.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(Getsmth))]

namespace myapp.Droid
{

    public class Getsmth : IGetSmth
    {
        public string smth
        {
            get { return MainActivity.SomeTextInMainActivity; }
        }
    }
}