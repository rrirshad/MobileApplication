using App5.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App5.ViewModels
{
    public class ItemViewModel
    {
        public ObservableCollection<Item> Items { get; set; }

        public ItemViewModel()
        {
            Items = new ObservableCollection<Item>
        {
            new Item { Name = "Item 1", Description = "This is the description for Item 1." },
            new Item { Name = "Item 2", Description = "This is the description for Item 2." },
            new Item { Name = "Item 3", Description = "This is the description for Item 3." }
        };
        }
    }
}
