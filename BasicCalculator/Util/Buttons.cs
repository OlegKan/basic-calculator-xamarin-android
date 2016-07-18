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

namespace BasicCalculator.Util
{
    class Buttons
    {
        public const string delete = "DEL";
        public const string equal = "=";
        public const string point = ".";
        public const string minus = "-";
        public const string plus = "+";
        public const string obelus = "/";
        public const string times = "*";

        public static Button Get(string s)
        {
            Button button;
            if (s.Equals(delete))
            {
                button = new Delete();
            }
            else if (s.Equals(minus))
            {
                button = new Minus();
            }
            else if (s.Equals(plus))
            {
                button = new Plus();
            }
            else if (s.Equals(obelus))
            {
                button = new Obelus();
            }
            else if (s.Equals(times))
            {
                button = new Times();
            }
            else if (s.Equals(equal))
            {
                button = new Equal();
            }
            else if (s.Equals(point))
            {
                button = new Point();
            }
            else
            {
                int digit = Int32.Parse(s);
                button = new Digit(digit);
            }
            return button;
        }
    }

    public interface Button
    {
        void Click(Display display);
    }

    class Delete : Button
    {
        public void Click(Display display)
        {
            string input = display.input;
            if (input.Length !=0 )
            {
                input = input.Substring(0, input.Length - 1);
                display.input = input;
            }
        }
    }

    class Digit : Button
    {
        private int digit;
        public Digit(int digit)
        {
            this.digit = digit;
        }

        public void Click(Display display)
        {
            string input = display.input;
            input = input + digit.ToString();
            display.input = input;
        }
    }

    class Equal : Button
    {
        public void Click(Display display)
        {
            string input = display.input + " " + Buttons.equal + " ???";
            string history = display.history + System.Environment.NewLine + input;
            display.history = history;
            display.input = null;
        }
    }

    class Minus : Button
    {
        public void Click(Display display)
        {
            string input = display.input;
            input = input + " " + Buttons.minus + " ";
            display.input = input;
        }
    }

    class Obelus : Button
    {
        public void Click(Display display)
        {
            string input = display.input;
            input = input + " " + Buttons.obelus + " ";
            display.input = input;
        }
    }

    class Plus : Button
    {
        public void Click(Display display)
        {
            string input = display.input;
            input = input + " " + Buttons.plus + " ";
            display.input = input;
        }
    }

    class Point : Button
    {
        public void Click(Display display)
        {
            string input = display.input;
            input = input + Buttons.point;
            display.input = input;
        }
    }

    class Times : Button
    {
        public void Click(Display display)
        {
            string input = display.input;
            input = input + " " + Buttons.times + " ";
            display.input = input;
        }
    }
}