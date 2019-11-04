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

namespace LandMarks
{
    [Activity(Label = "Atrakcije")]
    public class Atrakcije : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Atrakcije);

            var menuImage = FindViewById<ImageView>(Resource.Id.menuimage);
            var qrscannerImage = FindViewById<ImageView>(Resource.Id.qrscannerimage);
            var searchattractions = FindViewById<SearchView>(Resource.Id.search);
            var Slika1 = FindViewById<ImageView>(Resource.Id.imageView1);
            var Naslov = FindViewById<TextView>(Resource.Id.textView1);
            menuImage.SetImageResource(Resource.Drawable.MenuSlicica);
            qrscannerImage.SetImageResource(Resource.Drawable.Qrslicica);
            Naslov.Text = "sTARI MOST";
            menuImage.Click += delegate
            {
                StartActivity(typeof(menu));
            };
            qrscannerImage.Click += delegate
            {
                StartActivity(typeof(qrCamera));
            };

        }
    }
}