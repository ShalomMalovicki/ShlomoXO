using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ShlomoXO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel viewModel = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = viewModel.IsPlayerXTurn ? "X" : "O";
            if (viewModel.IsPlayerXTurn)
            {
                button.Foreground = Brushes.Red;
                viewModel.Board[int.Parse(button.Tag.ToString())] = 'X';
            }
            else
            {
                button.Foreground = Brushes.Green;
                viewModel.Board[int.Parse(button.Tag.ToString())] = 'O';
            }

            viewModel.IsPlayerXTurn = !viewModel.IsPlayerXTurn;
        }
    }
}
