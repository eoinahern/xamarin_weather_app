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
using Android.Util;

namespace weatherApp.Utils
{
    class DateTimeConverter
    {

        public static DateTime getDate(int unixtime)
        {

            DateTime dtime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtime = dtime.AddSeconds(unixtime).ToLocalTime();
            Log.Info("date", dtime.ToString());
            return dtime;
        }


        public static string  getDay(int unixtime)
        {
            DateTime dtime = getDate(unixtime);
            String day = dtime.DayOfWeek.ToString();
            return day;
        }

     }
}