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

using Refit;
using System.Threading.Tasks;
using weatherApp.Entities;

namespace weatherApp.Resources.service
{

    class RestServiceImpl : RestSeviceCalls
    {

        public RestServiceImpl()
        {
        }


        
        public async Task<ForecastItem> getForecast()
        {
             var service = RestService.For<weatherInt>("https://api.forecast.io/forecast");
             ForecastItem forecast = new ForecastItem();
             ForecastItem task =  await service.getForecast("63f0914cdd082e76d25b40161cbe70c4", "53.347", "6.2597");
             return task;
       }
    }
}