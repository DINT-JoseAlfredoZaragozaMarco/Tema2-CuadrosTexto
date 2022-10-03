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

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                if ((sender as TextBox).Name == "texto1TextBox")
                {
                    if (ayuda1TextBlock.Text.Length == 0) ayuda1TextBlock.Text = "Nombre del cliente";
                    else ayuda1TextBlock.Text = "";
                }
                else
                {
                    if (ayuda2TextBlock.Text.Length == 0) ayuda2TextBlock.Text = "Apellido del cliente";
                    else ayuda2TextBlock.Text = "";
                }
            }
            
        }

        private void TextBox_KeyDown2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if ((sender as TextBox).Text.Equals(typeof(int)))
                {
                    ayuda3TextBlock.Text = "";
                }
                else ayuda3TextBlock.Text = "Edad incorrecta";
            }
        }
    }
}
