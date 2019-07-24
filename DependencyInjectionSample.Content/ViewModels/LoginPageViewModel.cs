using DependencyInjectionSample.Content.Views;
using DependencyInjectionSample.Core;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;

namespace DependencyInjectionSample.Content.ViewModels
{
    public class LoginPageViewModel : BindableBase
    {
        #region インタフェース
        /// <summary>
        /// RegionManager
        /// </summary>
        private readonly IRegionManager _regionManager;
        /// <summary>
        /// EventAggregator
        /// </summary>
        private readonly IEventAggregator _eventAggregator;
        #endregion

        #region コマンド・プロパティ
        /// <summary>
        /// ログインコマンド
        /// </summary>
        public DelegateCommand LoginCommand { get; private set; }

        private string _userID;
        /// <summary>
        /// ID
        /// </summary>
        public string UserID
        {
            get { return _userID; }
            set { SetProperty(ref _userID, value); }
        }
        private string _password;
        /// <summary>
        /// パスワード
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="regionManager"></param>
        /// <param name="eventAggregator"></param>
        public LoginPageViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            // インタフェースを受け取る
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;

            // コマンドを定義
            LoginCommand = new DelegateCommand(ExecuteLogin, CanExecuteLogin);
            LoginCommand.ObservesProperty(() => UserID);
            LoginCommand.ObservesProperty(() => Password);
        }

        /// <summary>
        /// ログインコマンドを実行
        /// </summary>
        private void ExecuteLogin()
        {
            _regionManager.RequestNavigate("ContentRegion", nameof(MyPage));
            _eventAggregator.GetEvent<MessageSentEvent>().Publish(UserID);
        }
        /// <summary>
        /// ログインコマンドが実行可能かどうかを判定
        /// </summary>
        /// <returns>IDとパスワードに両方値が入っていればtrue</returns>
        private bool CanExecuteLogin()
        {
            return !(string.IsNullOrEmpty(UserID) || string.IsNullOrEmpty(Password));
        }
    }
}
