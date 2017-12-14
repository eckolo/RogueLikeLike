using Assets.Src.Models;
using Assets.Src.Models.Area;
using Assets.Src.Models.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Domains
{
    /// <summary>
    /// エリア関連の制御クラス
    /// </summary>
    public static class AreaManager
    {
        /// <summary>
        /// 現在の状態と移動方角から次のマップを生成する
        /// </summary>
        /// <param name="states">現在の状態</param>
        /// <param name="destinationDirection">移動方向</param>
        /// <returns>次のマップ状態</returns>
        public static Map SetupNextMap(this GameStates states, Direction destinationDirection = Direction.NORTH)
        {
            var nextMap = states.map != null ? states.map.Duplicate() : new Map();
            states.methods.viewer.ReflectMap(nextMap, destinationDirection);
            return nextMap;
        }
        /// <summary>
        /// マップとアクションとアクション主語を受け取りアクション後のマップ状態を返す
        /// </summary>
        /// <param name="beforeMap">アクション実行前のマップ状態</param>
        /// <param name="action">アクション主語とアクション内容のペアオブジェクト</param>
        /// <returns>アクション実施後マップオブジェクト</returns>
        public static Map UpdateMap(this Map beforeMap, KeyValuePair<Npc, PersonBehavior> action)
        {
            return beforeMap.Duplicate();
        }
    }
}
