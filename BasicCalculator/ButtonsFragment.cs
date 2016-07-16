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
    public class ButtonsFragment : Fragment, View.IOnClickListener
    {

        public static ButtonsFragment NewInstance()
        {
            return new ButtonsFragment();
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.FragmentButtons, container, false);
            InitViews(view);

            return view;
        }

        void View.IOnClickListener.OnClick(View v)
        {
            string button = ((Button)v).Text;
            Toast.MakeText(Context, button, ToastLength.Short).Show();
        }

        private void InitViews(View rootView)
        {
            Button digit0 = rootView.FindViewById<Button>(Resource.Id.Digit0);
            Button digit1 = rootView.FindViewById<Button>(Resource.Id.Digit1);
            Button digit2 = rootView.FindViewById<Button>(Resource.Id.Digit2);
            Button digit3 = rootView.FindViewById<Button>(Resource.Id.Digit3);
            Button digit4 = rootView.FindViewById<Button>(Resource.Id.Digit4);
            Button digit5 = rootView.FindViewById<Button>(Resource.Id.Digit5);
            Button digit6 = rootView.FindViewById<Button>(Resource.Id.Digit6);
            Button digit7 = rootView.FindViewById<Button>(Resource.Id.Digit7);
            Button digit8 = rootView.FindViewById<Button>(Resource.Id.Digit8);
            Button digit9 = rootView.FindViewById<Button>(Resource.Id.Digit9);
            Button point = rootView.FindViewById<Button>(Resource.Id.Point);
            Button equal = rootView.FindViewById<Button>(Resource.Id.Equal);
            Button delete = rootView.FindViewById<Button>(Resource.Id.Delete);
            Button devide = rootView.FindViewById<Button>(Resource.Id.Devide);
            Button muliply = rootView.FindViewById<Button>(Resource.Id.Muliply);
            Button minus = rootView.FindViewById<Button>(Resource.Id.Minus);
            Button plus = rootView.FindViewById<Button>(Resource.Id.Plus);

            digit0.SetOnClickListener(this);
            digit1.SetOnClickListener(this);
            digit2.SetOnClickListener(this);
            digit3.SetOnClickListener(this);
            digit4.SetOnClickListener(this);
            digit5.SetOnClickListener(this);
            digit6.SetOnClickListener(this);
            digit7.SetOnClickListener(this);
            digit8.SetOnClickListener(this);
            digit9.SetOnClickListener(this);
            point.SetOnClickListener(this);
            equal.SetOnClickListener(this);
            delete.SetOnClickListener(this);
            devide.SetOnClickListener(this);
            muliply.SetOnClickListener(this);
            minus.SetOnClickListener(this);
            plus.SetOnClickListener(this);
        }
    }
}