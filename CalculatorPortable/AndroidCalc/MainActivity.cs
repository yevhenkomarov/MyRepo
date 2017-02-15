using Android.App;
using Android.Widget;
using Android.OS;
using CalculatorPortable;

namespace AndroidCalc
{
    [Activity(Label = "AndroidCalc", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);

            IButton btn_0 = new AndroidButton(FindViewById<Button>(Resource.Id.btn_0));
            IButton btn_1 = new AndroidButton(FindViewById<Button>(Resource.Id.btn_1));
            IButton btn_2 = new AndroidButton(FindViewById<Button>(Resource.Id.btn_2));
            IButton btn_3 = new AndroidButton(FindViewById<Button>(Resource.Id.btn_3));
            IButton btn_4 = new AndroidButton(FindViewById<Button>(Resource.Id.btn_4));
            IButton btn_5 = new AndroidButton(FindViewById<Button>(Resource.Id.btn_5));
            IButton btn_6 = new AndroidButton(FindViewById<Button>(Resource.Id.btn_6));
            IButton btn_7 = new AndroidButton(FindViewById<Button>(Resource.Id.btn_7));
            IButton btn_8 = new AndroidButton(FindViewById<Button>(Resource.Id.btn_8));
            IButton btn_9 = new AndroidButton(FindViewById<Button>(Resource.Id.btn_9));
            IButton btn_coma = new AndroidButton(FindViewById<Button>(Resource.Id.btn_dot));

            IButton btn_plus = new AndroidButton (FindViewById<Button>(Resource.Id.btn_plus));
            IButton btn_minus = new AndroidButton(FindViewById<Button>(Resource.Id.btn_minus));
            IButton btn_equal = new AndroidButton(FindViewById<Button>(Resource.Id.btn_equal));
            IButton btn_multiply = new AndroidButton(FindViewById<Button>(Resource.Id.btn_multiply));
            IButton btn_divide = new AndroidButton(FindViewById<Button>(Resource.Id.btn_divide));
            IButton btn_clear = new AndroidButton(FindViewById<Button>(Resource.Id.btn_clr));

            IResultText resultTxt = new AndroidTextView (FindViewById<TextView>(Resource.Id.txtResult));
            IResultText smallTxt = new AndroidTextView(FindViewById<TextView>(Resource.Id.secondTxt));

            IButton[] buttons = new IButton[11] { btn_0, btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8, btn_9, btn_coma };
            IButton[] operators = new IButton[6] { btn_plus, btn_minus, btn_equal, btn_multiply, btn_divide, btn_clear };

            var Calc = new CalculatorPortable.CalculatorPortable(buttons, operators, resultTxt, smallTxt);

        }
    }
}

