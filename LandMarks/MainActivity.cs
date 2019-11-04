using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace LandMarks
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Pocetna);
            var menuImage = FindViewById<ImageView>(Resource.Id.menuimage);
            var qrscannerImage = FindViewById<ImageView>(Resource.Id.qrscannerimage);
            var Welcome = FindViewById<TextView>(Resource.Id.Wlcmtolandmark);
            var ButtQR = FindViewById<Button>(Resource.Id.scanqrbutton);
            var ButtAtr = FindViewById<Button>(Resource.Id.attractionsbutton);

            Welcome.Text = "Welcome to\n LandMark";

            menuImage.SetImageResource(Resource.Drawable.MenuSlicica);
            qrscannerImage.SetImageResource(Resource.Drawable.Qrslicica);

            menuImage.Click += delegate
            {
                StartActivity(typeof(menu));
            };
            qrscannerImage.Click += delegate
            {
                StartActivity(typeof(qrCamera));
            };
            ButtQR.Click += delegate
            {
                StartActivity(typeof(qrCamera));
            };
            ButtAtr.Click += delegate
            {
                StartActivity(typeof(Atrakcija));
            };


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}