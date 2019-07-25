using DependencyInjectionSample.Content;
using DependencyInjectionSample.Footer;
using DependencyInjectionSample.Header;
using DependencyInjectionSample.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace DependencyInjectionSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<HeaderModule>(InitializationMode.WhenAvailable);
            moduleCatalog.AddModule<ContentModule>(InitializationMode.WhenAvailable);
            moduleCatalog.AddModule<FooterModule>(InitializationMode.WhenAvailable);
        }
    }
}
