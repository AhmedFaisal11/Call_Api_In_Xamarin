using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GetApiData
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var httpclient = new HttpClient();
            var result = await httpclient.GetStringAsync("https://jsonplaceholder.typicode.com/users");
            var resultUser = JsonConvert.DeserializeObject<Users[]>(result);
            User.ItemsSource = resultUser;
        }
    }
}
