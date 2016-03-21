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
using Android.Support.V7.Widget;
using weatherApp.Entities;
using weatherApp.ViewHolder;
using Android.Util;
using weatherApp.Utils;

namespace weatherApp.Adapters
{
    public class WeatherAdapter : RecyclerView.Adapter
    {

        private List<DailyData> datalist;
        private Context cont;
        private DateTimeConverter datetime;

        public WeatherAdapter(Context contin, List<DailyData> listin)
        {
           datalist = listin; 
           cont = contin;
        }

        public override int ItemCount
        {
            get { return datalist.Count; }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int pos)
        {
            weatherViewHolder vh = (weatherViewHolder)holder;
            
            vh.summary.Text  = datalist[pos].summary.ToString();
            vh.day.Text = DateTimeConverter.getDay(datalist[pos].time);
            string name  = getResource(datalist[pos].icon);
            int id = cont.Resources.GetIdentifier(name, "drawable", "weatherApp.weatherApp");
            Log.Info("icon : ", datalist[pos].icon);
            Log.Info("resid ", id.ToString());
            vh.icon.SetBackgroundResource(id);
        }



        //needed to change res names as no "-" char allowed in res files
        //quick conversion required.


        private string getResource(string resname)
        {
           switch(resname)
            {
                case "partly-cloudy-day":
                    return "partlycloudyday";
                case "clear-day":
                    return "clearday";
                case "clear-night" :
                    return "clearnight";
                case "partly-cloudy-night":
                    return "partlycloudynight";
                default:
                    return resname;
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var layout = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.weatheritem,parent, false);

            layout.Click += (sender, e) =>
            {
                Intent intent = new Intent(cont, typeof(DetailsScreen));
                cont.StartActivity(intent);
            };

            return new weatherViewHolder(layout);
            
        }
    }
}