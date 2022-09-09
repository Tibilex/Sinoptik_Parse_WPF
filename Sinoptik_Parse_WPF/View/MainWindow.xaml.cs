using Sinoptik_Parse_WPF.ViewModel;
using System.Windows;

namespace Sinoptik_Parse_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SinoptikViewModel _sinoptikVM;
        public MainWindow()
        {
            InitializeComponent();
            _sinoptikVM = new();
            this.DataContext = _sinoptikVM;
        }
    }
}
