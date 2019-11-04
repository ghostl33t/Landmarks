using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Karumi.Dexter;
using Com.Karumi.Dexter.Listener;
using Com.Karumi.Dexter.Listener.Single;
using EDMTDev.ZXingXamarinAndroid;
using ZXing;
namespace LandMarks
{
    [Activity(Label = "qrCamera")]
    public class qrCamera : Activity,IPermissionListener
    {
        private ZXingScannerView scannerView;
        private TextView ispis;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.qrscamera);
            ispis = FindViewById<TextView>(Resource.Id.Ispis);
            scannerView = FindViewById<ZXingScannerView>(Resource.Id.zxscan);
            Dexter.WithActivity(this)
                .WithPermission(Manifest.Permission.Camera)
                .WithListener(this)
                .Check(); 
        }
        protected override void OnDestroy()
        {
            scannerView.StopCamera();
            base.OnDestroy();
        }
        public void OnPermissionDenied(PermissionDeniedResponse p0)
        {
            Toast.MakeText(this, "You must enable this permission", ToastLength.Long).Show();
        }

        public void OnPermissionGranted(PermissionGrantedResponse p0)
        {
            scannerView.SetResultHandler(new MyResultHandler(this));
            scannerView.StartCamera();
        }

        public void OnPermissionRationaleShouldBeShown(PermissionRequest p0, IPermissionToken p1)
        {

        }

        private class MyResultHandler : IResultHandler
        {
            private qrCamera qrCamera;

            public MyResultHandler(qrCamera qrCamera)
            {
                this.qrCamera = qrCamera;
            }

            public void HandleResult(ZXing.Result rawResult)
            {
                ProcessResult(rawResult.Text);
            }

            private void ProcessResult(string text)
            {
                if(text.StartsWith("http://"))
                {
                   
                }
            }
        }
    }

    

}