using DependencyInjectionSample.Header.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace DependencyInjectionSample.Header
{
    public class HeaderModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionMan = containerProvider.Resolve<IRegionManager>();
            regionMan.RegisterViewWithRegion("HeaderRegion", typeof(Views.Header));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}