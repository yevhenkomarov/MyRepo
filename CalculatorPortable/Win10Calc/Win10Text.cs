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
    public class Win10Text : IResultText
    {
        private readonly TextBlock _textContent;

        public Win10Text (TextBlock textContent)
        {
            _textContent = textContent;

        }
        public string TextContent
        {
            get
            {
                return _textContent.Text.ToString();
            }

            set
            {
                _textContent.Text = value;
            }
        }
    }
}
