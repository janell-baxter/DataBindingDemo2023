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
        Cupcake[] cupcakes =
        {
            new Cupcake("Chocolate Explosion", "An awesome...", "chocolate.png"),
            new Cupcake("Vanilla Something", "A description here...", "vanilla.png"),
            new Cupcake("Blueberry Bonanza", "description...", "blueberry.png")
        };
        int index = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = cupcakes[index];
        }

        private void NaviagationButton_Click(object sender, RoutedEventArgs e)
        {
            index++;
            if (index >= cupcakes.Length)
                index = 0;
            DataContext = cupcakes[index];

        }
    }
}
