using DependencyInjectionSample.Content.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjectionSample.Content.ViewModels
{
    public class LoginPageViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

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

        public LoginPageViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            LoginCommand = new DelegateCommand(ExecuteLogin, CanExecuteLogin);
            LoginCommand.ObservesProperty(() => UserID);
            LoginCommand.ObservesProperty(() => Password);
        }

        private void ExecuteLogin()
        {
            _regionManager.RequestNavigate("ContentRegion", nameof(MyPage));
        }

        private bool CanExecuteLogin()
        {
            return !(string.IsNullOrEmpty(UserID) || string.IsNullOrEmpty(Password));
        }
    }
}
