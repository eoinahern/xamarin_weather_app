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
using System.Threading.Tasks;
using Refit;
using weatherApp.Entities;

namespace weatherApp.Resources.service
{
    interface weatherInt
    {
        [Get("/{api_key}/{lat},{longitude}")]
        Task<ForecastItem> getForecast(String api_key, String lat, String longitude);
    }
    

}