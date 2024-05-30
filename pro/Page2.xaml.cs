using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Page2.xaml에 대한 상호 작용 논리
    /// </summary>
    
    public partial class Page2 : Page , INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler? PropertyChanged;
    
        public Page2()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
                

        }

        private void aaaaaaaaa_MouseDown(object sender, MouseButtonEventArgs e)
        {
            aaaaaaaaa.Content = Page3.total_price;
        }
    }
}
