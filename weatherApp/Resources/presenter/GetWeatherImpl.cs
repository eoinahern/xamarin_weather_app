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
using weatherApp.Resources.model;
using weatherApp.views;
using weatherApp.Entities;

namespace weatherApp.Resources.presenter
{
    public class GetWeatherImpl : GetWeatherPresenter
    {
        
        //to be injected when i learn DI in xamarin.

        private MainInt mainview;
        private getWeatherModel weathermodel;



        public GetWeatherImpl(MainInt mainviewin)
        {
            mainview = mainviewin;
            weathermodel = new getWeatherModelImpl(this);
        }
        
        
        public async void GetWeather()
        {
            ForecastItem forcast = await weathermodel.getForecast();
            Daily dailydata = forcast.daily;
            List<DailyData> data = dailydata.data;

            if(data.Count > 0)
            {
                mainview.updateForecasts(data);
            }
            else
            {
                mainview.showError();
            }

            mainview.hideProgbar();
            
       }

      
    }
}