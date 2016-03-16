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
using weatherApp.Resources.presenter;

using weatherApp.Resources.service;
using weatherApp.Entities;
using System.Threading.Tasks;

namespace weatherApp.Resources.model
{
    class getWeatherModelImpl : getWeatherModel
    {

        private GetWeatherPresenter weatherpresenter;
        private RestSeviceCalls restservice;

        public getWeatherModelImpl(GetWeatherPresenter weatherpresenterin)
        {
            weatherpresenter = weatherpresenterin;
            restservice = new RestServiceImpl();
        }


        public async Task<ForecastItem> getForecast()
        {
            return await restservice.getForecast();
        }
    }
}