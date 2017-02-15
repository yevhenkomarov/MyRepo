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
using CalculatorPortable;

namespace AndroidCalc
{
    class AndroidTextView : IResultText
    {
        public readonly TextView _textContent;

        public AndroidTextView(TextView textContent)
        {
            _textContent = textContent;
        }

        public string TextContent
        {
            get
            {
                return _textContent.Text;
            }

            set
            {
                _textContent.Text = value;
            }
        }
    }
}