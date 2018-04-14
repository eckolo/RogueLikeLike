using Assets.Src.Domains.Models.Value;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// 画面表示系操作インフラのインターフェース
    /// </summary>
    public interface IViewManager
    {
        /// <summary>
        /// 現在のマップ状況を画面に反映する
        /// </summary>
        /// <param name="map">反映元マップデータ</param>
        /// <param name="topDirection">画面上方向の方角</param>
        /// <returns>更新処理成否</returns>
        bool ReflectMap(Map map, Direction topDirection = Direction.NORTH);
        /// <summary>
        /// キャラクターのアクションを画面に反映する
        /// </summary>
        /// <param name="happened">アクション内容</param>
        /// <returns>描画処理成否</returns>
        bool ReflectAction(Happened happened);
        /// <summary>
        /// エフェクトアクション描画関数
        /// </summary>
        /// <param name="effect">動作対象エフェクト</param>
        /// <returns>描画処理成否</returns>
        bool OperateEffect(EffectAnimation effect);
    }
}
