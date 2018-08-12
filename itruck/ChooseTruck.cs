
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
    [Activity(Label = "ChooseTruck")]
    public class ChooseTruck : Activity
    {
        private List<string> trucks;
        private ListView mListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TruckList);
            mListView = FindViewById<ListView>(Resource.Id.mListView);
            trucks = new List<string>();
            trucks.Add("Robin Pierce");
            trucks.Add("Johnny Dale");
            trucks.Add("Allen Schmitt");
            trucks.Add("Nathan Dodson");
            trucks.Add("Steven Ball");
            trucks.Add("George Santos");
            MyListViewAdapter adapter = new MyListViewAdapter(this, trucks);
            mListView.Adapter = adapter;
            mListView.ItemClick += MListView_ItemClick;
        }

        void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            StartActivity(typeof(Payment));
        }

    }
}
