﻿using System;
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
using Meble_v_1._00.Languages;
using System.Globalization;
using System.Threading;

namespace Meble_v_1._00
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ustawienie_jezyka ust_jez = new ustawienie_jezyka();

            ust_jez.creatingForm = this;
            ust_jez.ShowDialog();
        }

        private void button_main_menu_create_new_order_Click(object sender, RoutedEventArgs e)
        {
            Tworzenie_nowego_zlecenia new_order = new Tworzenie_nowego_zlecenia();

            this.Close();
            new_order.ShowDialog();
        }
    }
}
