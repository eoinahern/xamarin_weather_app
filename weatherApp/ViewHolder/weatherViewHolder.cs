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

namespace weatherApp.ViewHolder
{
    class weatherViewHolder : RecyclerView.ViewHolder
    {
        public TextView summary { get; set; }
        public TextView temp { get; set; }
        public ImageView icon { get; set; }
        public TextView day { get; set; }

        public weatherViewHolder(View itemView) :base(itemView)
        {
            summary = itemView.FindViewById<TextView>(Resource.Id.summarytxt);
            temp = itemView.FindViewById<TextView>(Resource.Id.temptxt);
            icon = itemView.FindViewById<ImageView>(Resource.Id.image);
            day = itemView.FindViewById<TextView>(Resource.Id.daytxt);
        }
    }
}