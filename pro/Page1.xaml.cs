﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace pro
{
    /// <summary>
    /// Page1.xaml에 대한 상호 작용 논리
    /// </summary>
    ///        

    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
           
        }

        private void btn_nav_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                        new Uri("/Page3.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
