using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FaceRegistration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IncomingCall : ContentPage
    {
        public IncomingCall()
        {
            InitializeComponent();
            camera.Source = ImageSource.FromResource("FaceRegistration.assets.normal_u394.png");
            answer.Source = ImageSource.FromResource("FaceRegistration.assets.normal_u400.png");

            image.Source = ImageSource.FromResource("FaceRegistration.assets.normal_u409.png");
            accept.Source = ImageSource.FromResource("FaceRegistration.assets.normal_u411.png");
            decline.Source = ImageSource.FromResource("FaceRegistration.assets.normal_u414.png");


        }

        private void Button_Answer(object sender, EventArgs e)
        {
            answer.IsVisible = false;
        }

        private void Button_Accept(object sender, EventArgs e)
        {
            DisplayAlert("The door is open", "", "Ok");
            Navigation.PushAsync(new HomePage());
        }

        private void Button_Decline(object sender, EventArgs e)
        {
            DisplayAlert("Declining call", "", "Ok");
            Navigation.PushAsync(new HomePage());
        }
    }
}