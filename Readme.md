# Fruit Bucket
Aplikasi ini merupakan aplikasi keranjang buah sederhana yang baru bisa menambahkan buah ke keranjang saja
## Fungsionalitas
- User dapat memilih/menambahkan buah kedalam keranjang
- User akan mendapatkan notifikasi jika keranjang sudah penuh (max 2)
## Cara Kerja
- Konsep Model terletakkan pada folder model yang berisikan class `Seller.cs`, `Fruit.cs`, `Bucket.cs`, dan `BucketEventListener.cs`
- Konsep View ada pada `MainWindow.xaml`
- Konsep Controler aku letakkan pada folder controller yang berisi class `BucketController.cs` dimana kamu bisa mengedit fungsionalitas dari program ini

Untuk mengubah kapasitas keranjang bisa dilakukan di `MainWindow.xaml.cs`
```csharp
        public MainWindow()
        {
            InitializeComponent();

            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            Bowo = new Seller("Bowo", bucketController);
            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }
```