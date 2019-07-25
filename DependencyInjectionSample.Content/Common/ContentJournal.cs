using Prism.Regions;

namespace DependencyInjectionSample.Content.Common
{
    /// <summary>
    /// ジャーナル管理クラス
    /// </summary>
    public static class ContentJournal
    {
        public static IRegionNavigationJournal Journal { get; set; }
    }
}
