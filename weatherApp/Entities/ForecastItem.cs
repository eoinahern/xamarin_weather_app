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
    public class ForecastItem
    {

        public ForecastItem()
        {
        }



        public double latitude { get; set; }
        public double longitude { get; set; }
        public string timezone { get; set;}
        public Currently currently { get; set;}
        public Daily daily { get; set; }
       
    }
}