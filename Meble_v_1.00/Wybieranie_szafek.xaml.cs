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
using System.Windows.Shapes;
using Meble_v_1._00.Languages;

namespace Meble_v_1._00
{
    /// <summary>
    /// Logika interakcji dla klasy Wybieranie_szafek.xaml
    /// </summary>
    public partial class Wybieranie_szafek : Window
    {
        public Wybieranie_szafek()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            Tworzenie_nowego_zlecenia new_order = new Tworzenie_nowego_zlecenia();
            this.Close();
            new_order.ShowDialog();
        }
    }
}
