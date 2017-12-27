using Assets.Src.Models;
using Assets.Src.Models.Npcs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Domains
{
    /// <summary>
    /// 各種ローグライク処理統括クラス
    /// </summary>
    public static class RogueLikeManager
    {
        /// <summary>
        /// ターン毎の処理実施
        /// </summary>
        /// <param name="states">現在のゲーム状態</param>
        /// <param name="methods">インフラメソッド集合</param>
        /// <returns>内部ステータス</returns>
        public static GameStates PerformTurnByTurn(this GameStates states)
        {
            var actionNpc = states.npcList.GetNextActNpc();
            var behavior = actionNpc.DetermineBehavior();
            var behaviorList = states.GeneratePersonBehaviorList(behavior);

            foreach(var _behavior in behaviorList) states = states.ProcessBehavior(_behavior);

            states.map = states.SetupNextMap();
            return states;
        }

        /// <summary>
        /// 起点となる行動からそのターンの行動リストを生成する
        /// </summary>
        /// <param name="states">現在のゲーム状態</param>
        /// <param name="npc">起点となる行動者</param>
        /// <param name="behavior">起点となる行動</param>
        /// <returns>ターン内行動リスト</returns>
        static List<Behavior> GeneratePersonBehaviorList(this GameStates states, Behavior behavior)
        {
            throw new NotImplementedException();
        }
    }
}
