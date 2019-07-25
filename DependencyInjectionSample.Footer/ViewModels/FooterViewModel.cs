using DependencyInjectionSample.Content.Common;
using Prism.Commands;
using Prism.Mvvm;

namespace DependencyInjectionSample.Footer.ViewModels
{
    public class FooterViewModel : BindableBase
    {
        #region コマンド・プロパティ
        /// <summary>
        /// 戻るコマンド
        /// </summary>
        public DelegateCommand GoBackCommand { get; private set; }
        /// <summary>
        /// 進むコマンド
        /// </summary>
        public DelegateCommand GoForwardCommand { get; private set; }
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FooterViewModel()
        {
            // コマンドを定義
            GoBackCommand = new DelegateCommand(ExecuteGoBack, CanExecuteGoBack);
            GoForwardCommand = new DelegateCommand(ExecuteGoForward, CanExecuteGoForward);
        }

        /// <summary>
        /// 戻るコマンドを実行
        /// </summary>
        private void ExecuteGoBack()
        {
            ContentJournal.Journal.GoBack();
        }
        /// <summary>
        /// 戻るコマンドが実行可能かどうかを安定
        /// </summary>
        /// <returns>戻り先の履歴があればtrue</returns>
        private bool CanExecuteGoBack()
        {
            //return ContentJournal.Journal != null && ContentJournal.Journal.CanGoBack;
            return true;
        }

        /// <summary>
        /// 進むコマンドを実行
        /// </summary>
        private void ExecuteGoForward()
        {
            ContentJournal.Journal.GoForward();
        }
        /// <summary>
        /// 進むコマンドが実行可能かどうかを判定
        /// </summary>
        /// <returns>進み先の履歴があればtrue</returns>
        private bool CanExecuteGoForward()
        {
            //return ContentJournal.Journal != null && ContentJournal.Journal.CanGoForward;
            return true;
        }
    }
}
