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

namespace weatherApp.Utils
{
    class DateTimeConverter
    {

        public static DateTime getDate(int unixtime)
        {

            DateTime dtime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            Log.Info("date", dtime.ToString());

            return dtime;
            
        }


        public static string  getDay(int unixtime)
        {
            DateTime dtime = getDate(unixtime);
            int day = dtime.DayOfWeek;


            return getDayString(day);

        }

        private string getDayString(int dayno)
        {

            switch(dayno)
            {
                case 1:
                    return "Sunday";
                case 2:
                    return "Monday";
                case 3:
                    return "Tuesday";
                case 4:
                    return "Wednesday";
                case 5:
                    return "Thursday";
                case 6:
                    return "Friday";
                case 7:
                    return "Saturday";
            }
            
        }



    }
}