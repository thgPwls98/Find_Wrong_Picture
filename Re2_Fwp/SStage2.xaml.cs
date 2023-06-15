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

namespace Re2_Fwp
{
    /// <summary>
    /// SStage2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SStage2 : Page
    {
        private int clickCnt = 1;
        public void ClickCnt(int clickCnt)
        {
            if (clickCnt == 8)
            {
                MessageBox.Show("전부 찾으셨어요! 다음 Stage로 넘어갑니다!");
                NavigationService.Navigate(new Uri("/SStage3.xaml", UriKind.Relative));
            }
        }
        public SStage2()
        {
            InitializeComponent();
            circle1.Visibility = Visibility.Hidden;
            circle2.Visibility = Visibility.Hidden;
            circle3.Visibility = Visibility.Hidden;
            circle4.Visibility = Visibility.Hidden;
            circle5.Visibility = Visibility.Hidden;
            circle6.Visibility = Visibility.Hidden;
            circle7.Visibility = Visibility.Hidden;
        }

        private void Hide1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            circle1.Visibility = Visibility.Visible;
            score.Text = "Score: " + clickCnt++;
            ClickCnt(clickCnt);
        }

        private void Hide2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            circle2.Visibility = Visibility.Visible;
            score.Text = "Score: " + clickCnt++;
            ClickCnt(clickCnt);
        }

        private void Hide3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            circle3.Visibility = Visibility.Visible;
            score.Text = "Score: " + clickCnt++;
            ClickCnt(clickCnt);
        }

        private void Hide4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            circle4.Visibility = Visibility.Visible;
            score.Text = "Score: " + clickCnt++;
            ClickCnt(clickCnt);
        }

        private void Hide5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            circle5.Visibility = Visibility.Visible;
            score.Text = "Score: " + clickCnt++;
            ClickCnt(clickCnt);
        }

        private void Hide6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            circle6.Visibility = Visibility.Visible;
            score.Text = "Score: " + clickCnt++;
            ClickCnt(clickCnt);
        }

        private void Hide7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            circle7.Visibility = Visibility.Visible;
            score.Text = "Score: " + clickCnt++;
            ClickCnt(clickCnt);
        }
    }
}
