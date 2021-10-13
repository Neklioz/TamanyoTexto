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

namespace TamanyoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MedianoRadioButton.IsChecked = true;
        }

        private void TamañoFuenteChecked(object sender, RoutedEventArgs e)
        {
            RadioButton boton = (RadioButton)sender;
            string tamaño = boton.Tag.ToString();
            if(tamaño == "Pequeño")
            {
                TextoTextBlock.FontSize = 36;
            }
            else if(tamaño == "Mediano")
            {
                TextoTextBlock.FontSize = 48;
            }
            else
            {
                TextoTextBlock.FontSize = 72;
            }
        }
    }
}
