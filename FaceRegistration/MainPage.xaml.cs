using System;
using Xamarin.Forms;

namespace FaceRegistration
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource("FaceRegistration.assets.normal_u32.png");
            face.Source = ImageSource.FromResource("FaceRegistration.assets.normal_u36.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void Button_Back(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void SkipStep_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}