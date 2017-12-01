using Assignment.Data;
using Assignment.Models;
using Assignment.Services;
using Assingment.Presentation.ViewModels;
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
namespace Assingment.Presentation.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _vm;
        public MainWindow(ILoadService loadService, IUpdateService updateService)
        {


            _vm = new MainViewModel(loadService, updateService);
            this.DataContext = _vm;
            InitializeComponent();
            this.Dispatcher.UnhandledException += HandleError;
        }

        public void HandleError(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs args)
        {
            MessageBox.Show(args.Exception.Message);
        }

       
    }
}
