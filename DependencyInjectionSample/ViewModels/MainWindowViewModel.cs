using Prism.Mvvm;

namespace DependencyInjectionSample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        #region コマンド・プロパティ
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindowViewModel()
        {

        }
    }
}
