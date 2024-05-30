using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static System.Net.Mime.MediaTypeNames;

namespace pro
{


    /// <summary>
    /// Page3.xaml에 대한 상호 작용 논리
    /// </summary>

    public partial class Page3 : Page
    {

       static public int total_price = 0;
       static public int countA = 0;
       static public int countB = 0;
       static public int countC = 0;

       static ObservableCollection<sangpum> sangpums = new ObservableCollection<sangpum>();
       static sangpum sangpumA = new sangpum(); // 버팔로 윙
       static sangpum sangpumB = new sangpum(); // 치밥
       static sangpum sangpumC = new sangpum(); // 프라이드 치킨

        static void clear_hae()
        {
            
            total_price = 0;
            countA = 0;
            countB =    0; 
            countC = 0;
            sangpums.Clear();

        }
        class sangpum
        {
            static private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
           static private string price;

            public string Price
            {
                get { return price; }
                set { price = value; }
            }

           static private string sangpumimg;

            public string SangpumImg
            {
                get { return sangpumimg; }
                set { sangpumimg = value; }
            }
        }

        public Page3() 

        {
            InitializeComponent();

        }
        public void cal()
        {
            if (countA >= 0 && countB >= 0 && countC >= 0)
                total_price = countA * int.Parse(Price_block1.Text) + countB * int.Parse(Price_block2.Text) + countC * int.Parse(Price_block3.Text);

        }


        private void btn_page3_Click(object sender, RoutedEventArgs e)
        {
            // 다음 페이지로 이동
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }





        private void Btn_order1_Click(object sender, RoutedEventArgs e)
        {
            // 버팔로 윙
            // ObservableCollection<sangpum> sangpums = new ObservableCollection<sangpum>();
            //sangpum sangpumA = new sangpum();
            sangpumA.Name = Item_name2.Text;
            sangpumA.Price = Price_block1.Text;
            sangpumA.SangpumImg = @"/image/images.jpg"; 
            sangpums.Add(sangpumA);
            countA += 1;
            cal();
            asdf.Content = total_price;
            Listview_sanpum.ItemsSource = sangpums;
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //버팔로윙 뺴기
            sangpums.Remove(sangpumA);
            total_price -= int.Parse(Price_block1.Text);
            asdf.Content = total_price;
            if(countA >0)
                countA -= 1;
            cal();
            asdf.Content = total_price;
            

        }

        private void btn_order3_Click(object sender, RoutedEventArgs e)
        {
            // 치밥
            sangpumB.Name = Item_name1.Text;
            sangpumB.Price = Price_block1.Text;
            sangpumB.SangpumImg =   @"/Image/images(3).jpg";  //버팔로
            sangpums.Add(sangpumB);
            countB += 1;
            cal();
            asdf.Content = total_price;

            Listview_sanpum.ItemsSource = sangpums;

        }

        private void btn_order3복사__C__Click(object sender, RoutedEventArgs e)
        {
            sangpumC.Name = Item_name3.Text;
            sangpumC.Price = Price_block3.Text;
            sangpumC.SangpumImg = @"/Image/다운로드.jpg"; //프라이드
            sangpums.Add(sangpumC);
            countC += 1;
            cal();
            asdf.Content = total_price;

            Listview_sanpum.ItemsSource = sangpums;
            // GridViewColumn
        }



        private void minus_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 버팔로윙 제거
            sangpums.Remove(sangpumB);
            if (countB > 0)
                countB -= 1;
            cal();
            asdf.Content = total_price;
        }

        private void minus3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            sangpums.Remove(sangpumC);
            if (countC > 0)
                countC -= 1;
            cal();
            asdf.Content = total_price;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 
            MessageBoxResult mbr = MessageBox.Show("결제하시겠습니까?.", "Final Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (mbr == MessageBoxResult.Yes)
            {
                MessageBox.Show("결제완료.", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
                clear_hae();
                NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));

            }
            else if (mbr == MessageBoxResult.No)
            {
                MessageBox.Show("결제실패...", "Result", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            MessageBox.Show("주문이 완료되었습니다.");

        }



        private void pppppp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));

        }
    }
}
