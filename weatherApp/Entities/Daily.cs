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

namespace weatherApp.Entities
{
    public class Daily
    {



        public Daily()
        {

        }


        public string summary { get; set; }
        public string icon { get; set; }
        public List<DailyData> data { get; set;}
    }
}