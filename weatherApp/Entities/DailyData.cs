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
    public class DailyData
    {

        public DailyData()
        {

        }

        // icon types
        //clear-day, clear-night, rain, snow, sleet, wind, fog, cloudy, partly-cloudy-day, or partly-cloudy-night


        public int time { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public int sunriseTime { get; set; }
        public int sunsetTime { get; set; }
        public double temperatureMin { get; set; }
        public double temperatureMax { get; set; }
        public double humidity { get; set; }
        public double dewPoint { get; set; }
    }
}