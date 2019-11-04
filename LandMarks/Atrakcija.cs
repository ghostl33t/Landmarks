using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace LandMarks
{

    public class ActivityEntity
    {

    }

    [Activity(Label = "Atrakcija")]
    public class Atrakcija : Activity
    {

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Atrakcija);
            var Tekst_Zanimljivosti = FindViewById<TextView>(Resource.Id.tekstzanimljivosti);
            string[] Spisak_Zanimljivosti = { "Zanimljivost 1", "Zanimljivost 2" +
                    "" +
                    "", "Zanimljivost 3", "Zanimljivost 4" };
            int broj = 1;
            for(int i = 0; i < Spisak_Zanimljivosti.Length; i++)
            {
                if(broj == i)
                {
                    Tekst_Zanimljivosti.Text = Spisak_Zanimljivosti[broj];
                }
            }
        }
    }
}