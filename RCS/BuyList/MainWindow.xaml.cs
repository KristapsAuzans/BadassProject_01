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

namespace BuyList
{
    using System.Collections.ObjectModel;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> BuyItemsList = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            BuyItemsList.Add("āboli");
            BuyItemsList.Add("burkāni");


            BuyItemsListControl.ItemsSource = BuyItemsList;
                    

        }

        private void AddListButton_Click(object sender, RoutedEventArgs e)
        {
            string item = BuyListItemName.Text;
            this.BuyListItemName.Text = "";
            BuyItemsList.Add(item);
        }
    }
}
