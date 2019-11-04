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
    [Activity(Label = "menu")]
    public class menu : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.menu);

            var menuImage = FindViewById<ImageView>(Resource.Id.menuimage);
            var qrscannerImage = FindViewById<ImageView>(Resource.Id.qrscannerimage);
            var Attractions = FindViewById<TextView>(Resource.Id.attractions);
            var Homepage = FindViewById<TextView>(Resource.Id.homepage);
            var ScanQr = FindViewById<TextView>(Resource.Id.qrscann);

            menuImage.SetImageResource(Resource.Drawable.MenuSlicica);
            qrscannerImage.SetImageResource(Resource.Drawable.Qrslicica);

            Attractions.Text = "Attractions";
            Homepage.Text = "Homepage";
            ScanQr.Text = "QR Scan";

            menuImage.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
            qrscannerImage.Click += delegate
            {
                StartActivity(typeof(qrCamera));
            };
            Attractions.Click += delegate
            {
                StartActivity(typeof(Atrakcije));
            };
            Homepage.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
            ScanQr.Click += delegate
            {
                StartActivity(typeof(qrCamera));
            };
            
        }
    }
}