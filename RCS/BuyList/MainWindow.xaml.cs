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
    using System.IO;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> BuyItemsList = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();



            BuyItemsListControl.ItemsSource = BuyItemsList;
                    

        }

        private void AddListButton_Click(object sender, RoutedEventArgs e)
        {
            string item = BuyListItemName.Text;
            this.BuyListItemName.Text = "";
            BuyItemsList.Add(item);
                        
        }

        private void SaveButton_Click (object sender, RoutedEventArgs e)
        {
            File.Delete(@"D:\Kristaps\Codes\BadassProject_01\RCS\BuyList\savedlist.txt");
            File.WriteAllLines(@"D:\Kristaps\Codes\BadassProject_01\RCS\BuyList\savedlist.txt", this.BuyItemsList);

        }

        private void ResetButton_Click (object sender, RoutedEventArgs e)
        {
           string[] DataFromList = File.ReadAllLines (@"D:\Kristaps\Codes\BadassProject_01\RCS\BuyList\savedlist.txt");
            for (int i = 0; i < DataFromList.Length; i++)
            {
                string currentDataFromList = DataFromList[i];
                BuyItemsList.Add(currentDataFromList);
            }
            
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = BuyItemsListControl.SelectedItems;
            for (int i = 0; i < selectedItems.Count; i++)
            {
                string currentselectedItems = selectedItems[i] as string;
                BuyItemsList.Remove(currentselectedItems);
            }

            
        }
    } 
}
