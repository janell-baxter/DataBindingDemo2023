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

namespace DataBindingDemo2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person Player = new Person();
        public Menu CurrentMenu = new Menu();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //DataContext = cupcakes[index];
            CupcakeData.DataContext = CurrentMenu.Cupcakes[CurrentMenu.Index];
            OrderDetails.DataContext = Player.CurrentOrder;
        }

        private void NaviagationButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentMenu.Index++;
            if (CurrentMenu.Index >= CurrentMenu.Cupcakes.Length)
                CurrentMenu.Index = 0;
            CupcakeData.DataContext = CurrentMenu.Cupcakes[CurrentMenu.Index];

        }

        private void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            Player.CurrentOrder.Items.Add(CurrentMenu.Cupcakes[CurrentMenu.Index]);
            Player.CurrentOrder.OrderDetails();
        }
    }
}
