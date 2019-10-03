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
	public partial class MHChao : ContentPage
	{
		public MHChao ()
		{
			InitializeComponent ();
		}

        private void ChaoButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Chào", $"Chào bạn {HoTen.Text}", "Thoát");
        }
    }
}