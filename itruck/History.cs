
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
    [Activity(Label = "History")]
    public class History : Activity
    {
        private ListView mListView;
        private List<string> history;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.HistoryList);
            mListView = FindViewById<ListView>(Resource.Id.mListView);
            history = new List<string>();
            history.Add("08/07/2017    CBD to Burwood");
            history.Add("21/03/2018    South Yarra to Dandenong");
            MyListViewAdapter adapter = new MyListViewAdapter(this, history);
            mListView.Adapter = adapter;
        }



    }
}
