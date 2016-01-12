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
    /// DataGrid.xaml 的交互逻辑
    /// </summary>
    public partial class DataGrid : Page
    {
        MainWindow parentWindow;

        ObservableCollection<Box> boxes = new ObservableCollection<Box>();
        public DataGrid()
        {
            InitializeComponent();
        }

        public DataGrid(MainWindow parentWindow)
        {
            InitializeComponent();
            this.parentWindow = parentWindow;
        }

        private void DataGridName_Loaded(object sender, RoutedEventArgs e)
        {
            int itemcount = 20;
            for (int i = 0; i < itemcount; i++)
            {
                boxes.Add(new Box()
                {
                    BoxID = i*10,
                    PartNumber =  49325139+i*2+""
                });
            }

            this.MyDataGrid.ItemsSource = boxes;
        }
    }
}
