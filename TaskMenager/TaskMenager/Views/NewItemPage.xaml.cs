using System;
using System.Collections.Generic;
using System.ComponentModel;
using TaskMenager.Models;
using TaskMenager.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskMenager.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}