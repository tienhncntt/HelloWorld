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
	public partial class MHTinhTong : ContentPage
	{
		public MHTinhTong ()
		{
			InitializeComponent ();
		}

        private void TinhTongButton_Clicked(object sender, EventArgs e)
        {
            txtTong.Text = (double.Parse(txtSoA.Text) + double.Parse(txtSoB.Text)).ToString();
        }

        private void VeTrangChuButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}