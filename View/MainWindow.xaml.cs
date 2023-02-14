using Task2.View.Pages;
using System.Windows;
using static Task2.Core.Core;

namespace Task2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyCore = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
    }
}