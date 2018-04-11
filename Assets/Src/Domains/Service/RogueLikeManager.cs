using Assets.Src.Domains.Models;
using System;
using System.Collections.Generic;

namespace Assets.Src.Domains.Service
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
        /// <returns>内部ステータス</returns>
        public static IGameStates PerformTurnByTurn(this IGameStates states)
        {
            states.actor = states.actor.CalcNextActNpc(states.npcList);
            var firstAction = states.actor.DetermineAction(states);
            var happenedList = states.GenerateHappenedList(firstAction);

            foreach(var happened in happenedList) states = states.ProcessActually(happened);

            states.map = states.SetupNextMap();
            return states;
        }
    }
}
