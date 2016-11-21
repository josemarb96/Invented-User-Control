using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Invented_User_Control.User_Control
{
    public sealed partial class FichaJuego : UserControl
    {
        public FichaJuego()
        {
            this.InitializeComponent();
        }

        //IMAGEN CABECERA
        public ImageSource imgCabecera
        {
            get { return (ImageSource)GetValue(imgCabeceraProperty); }
            set { SetValue(imgCabeceraProperty, value); }
        }

        // Using a DependencyProperty as the backing store for imgCabecera.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty imgCabeceraProperty =
            DependencyProperty.Register("imgCabecera", typeof(ImageSource), typeof(FichaJuego), 
                new PropertyMetadata(new BitmapImage(new Uri("ms-appx://Invented_User_Control/Assets/defaultImage.png"))));

        //IMAGEN 1
        public ImageSource img1
        {
            get { return (ImageSource)GetValue(img1Property); }
            set { SetValue(img1Property, value); }
        }

        // Using a DependencyProperty as the backing store for img1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty img1Property =
            DependencyProperty.Register("img1", typeof(ImageSource), typeof(FichaJuego),
                new PropertyMetadata(new BitmapImage(new Uri("ms-appx://Invented_User_Control/Assets/defaultImage.png"))));

        //IMAGEN 2
        public ImageSource img2
        {
            get { return (ImageSource)GetValue(img2Property); }
            set { SetValue(img2Property, value); }
        }

        // Using a DependencyProperty as the backing store for img1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty img2Property =
            DependencyProperty.Register("img2", typeof(ImageSource), typeof(FichaJuego),
                new PropertyMetadata(new BitmapImage(new Uri("ms-appx://Invented_User_Control/Assets/defaultImage.png"))));

        //TITULO
        public string titulo
        {
            get { return (string)GetValue(tituloProperty); }
            set { SetValue(tituloProperty, value); }
        }

        // Using a DependencyProperty as the backing store for titulo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty tituloProperty =
            DependencyProperty.Register("titulo", typeof(string), typeof(FichaJuego), new PropertyMetadata(String.Empty));


        //DESCRIPCION
        public string descripcion
        {
            get { return (string)GetValue(descripcionProperty); }
            set { SetValue(descripcionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for descripcion.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty descripcionProperty =
            DependencyProperty.Register("descripcion", typeof(string), typeof(FichaJuego), new PropertyMetadata(String.Empty));
    }
}
