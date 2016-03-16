using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.RecyclerView;
using Android.Support.V7.Widget;
using weatherApp.Resources.presenter;
using System.Collections.Generic;
using weatherApp.Entities;
using weatherApp.Adapters;
using Android.Support.V7.App;



namespace weatherApp.views
{
    [Activity(Label = "weatherApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, MainInt
    {
        private RecyclerView recview;
        private GetWeatherPresenter weatherpresenter;
        private ProgressBar progbar;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            progbar = FindViewById<ProgressBar>(Resource.Id.progbar);
            recview = FindViewById<RecyclerView>(Resource.Id.recviewits);
            
            weatherpresenter = new GetWeatherImpl(this);
            weatherpresenter.GetWeather();
            showProgressbar();
        }


        private void CreateRecView(List<DailyData> data)
        {
            //recview = FindViewById<RecyclerView>(Resource.Id.recviewits);
            recview.SetLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.Vertical, false));
            WeatherAdapter adpt = new WeatherAdapter(this, data);
            recview.SetAdapter(adpt);
        }
   
        public void hideProgbar()
        {
            progbar.Visibility = ViewStates.Invisible; 
        }
        

        public void showError()
        {
            Toast.MakeText(this, "data load failed", ToastLength.Long).Show();
        }

        public void showProgressbar()
        {
            progbar.Visibility = ViewStates.Visible; 
        }

        public void updateForecasts(List<DailyData> data_list)
        {
            CreateRecView(data_list);
        }
    }
}

