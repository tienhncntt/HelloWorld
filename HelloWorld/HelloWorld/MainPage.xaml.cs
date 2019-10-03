using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ManHinhChao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MHChao());
        }

        private void ManHinhTinhTong_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MHTinhTong());
        }

        private void StackLayout_Clicked(object sender, EventArgs e)
        {

        }

        private void AbsoluteLayout_Clicked(object sender, EventArgs e)
        {

        }

        private void GridLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MHMayTinh());
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MHLogin());
        }

        private void FlexLayout_Clicked(object sender, EventArgs e)
        {

        }

        private void ScrollView_Clicked(object sender, EventArgs e)
        {

        }

        private void Entry_Clicked(object sender, EventArgs e)
        {

        }

        private void ListView_Clicked(object sender, EventArgs e)
        {

        }
    }
}
