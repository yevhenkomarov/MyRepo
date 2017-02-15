using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorPortable;
using System.Windows.Controls;
using System.Windows;

namespace Win10Calc
{
    public class Win10Button : IButton
    {
        private readonly Button _button;
        public event EventHandler Click = delegate { };
        public Win10Button (Button button)
        {
            _button = button;
            _button.Click += OnButtonClick;
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            Click(this, new EventArgs());
        }

        public string ButtonContent
        {
            get
            {
               return _button.Content.ToString() ;
            }

            set
            {
               _button.Content = value;
            }
        }

        public string BtnId
        {
            get
            {
                return _button.Name.ToString();
            }
        }

    }
}
