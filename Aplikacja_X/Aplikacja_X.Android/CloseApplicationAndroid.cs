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
using Aplikacja_X.Droid;
using Java.Lang;
using Xamarin.Forms;

[assembly: Dependency(typeof(CloseApplicationAndroid))]
namespace Aplikacja_X.Droid
{
    class CloseApplicationAndroid : CloseApplication
    {
        public void closeApplication()
        {
             //var activity = (Activity)Forms.Context;
            //activity.FinishAffinity();
            //Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            JavaSystem.Exit(0);
        }
    }
}