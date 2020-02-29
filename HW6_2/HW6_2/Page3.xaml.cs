using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HW6_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public Page3()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Never Gonna",
                "Give you Up",
                "Let You Down",
                "Run Around",
                "Desert You"
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "Please don't touch that!", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
