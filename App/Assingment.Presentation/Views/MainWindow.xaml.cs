using Assignment.Services;
using Assingment.Presentation.ViewModels;
using System.Windows;
namespace Assingment.Presentation.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _vm;
        public MainWindow(IMainViewModel viewModel)
        {
            this.DataContext = viewModel;
            InitializeComponent();
            this.Dispatcher.UnhandledException += HandleError;
        }

        public void HandleError(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs args)
        {
            MessageBox.Show(args.Exception.Message);
        }

       
    }
}
