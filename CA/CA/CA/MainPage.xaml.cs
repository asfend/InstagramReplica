using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Mobile.Analytics;
using Xamarin.Forms;

namespace CA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btnlogin_OnClicked(object sender, EventArgs e)
        {
            var em = email.Text;
            var ps = password.Text;
            Analytics.TrackEvent("Sign In Button Clicked", new Dictionary<string, string>
            {
                {"User Name",em },
                {"User Password",ps },
            });

        }
    }
}
