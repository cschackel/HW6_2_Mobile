using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW6_2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
/*
        private async void OnGridClicked()
        {
            Page page = (Page)Activator.CreateInstance(typeof(GridPage));
            await Navigation.PushAsync(page);
            
        }

        private async void OnListClicked()
        {
            Page page = (Page)Activator.CreateInstance(typeof(GridPage));
            await Navigation.PushAsync(page);

        }

        private async void OnScrollClicked()
        {
            Page page = (Page)Activator.CreateInstance(typeof(GridPage));
            await Navigation.PushAsync(page);

        }

        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

            if (args.SelectedItem != null)
            {
                PagesViewModel pageData = args.SelectedItem as PagesViewModel;
                Page page = (Page)Activator.CreateInstance(pageData.Type);
                await Navigation.PushAsync(page);
            }
        }
        */
        private async void GridClicked(object sender, EventArgs e)
        {
            //Page page = Activator.CreateInstance(typeof(GridPage));
            await Navigation.PushAsync(new Page2());
        }

        private async void ListClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        private async void ScrollClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}
