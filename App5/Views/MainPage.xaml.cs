using App5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ItemsListView.ItemTapped += async (sender, e) =>
            {
                if (e.Item != null)
                {
                    var selectedItem = e.Item as Item;
                    await Navigation.PushAsync(new ItemDetailPage(selectedItem));
                }
            };
        }
    }
}