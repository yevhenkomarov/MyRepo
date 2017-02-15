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
    class AndroidButton : IButton
    {
        private readonly Button _button;
        public event EventHandler Click = delegate { };

        public AndroidButton (Button button)
        {
            _button = button;
            _button.Click += OnButtonClick;
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Click(this, new EventArgs());
        }

        public string BtnId
        {
            get
            {
                return _button.Id.ToString();
            }
        }

        public string ButtonContent
        {
            get
            {
                return _button.Text;
            }

            set
            {
                _button.Text = value;
            }
        }
        
    }
}