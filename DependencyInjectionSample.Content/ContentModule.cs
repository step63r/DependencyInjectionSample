using DependencyInjectionSample.Content.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace DependencyInjectionSample.Content
{
    public class ContentModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionMan = containerProvider.Resolve<IRegionManager>();
            regionMan.RegisterViewWithRegion("ContentRegion", typeof(LoginPage));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MyPage>();
        }
    }
}