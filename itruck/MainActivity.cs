using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace itruck
{
    [Activity(Label = "itruck", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        //private List<string> mItems;
        //private ListView mListView;
        private Button btnSignIn;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            btnSignIn = FindViewById<Button>(Resource.Id.btnSignIn);
            //mListView = FindViewById<ListView>(Resource.Id.mListView);
            btnSignIn.Click += BtnSignIn_Click;
            //mItems = new List<string>();
            //mItems.Add("23/05/2018 Peter");
            //mItems.Add("08/07/2018 Bob");
            //ArrayAdapter<string> adapter = new ArrayAdapter<string>(this,Android.Resource.Layout.SimpleListItem1,mItems);


            //mListView.Adapter = adapter;
            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.myButton);

            //button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }

        private void BtnSignIn_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(SignIn));
        }

    }
}

