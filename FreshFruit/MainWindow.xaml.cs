using FreshFruit.controller;
using FreshFruit.model;
using System;
using System.Collections.Generic;
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

namespace FreshFruit
{
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller Bowo;

        public MainWindow()
        {
            InitializeComponent();

            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            Bowo = new Seller("Bowo", bucketController);
            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            Bowo.addFruit(anggur);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Fruit apel = new Fruit("Apel");
            Bowo.addFruit(apel);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Fruit pisang = new Fruit("Pisang");
            Bowo.addFruit(pisang);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Fruit jeruk = new Fruit("Jeruk");
            Bowo.addFruit(jeruk);
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }
    }
}
