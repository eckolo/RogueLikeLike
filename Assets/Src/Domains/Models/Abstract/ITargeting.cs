namespace Assets.Src.Domains.Models.Abstract
{
    /// <summary>
    /// 何かしらを対象とするクラス全般インターフェース
    /// </summary>
    /// <typeparam name="Target">ターゲットとなるクラスの型</typeparam>
    interface ITargeting<Target>
    {
        /// <summary>
        /// 動作対象
        /// </summary>
        Target target { get; }
    }
}
