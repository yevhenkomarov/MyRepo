using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CalculatorPortable
{
    public class CalculatorPortable : ContentPage
    {
        private readonly IButton[] _buttons;
        private readonly IButton[] _operators;
        private readonly IResultText _mainText;
        private readonly IResultText _secondText;
        private decimal firstNum;
        private decimal secondNum;
        private decimal result;
        private string oper = "";
        public delegate string Dele();

        public CalculatorPortable(IButton [] buttons,IButton [] operators, IResultText resultTxt, IResultText secondTxt)
     {
            _buttons = buttons;
            _operators = operators;
            AddNumbersListeners();
            AddOperatorsListeners();
            _mainText = resultTxt;
            _secondText = secondTxt;
            tedt();
            
    }
        private void tedt()
        {
            mytest(my1);
            mytest(my2);
            mytest(my3);
        }

        private string my1()
        {
            return "111";
        }

        private string my2()
        {
            return "222";
        }
        
        private string my3()
        {
            return "suka bliat'";
        }

        private void mytest(Dele some)
        {
            Debug.WriteLine(some());
        }        

        private void AddOperatorsListeners()
        {
            foreach (IButton btn in _operators)
            {
                btn.Click += OnOperatorClick;
            }
        }
        private void AddNumbersListeners()
        {
            foreach (IButton btn in _buttons)
            {
                btn.Click += OnBtnClick;
            }
        }

        private void OnOperatorClick(object sender, EventArgs e)
        {
            var op = (IButton)sender;
            Debug.WriteLine("operator clicked");
            operationHandler(op.ButtonContent.ToString());
        }

        private void operationHandler(string a)
        {
            if (oper == "")
            {
                oper = a;
                firstNum = NumberParser(_mainText);
                SetText(_secondText, firstNum, oper);
                //_secondText.TextContent = (firstNum + oper);
                return;
            }

            else if (oper != "" && _mainText.TextContent == "0")
            {
                oper = a;
                SetText(_secondText, firstNum, oper);
                //_secondText.TextContent = (firstNum + oper);
                return;
            }
            else if (oper != "") { 
            secondNum = NumberParser(_mainText);
            CalculateNumbers(oper);
            oper = a;
            SetText(_secondText, secondNum, oper);
                //_secondText.TextContent += secondNum + oper;
            SetText(_mainText, firstNum);
            //_mainText.TextContent = firstNum.ToString();
        }
        }

        private decimal NumberParser(IResultText T)
        {
            return decimal.Parse(T.TextContent);
        }

        private void SetText(IResultText textField, decimal number)
        {

        }

        private void SetText(IResultText textField, decimal number, string oper)
        {
            textField.TextContent = number.ToString() + oper;
        }

        private void CalculateNumbers(string s)
        {

            switch (s)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "/":
                    if (secondNum != 0)
                    {
                        result = firstNum / secondNum;
                    }
                    else
                    {
                        Debug.WriteLine("division by zero");
                        return;
                    }
                    break;
                case "x":
                    result = firstNum * secondNum;
                    break;
                case "=":
                    EqualClick();
                    break;
                case "clr":
                    ClearAll();
                    break;
            }
            firstNum = result;

        }

        private void ClearAll()
        {
            _mainText.TextContent = "0";
            _secondText.TextContent = "";
            firstNum = 0;
            secondNum = 0;
            oper = "";
            result = 0;
        }

        private void EqualClick()
        {

            Debug.WriteLine(oper);
            secondNum = decimal.Parse(_mainText.TextContent);
            CalculateNumbers(oper);
            _mainText.TextContent = result.ToString();
            _mainText.TextContent = "";
            Debug.WriteLine(result);
            firstNum = result;
            oper = "";
            
        }

        private void OnBtnClick(object s, EventArgs e)
        {
            var b = (IButton)s;
            Debug.WriteLine(b.BtnId.ToString());
            if (oper != "" && firstNum.ToString() == _mainText.TextContent)
            {
                _mainText.TextContent = b.ButtonContent.ToString();
            }
            else
            {
                resultTextHandler(b.ButtonContent.ToString());
            }
        }

        private void resultTextHandler(string a)
        {

            if (fieldIsEmpty())
            {
                _mainText.TextContent = a;
            }
            else
            {
                _mainText.TextContent += a;
            }
        }

        private bool fieldIsEmpty()
        {
            return (_mainText.TextContent.Length == 1 && _mainText.TextContent == "0");
        }

        //private void SetText (string s)
        //{
        //    _mainText.TextContent += s;
        //}
        
    }
}
