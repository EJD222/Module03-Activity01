using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ImagePage_Open(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImagePage());
        }

        private async void StackLayout_Activity(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity2());
        }

        private async void Grid_Activity(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity3());
        }
    }
}
