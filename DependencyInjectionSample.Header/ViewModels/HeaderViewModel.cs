using DependencyInjectionSample.Core;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Windows.Threading;

namespace DependencyInjectionSample.Header.ViewModels
{
    public class HeaderViewModel : BindableBase
    {
        /// <summary>
        /// タイマ
        /// </summary>
        private DispatcherTimer timer;

        #region インタフェース
        /// <summary>
        /// EventAggregator
        /// </summary>
        private readonly IEventAggregator _eventAggregator;
        #endregion

        #region コマンド・プロパティ
        private string _userName = "Guest";
        /// <summary>
        /// ユーザー名
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }
        private DateTime _currentTime = DateTime.Now;
        /// <summary>
        /// 現在時刻
        /// </summary>
        public DateTime CurrentTime
        {
            get { return _currentTime; }
            set { SetProperty(ref _currentTime, value); }
        }
        private int _battery = 100;
        /// <summary>
        /// バッテリ残量
        /// </summary>
        public int Battery
        {
            get { return _battery; }
            set { SetProperty(ref _battery, value); }
        }
        #endregion
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="eventAggregator"></param>
        public HeaderViewModel(IEventAggregator eventAggregator)
        {
            // インタフェースを受け取る
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<MessageSentEvent>().Subscribe(UserNameReceived);

            // タイマの開始
            timer = new DispatcherTimer(DispatcherPriority.Normal)
            {
                // インターバル
                Interval = TimeSpan.FromSeconds(1.0)
            };
            // タイマメソッド
            timer.Tick += (s, e) =>
            {
                CurrentTime = DateTime.Now;
            };
            // タイマ開始
            timer.Start();
        }

        /// <summary>
        /// ユーザー名取得イベント
        /// </summary>
        /// <param name="message"></param>
        private void UserNameReceived(string message)
        {
            UserName = message;
        }

        /// <summary>
        /// デストラクタ
        /// </summary>
        ~HeaderViewModel()
        {
            timer.Stop();
        }
    }
}
