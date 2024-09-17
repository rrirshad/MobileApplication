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
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage(Item selectedItem)
        {
            InitializeComponent();
            BindingContext = selectedItem;
        }
    }
}