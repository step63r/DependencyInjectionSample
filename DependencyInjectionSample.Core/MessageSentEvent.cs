using Prism.Events;

namespace DependencyInjectionSample.Core
{
    /// <summary>
    /// 文字列型のパラメータを送受信するイベントクラス
    /// </summary>
    public class MessageSentEvent : PubSubEvent<string>
    {

    }
}
