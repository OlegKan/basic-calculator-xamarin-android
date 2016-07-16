using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace BasicCalculator
{
    public class DisplayFragment : Fragment
    {
        private TextView historyTextView;
        private TextView inputTextView;

        public static DisplayFragment NewInstance()
        {
            return new DisplayFragment();
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.FragmentDisplay, container, false);
            InitViews(view);
            return view;
        }

        public void Render(string history, string input)
        {
            historyTextView.Text = history;
            inputTextView.Text = input;
        }

        public Util.Display GetDisplay()
        {
            Util.Display display = new Util.Display();
            display.history = historyTextView.Text;
            display.input = inputTextView.Text;
            return display;
        }

        private void InitViews(View rootView)
        {
            historyTextView = rootView.FindViewById<TextView>(Resource.Id.History);
            inputTextView = rootView.FindViewById<TextView>(Resource.Id.Input);
        }
    }
}