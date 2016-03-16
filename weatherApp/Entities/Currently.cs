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
    public class Currently
    {
        public Currently()
        {

        }


        public int time{ set; get;}
        public string icon { get; set; }
        public string summary { get; set;}
        public int nearestStormBearing {get; set;}
        public int nearsetStormDistance{get; set;}
        public double dewPoint { get; set; }
        public double humidity { get; set; }
        public double windSpeed { get; set; }
        public double windBearing { get; set; }
        public double visibility {get; set;}
        public double pressure {get; set;}
    }
}