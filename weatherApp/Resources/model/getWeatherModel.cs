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
using weatherApp.Entities;
using System.Threading.Tasks;


namespace weatherApp.Resources.model
{
    interface getWeatherModel
    {
        Task<ForecastItem> getForecast();
    }
}