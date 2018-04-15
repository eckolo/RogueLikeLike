using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Service.Factory;
using System;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// エリア関連の制御クラス
    /// </summary>
    public static partial class AreaManager
    {
        /// <summary>
        /// 現在の状態と移動方角から次のマップを生成し、現在のマップ状態を更新する
        /// </summary>
        /// <param name="states">現在のゲーム状態</param>
        /// <param name="destinationDirection">移動方向</param>
        /// <returns>次のマップ状態</returns>
        public static IGameStates SetupNextMap(this IGameStates states, Direction? destinationDirection = null)
        {
            var nextCoordinate = states.mapCondition + destinationDirection.ToVector();
            states.map = states.area.GenerateMap(nextCoordinate);
            return states;
        }

        /// <summary>
        /// マップとアクションとアクション主語を受け取りアクション後のマップ状態を返す
        /// </summary>
        /// <param name="beforeMap">アクション実行前のマップ状態</param>
        /// <param name="action">アクション内容</param>
        /// <returns>アクション実施後マップオブジェクト</returns>
        public static Map UpdateMap(this Map beforeMap, Happened action)
        {
            throw new NotImplementedException();
        }
    }
}
