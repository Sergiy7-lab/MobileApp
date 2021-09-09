using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using System.Threading.Tasks;

namespace FaceRegistration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            territory.Source = ImageSource.FromResource("FaceRegistration.assets.u258.png");
            house.Source = ImageSource.FromResource("FaceRegistration.assets.u259.png");
            phone.Source = ImageSource.FromResource("FaceRegistration.assets.u260.png");
            home.Source = ImageSource.FromResource("FaceRegistration.assets.u261.png");
            settings.Source = ImageSource.FromResource("FaceRegistration.assets.u262.png");
        }

        private void phone_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncomingCall());
        }

        private void settings_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void home_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private async void Territory_Tapped(object sender, EventArgs e)
        {
            territory.Source = ImageSource.FromResource("FaceRegistration.assets.u266.png");
            territory_text.Text = "The door is open";

            this.IsEnabled = false;

            //const string DOOR_OPENER_URL = "http://admin:12Zaqwsx@192.168.2.85/cgi-bin/accessControl.cgi?action=openDoor&channel=1";

            //Uri uri = new Uri(DOOR_OPENER_URL);
            //WebRequest request = WebRequest.Create(uri);

            //var credentialCache = new CredentialCache();
            //credentialCache.Add(new Uri(uri.GetLeftPart(UriPartial.Authority)), // request url's host
            //  "Digest",  // authentication type 
            //  new NetworkCredential("admin", "12Zaqwsx") // credentials 
            //);

            //request.Credentials = credentialCache;
            //WebResponse response = request.GetResponse();

            await Task.Delay(1500);
            territory.Source = ImageSource.FromResource("FaceRegistration.assets.u258.png");
            territory_text.Text = "Open";
            this.IsEnabled = true;
        }

        private async void House_Tapped(object sender, EventArgs e)
        {
            house.Source = ImageSource.FromResource("FaceRegistration.assets.u266.png");
            house_text.Text = "The door is open";

            this.IsEnabled = false;

            //const string DOOR_OPENER_URL = "http://admin:12Zaqwsx@192.168.2.86/cgi-bin/accessControl.cgi?action=openDoor&channel=1";

            //Uri uri = new Uri(DOOR_OPENER_URL);
            //WebRequest request = WebRequest.Create(uri);

            //var credentialCache = new CredentialCache();
            //credentialCache.Add(new Uri(uri.GetLeftPart(UriPartial.Authority)), // request url's host
            //  "Digest",  // authentication type 
            //  new NetworkCredential("admin", "12Zaqwsx") // credentials 
            //);

            //request.Credentials = credentialCache;
            //WebResponse response = request.GetResponse();

            await Task.Delay(1500);

            house.Source = ImageSource.FromResource("FaceRegistration.assets.u259.png");
            house_text.Text = "Open";
            this.IsEnabled = true;


        }
    }
}
