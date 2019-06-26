using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace App1
{
   
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        private ObservableCollection<Contact> _contacts;

        private ObservableCollection<Contact> GetContacs()
        {
            return new ObservableCollection<Contact>
            {
                new Contact{
                    Name = "Frank",
                    ImageUrl = "https://placeimg.com/200/200/people/1",
                    Status = "0426-4745950"
                },

                new Contact{
                    Name = "Eduardo",
                    ImageUrl = "https://placeimg.com/200/200/people/2",
                    Status = "0426-4744253"
                },

                new Contact{
                    Name = "Fernando",
                    ImageUrl = "https://placeimg.com/200/200/people/3",
                    Status = "0424-2938437"
                },

                new Contact{
                    Name = "Luis",
                    ImageUrl = "https://placeimg.com/200/200/people/4",
                    Status = "350-7897643"
                },

                new Contact{
                    Name = "Lisbeth",
                    ImageUrl = "https://placeimg.com/200/200/people/5",
                    Status = "0416-0760995"
                },

                new Contact{
                    Name = "Luisana",
                    ImageUrl = "https://placeimg.com/200/200/people/6",
                    Status = "0426-7206011"
                },

            };
        }
        public MainPage()
        {
            InitializeComponent();

            _contacts = GetContacs();

            listView1.ItemsSource = _contacts;

        }

        private void Llamar_Clicked(object sender, EventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            Contact contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Llamar", contact.Name, "OK");
        }

        private void Eliminar_Clicked(object sender, EventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            Contact contact = menuItem.CommandParameter as Contact;

            _contacts.Remove(contact);
        }

        private void ListView1_Refreshing(object sender, EventArgs e)
        {
            listView1.EndRefresh();
        }
    }
}
