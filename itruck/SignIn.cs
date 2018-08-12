
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
    [Activity(Label = "SignIn")]
    public class SignIn : Activity
    {
        Button btnSignIn;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SignInView);
            btnSignIn = FindViewById<Button>(Resource.Id.btnSignIn);
            // Create your application here
            btnSignIn.Click += BtnSignIn_Click;

        }

        private void BtnSignIn_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(ChooseTruck));

        }

    }
}
