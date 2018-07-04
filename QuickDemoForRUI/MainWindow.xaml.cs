using System.Windows;

namespace QuickDemoForRUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; set; }
        public MainWindow()
        {
            ViewModel = new MainViewModel();
            InitializeComponent();
            DataContext = ViewModel;
        }
    }
}
