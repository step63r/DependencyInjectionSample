using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace DependencyInjectionSample.Footer
{
    public class FooterModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionMan = containerProvider.Resolve<IRegionManager>();
            regionMan.RegisterViewWithRegion("FooterRegion", typeof(Views.Footer));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}