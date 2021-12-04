using System.Windows;

namespace Frontend
{
    public partial class MainWindow : Window
    {
        public MainWindow(IProjectViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }

}
