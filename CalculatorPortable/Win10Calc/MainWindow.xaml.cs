using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CalculatorPortable;

namespace Win10Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IResultText resultTxt = new Win10Text(main_textfield);
            IResultText secondTxt = new Win10Text(second_textfield);
            IButton button1 = new Win10Button(button_1);
            IButton button2 = new Win10Button(button_2);
            IButton button3 = new Win10Button(button_3);
            IButton button4 = new Win10Button(button_4);
            IButton button5 = new Win10Button(button_5);
            IButton button6 = new Win10Button(button_6);
            IButton button7 = new Win10Button(button_7);
            IButton button8 = new Win10Button(button_8);
            IButton button9 = new Win10Button(button_9);
            IButton button0 = new Win10Button(button_0);
            IButton buttondot = new Win10Button(button_dot);

            IButton clrBtn = new Win10Button(button_clr);
            IButton multiplyBtn = new Win10Button(button_multiply);
            IButton divBtn = new Win10Button(button_division);
            IButton minusBtn = new Win10Button(button_minus);
            IButton plusBtn = new Win10Button(button_plus);
            IButton eqBtn = new Win10Button(button_eq);

            IButton [] buttons = new IButton[11] { button1, button2 , button3 , button4, button5, button6, button7, button8, button9, button0, buttondot };
            IButton [] operators = new IButton[6] { clrBtn , multiplyBtn , divBtn , minusBtn , plusBtn , eqBtn };
            


            var Calculator = new CalculatorPortable.CalculatorPortable(buttons, operators, resultTxt, secondTxt);
        }
    }
}
