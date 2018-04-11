using Assets.Src.Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
        /// <returns>実行後のゲーム状態</returns>
        public static IGameStates PerformTurnByTurn(this IGameStates states)
        {
            states.actor = states.actor.CalcNextActNpc(states.npcList);
            var firstAction = states.actor.DetermineAction(states);
            var happenedList = states.GenerateHappenedList(firstAction);

            states = states.ReflectHappenedList(happenedList);
            states.map = states.SetupNextMap();

            states = states.ReflectViewQueue();
            states.methods.viewer.ReflectMap(states.map);
            return states;
        }

        /// <summary>
        /// 処理リストをゲーム状態へ反映させる
        /// </summary>
        /// <param name="_states">現在のゲーム状態</param>
        /// <returns>反映後のゲーム状態</returns>
        static IGameStates ReflectHappenedList(this IGameStates _states, List<Happened> happenedList)
        {
            var states = _states.Duplicate();
            foreach(var happened in happenedList) states = states.ProcessActually(happened);
            return states;
        }

        /// <summary>
        /// 描画待ちキューの反映処理
        /// </summary>
        /// <param name="_states">現在のゲーム状態</param>
        /// <returns>実行後のゲーム状態</returns>
        static IGameStates ReflectViewQueue(this IGameStates _states)
        {
            var states = _states.Duplicate();
            if(!states.viewQueue.Any()) return states;
            var success = states.methods.viewer.ReflectAction(states.viewQueue.Dequeue());
            if(!success) throw new Exception("Drawing process failed.");
            return states.ReflectViewQueue();
        }
    }
}
