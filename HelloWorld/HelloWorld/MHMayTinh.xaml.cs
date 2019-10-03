using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MHMayTinh : ContentPage
	{
        enum Status { number1, number2}

        enum Operator { Plus, Sub, Multi, Div, Mod}

        private Status status = Status.number1;

        private Operator currentOperator;

        private double number1 = 0;

        private double number2 = 0;

        private bool _needRefresh = true;

        public MHMayTinh ()
		{
			InitializeComponent ();
		}

        private void BtnC_Clicked(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            RefreshButtonColor();
        }

        private void BtnOpposite_Clicked(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text[0] == '-' ? txtResult.Text.Substring(1) : $"-{txtResult.Text}";
        }

        private void BtnMod_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            currentOperator = Operator.Mod;

            btnMod.BackgroundColor = Color.FromHex("#acacac");

            if (status == Status.number1)
            {
                number1 = double.Parse(txtResult.Text);

                txtResult.Text = "0";

                status = Status.number2;
            }
            else
            {
                number2 = double.Parse(txtResult.Text);

                number1 = number1 % number2;

                txtResult.Text = (number1).ToString();

                status = Status.number1;

                _needRefresh = true;
            }
        }

        private void BtnDiv_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            currentOperator = Operator.Div;

            btnDiv.BackgroundColor = Color.FromHex("#b26000");

            if (status == Status.number1)
            {
                number1 = double.Parse(txtResult.Text);

                txtResult.Text = "0";

                status = Status.number2;
            }
            else
            {
                number2 = double.Parse(txtResult.Text);

                number1 = number1 / number2;

                txtResult.Text = (number1).ToString();

                status = Status.number1;

                _needRefresh = true;
            }
        }

        private void BtnMulti_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            currentOperator = Operator.Multi;

            btnMulti.BackgroundColor = Color.FromHex("#b26000");

            if (status == Status.number1)
            {
                number1 = double.Parse(txtResult.Text);

                txtResult.Text = "0";

                status = Status.number2;
            }
            else
            {
                number2 = double.Parse(txtResult.Text);

                number1 = number1 * number2;

                txtResult.Text = (number1).ToString();

                status = Status.number1;

                _needRefresh = true;
            }
        }

        private void BtnSub_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            currentOperator = Operator.Sub;

            btnSub.BackgroundColor = Color.FromHex("#b26000");

            if (status == Status.number1)
            {
                number1 = double.Parse(txtResult.Text);

                txtResult.Text = "0";

                status = Status.number2;
            }
            else
            {
                number2 = double.Parse(txtResult.Text);

                number1 = number1 - number2;

                txtResult.Text = (number1).ToString();

                status = Status.number1;

                _needRefresh = true;
            }
        }

        private void BtnPlus_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            currentOperator = Operator.Plus;

            btnPlus.BackgroundColor = Color.FromHex("#b26000");

            if (status == Status.number1)
            {
                number1 = double.Parse(txtResult.Text);

                txtResult.Text = "0";

                status = Status.number2;
            }
            else
            {
                number2 = double.Parse(txtResult.Text);

                number1 = number1 + number2;

                txtResult.Text = (number1).ToString();

                status = Status.number1;

                _needRefresh = true;
            }
        }

        private void BtnEquad_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();
            _needRefresh = true;
            if (status == Status.number1)
                txtResult.Text = number1.ToString();
            else
            {
                number2 = double.Parse(txtResult.Text);

                switch (currentOperator)
                {
                    case Operator.Div:
                        {
                            number1 = number1 / number2;
                            txtResult.Text = number1.ToString();
                            status = Status.number1;
                            break;
                        }
                    case Operator.Mod:
                        {
                            number1 = number1 % number2;
                            txtResult.Text = number1.ToString();
                            status = Status.number1;
                            break;
                        }
                    case Operator.Multi:
                        {
                            number1 = number1 * number2;
                            txtResult.Text = number1.ToString();
                            status = Status.number1;
                            break;
                        }
                    case Operator.Plus:
                        {
                            number1 = number1 + number2;
                            txtResult.Text = number1.ToString();
                            status = Status.number1;
                            break;
                        }
                    case Operator.Sub:
                        {
                            number1 = number1 - number2;
                            txtResult.Text = number1.ToString();
                            status = Status.number1;
                            break;
                        }
                }
            }
        }

        private void BtnNum0_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            if (_needRefresh)
            {
                txtResult.Text = "0";
                _needRefresh = false;
                return;
            }

            if (txtResult.Text[0] == '0')
                txtResult.Text = "0";
            else
                txtResult.Text += "0";
        }

        private void BtnNum1_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            if(_needRefresh)
            {
                txtResult.Text = "1";
                _needRefresh = false;
                return;
            }

            if (txtResult.Text[0] == '0')
                txtResult.Text = "1";
            else
                txtResult.Text += "1";
        }

        private void BtnNum2_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            if (_needRefresh)
            {
                txtResult.Text = "2";
                _needRefresh = false;
                return;
            }

            if (txtResult.Text[0] == '0')
                txtResult.Text = "2";
            else
                txtResult.Text += "2";
        }

        private void BtnNum3_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            if (_needRefresh)
            {
                txtResult.Text = "3";
                _needRefresh = false;
                return;
            }

            if (txtResult.Text[0] == '0')
                txtResult.Text = "3";
            else
                txtResult.Text += "3";
        }

        private void BtnNum4_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            if (_needRefresh)
            {
                txtResult.Text = "4";
                _needRefresh = false;
                return;
            }

            if (txtResult.Text[0] == '0')
                txtResult.Text = "4";
            else
                txtResult.Text += "4";
        }

        private void BtnNum5_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            if (_needRefresh)
            {
                txtResult.Text = "5";
                _needRefresh = false;
                return;
            }

            if (txtResult.Text[0] == '0')
                txtResult.Text = "5";
            else
                txtResult.Text += "5";
        }

        private void BtnNum6_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            if (_needRefresh)
            {
                txtResult.Text = "6";
                _needRefresh = false;
                return;
            }

            if (txtResult.Text[0] == '0')
                txtResult.Text = "6";
            else
                txtResult.Text += "6";
        }

        private void BtnNum7_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            if (_needRefresh)
            {
                txtResult.Text = "7";
                _needRefresh = false;
                return;
            }

            if (txtResult.Text[0] == '0')
                txtResult.Text = "7";
            else
                txtResult.Text += "7";
        }

        private void BtnNum8_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            if (_needRefresh)
            {
                txtResult.Text = "8";
                _needRefresh = false;
                return;
            }

            if (txtResult.Text[0] == '0')
                txtResult.Text = "8";
            else
                txtResult.Text += "8";
        }

        private void BtnNum9_Clicked(object sender, EventArgs e)
        {
            RefreshButtonColor();

            if (_needRefresh)
            {
                txtResult.Text = "9";
                _needRefresh = false;
                return;
            }

            if (txtResult.Text[0] == '0')
                txtResult.Text = "9";
            else
                txtResult.Text += "9";
        }

        private void BtnDoc_Clicked(object sender, EventArgs e)
        {

        }

        private void RefreshButtonColor()
        {
            btnMod.BackgroundColor = Color.FromHex("#dddddd");
            btnDiv.BackgroundColor = Color.Orange;
            btnSub.BackgroundColor = Color.Orange;
            btnMulti.BackgroundColor = Color.Orange;
            btnPlus.BackgroundColor = Color.Orange;
        }
    }
}