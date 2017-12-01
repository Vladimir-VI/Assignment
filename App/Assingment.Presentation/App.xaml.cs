using Ninject;
using System.Windows;
using Assingment.Presentation.Views;
using Assignment.Services;
using AutoMapper;
using Assingment.Presentation.DomainModels;
using Assignment.Models;
using Assignment.Data;
using Assingment.Presentation.ViewModels;

namespace Assingment.Presentation
{
    public partial class App : Application
    {
        StandardKernel _kernel;
        protected override void OnStartup(StartupEventArgs e)
        {
            InitializeMappings();
            _kernel = new StandardKernel();
            InintializeNinject();
            base.OnStartup(e);
            Current.MainWindow.Show();
        }

        private void InintializeNinject()
        {
            _kernel.Bind<IMainViewModel>().To<MainViewModel>();
            _kernel.Bind<IAssignmentContext>().To<Assignment.Data.AssignmentContext>();
            _kernel.Bind<ILoadService>().To<LoadService>();
            _kernel.Bind<IUpdateService>().To<UpdateService>();
            Current.MainWindow = _kernel.Get<MainWindow>();
        }

        private void InitializeMappings()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Event, EventDomainModel>().
                ForMember(a => a.Changed, b => b.Ignore());
            });
        }
    }
}
