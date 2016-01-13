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

namespace WPFUI
{
    /// <summary>
    /// SOP.xaml 的交互逻辑
    /// </summary>
    public partial class SOP : Page
    {
        MainWindow parentWindow;
        ObservableCollection<ShowList> listData = new ObservableCollection<ShowList>();

        public SOP()
        {
            InitializeComponent();
        }

        public SOP(MainWindow parentWindow)
        {
            InitializeComponent();
            this.parentWindow = parentWindow;
        }

        private void ListDataLoad(object sender, RoutedEventArgs e)
        {
            int itemcount = 20;
            for(int i = 0; i < itemcount; i++)
            {
                listData.Add(new ShowList()
                {
                    ListNumber = i,
                    ListName = "ListShow"+i * 20 
                });
            }
            this.ShowListName.ItemsSource = listData;
        }
    }
}
