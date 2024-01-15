using StudentMVVMProjekt.ViewModels;
using System.Windows;

namespace StudentMVVMProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new StudentViewModel();
        }
    }
}
