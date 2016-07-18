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
        private const string history_text_key = "history_text_key";
        private const string input_text_key = "input_text_key";
        private ScrollView scrollView;
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
            InitState(savedInstanceState);
            return view;
        }

        public override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutString(history_text_key, historyTextView.Text);
            outState.PutString(input_text_key, inputTextView.Text);
            base.OnSaveInstanceState(outState);
        }

        public void Render(string history, string input)
        {
            historyTextView.Text = history;
            inputTextView.Text = input;
            ScrollViewDown();
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
            scrollView = rootView.FindViewById<ScrollView>(Resource.Id.ScrollView);
            historyTextView = rootView.FindViewById<TextView>(Resource.Id.History);
            inputTextView = rootView.FindViewById<TextView>(Resource.Id.Input);
        }
        private void InitState(Bundle savedInstanceState)
        {
            if (savedInstanceState != null)
            {
                historyTextView.Text = savedInstanceState.GetString(history_text_key);
                inputTextView.Text = savedInstanceState.GetString(input_text_key);
            }
        }
        private void ScrollViewDown()
        {
            scrollView.Post(() => scrollView.FullScroll(FocusSearchDirection.Down));
        }
    }
}