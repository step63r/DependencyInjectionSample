using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Threading;

namespace DependencyInjectionSample.Header.ViewModels
{
    public class HeaderViewModel : BindableBase
    {
        private DispatcherTimer timer;

        #region コマンド・プロパティ
        private string _userName = "John Smith";
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

        public HeaderViewModel()
        {
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

        ~HeaderViewModel()
        {
            timer.Stop();
        }
    }
}
