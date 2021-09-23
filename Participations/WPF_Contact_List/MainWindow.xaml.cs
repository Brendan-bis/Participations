using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Contact_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Contact> Contacts = new List<Contact>();
        public MainWindow()
        {
            InitializeComponent();

            var lines = File.ReadAllLines("contacts.txt").Skip(1);

            foreach (var line in lines)
            {
                Contacts.Add(new Contact(line));
            }

            PopulateListBox(Contacts);

        }

        private void PopulateListBox(List<Contact> contacts)
        {
            lstContacts.Items.Clear();

            foreach (var contact in contacts)
            {
                lstContacts.Items.Add(contact);
            }


        }


        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            Contact selectedContact = (Contact)lstContacts.SelectedItem;

            txtFirst.Text = selectedContact.FirstName;
            txtLast.Text = selectedContact.LastName;
            txtEmail.Text = selectedContact.Email;

            var uri = new Uri(selectedContact.Photo);
            var img = new BitmapImage(uri);
            imgPic.Source = img;
        }
    }
}
