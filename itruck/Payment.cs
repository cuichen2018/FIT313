
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

namespace itruck
{
    [Activity(Label = "Payment")]
    public class Payment : Activity
    {
        
        private Button btnHistory;
        private Button btnPay;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DriverView);
            btnHistory = FindViewById<Button>(Resource.Id.btnHistory);
            btnPay = FindViewById<Button>(Resource.Id.btnPay);
            btnHistory.Click += BtnHistory_Click;
            btnPay.Click += delegate
            {
                var uri = Android.Net.Uri.Parse("http://www.deakin.edu.au");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };
            // Create your application here
        }

        void BtnHistory_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(History));
        }

    }
}
