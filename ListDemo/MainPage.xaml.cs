using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListDemo.Helpers;
using Xamarin.Forms;

namespace ListDemo
{
    public partial class MainPage : ContentPage
    {
        FirebaseHelper fbhelper = new FirebaseHelper();
        List<Models.Shop> allShops;

        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            allShops = await fbhelper.GetAllShops();
            MyListView.ItemsSource = await fbhelper.GetAllShops();
        }
    }
}
