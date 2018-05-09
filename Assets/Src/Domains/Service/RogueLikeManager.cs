using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
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
        public static IGameFoundation PerformTurnByTurn(this IGameFoundation _found)
        {
            var found = _found.Duplicate();
            var actor = found.nowNpcList.CalcNextActNpc();
            var selectedAction = actor.DetermineAction(found.nowState);
            var happenedList = found.nowState.GenerateHappenedList(actor, selectedAction);

            found.nowState = found.nowState.ReflectHappenedList(happenedList);

            found.nowState = found.nowState.SetupNextMap();
            found.nowState = found.nowState.CalcInitiativeTurnEnd(actor);

            found.nowState = found.nowState.ReflectView(found.methods.viewer);
            return found;
        }

        /// <summary>
        /// 処理リストをゲーム状態へ反映させる
        /// </summary>
        /// <param name="_state">現在のゲーム状態</param>
        /// <returns>反映後のゲーム状態</returns>
        static GameState ReflectHappenedList(this GameState _state, List<Happened> happenedList)
        {
            var state = _state.Duplicate();
            foreach(var happened in happenedList) state = state.ProcessActually(happened);
            return state;
        }

        /// <summary>
        /// 描画待ちキューとマップ状態の反映処理
        /// </summary>
        /// <param name="_state">現在のゲーム状態</param>
        /// <returns>実行後のゲーム状態</returns>
        static GameState ReflectView(this GameState _state, IViewManager viewer)
        {
            var states = _state.Duplicate();
            if(states.viewQueue.Any())
            {
                var success = viewer.ReflectAction(states.viewQueue.Dequeue());
                if(!success) throw new Exception("Drawing view queue process failed.");
                return states.ReflectView(viewer);
            }
            else
            {
                var success = viewer.ReflectMap(states.map);
                if(!success) throw new Exception($"Drawing map process failed.");
                return states;
            }
        }
    }
}
