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

namespace WPFUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Page currentPage;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.currentPage = new NewCart(this);
            NaviFrame.NavigationService.Navigate(this.currentPage);
        }

        private void Next_Page(object sender, RoutedEventArgs e)
        {
            this.GoToNextPage();
        }

        public void GoToNextPage()
        {
            if (this.currentPage.Name == "NewCartName")
            {
                this.currentPage = new NewCart2(this);
                NaviFrame.NavigationService.Navigate(this.currentPage);
            }
            else if (this.currentPage.Name == "NewCart2Name")
            {
                this.currentPage = new Btn(this);
                NaviFrame.NavigationService.Navigate(this.currentPage);
            }
            else if (this.currentPage.Name == "BtnName")
            {
                this.currentPage = new DataGrid(this);
                NaviFrame.NavigationService.Navigate(this.currentPage);
            }
            else if (this.currentPage.Name == "DataGridName")
            {
                this.currentPage = new SOP(this);
                NaviFrame.NavigationService.Navigate(this.currentPage);
            }
            else if (this.currentPage.Name == "SOPName") {
                this.currentPage = new Scale(this);
                NaviFrame.NavigationService.Navigate(this.currentPage);
            }
            else
            {
                this.currentPage = new NewCart(this);
                NaviFrame.NavigationService.Navigate(this.currentPage);
            }
        }
    }
}
