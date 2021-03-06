﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V7.App;
using FragmentTransaction = Android.Support.V4.App.FragmentTransaction;

namespace BasicCalculator
{
    [Activity(Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.AppCompat.Light.DarkActionBar")]
    public class MainActivity : AppCompatActivity, ButtonsFragment.OnButtonClickListener
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            if (bundle == null)
            {
                this.SupportFragmentManager.BeginTransaction()
                    .Add(Resource.Id.Diplay, DisplayFragment.NewInstance())
                    .Add(Resource.Id.Buttons, ButtonsFragment.NewInstance())
                    .Commit();
            }
        }

        public void OnButtonClick(string s)
        {
            Util.Button button = Util.Buttons.Get(s);
            DisplayFragment displayFragment = (DisplayFragment) this.SupportFragmentManager.FindFragmentById(Resource.Id.Diplay);
            Util.Display display = displayFragment.GetDisplay();
            button.Click(display);
            displayFragment.Render(display.history, display.input);
        }
    }
}

