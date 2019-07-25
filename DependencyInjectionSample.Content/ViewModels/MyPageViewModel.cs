using DependencyInjectionSample.Content.Common;
using Prism.Mvvm;
using Prism.Regions;

namespace DependencyInjectionSample.Content.ViewModels
{
    public class MyPageViewModel : BindableBase, INavigationAware
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MyPageViewModel()
        {

        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            ContentJournal.Journal = navigationContext.NavigationService.Journal;
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            ContentJournal.Journal = navigationContext.NavigationService.Journal;
        }
    }
}
