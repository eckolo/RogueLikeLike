using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Model.Value;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Src.Domain.Service
{
    /// <summary>
    /// ゲームの進行制御クラス
    /// </summary>
    public static class MainThreadManager
    {
        /// <summary>
        /// オープニング処理実施
        /// </summary>
        /// <param name="_foundation">現在のゲーム基盤</param>
        /// <returns>実行後のゲーム基盤</returns>
        public static IGameFoundation ExecuteOpening(this IGameFoundation _foundation)
        {
            //TODO 現在は仮のテスト処理なので正式なOP構築する
            var foundation = _foundation.Duplicate();
            var areaStationery = foundation.methods.areaRepository.GetContests("test");
            var area = new Area(areaStationery);
            foundation.areaList.Add(area);
            return foundation;
        }

        /// <summary>
        /// ターン毎の処理実施
        /// </summary>
        /// <param name="_foundation">現在のゲーム基盤</param>
        /// <returns>実行後のゲーム基盤</returns>
        public static IGameFoundation ExecuteTurnByTurn(this IGameFoundation _foundation)
        {
            var foundation = _foundation.Duplicate();
            var actor = foundation.nowNpcList.CalcNextActNpc();
            var selectedAction = actor.DetermineAction(foundation.nowState);
            var happenedList = foundation.nowState.GenerateHappenedList(actor, selectedAction);

            foundation.nowState = foundation.nowState.ReflectHappenedList(happenedList);

            foundation.nowState = foundation.nowState.SetupNextMap();
            foundation.nowState = foundation.nowState.CalcInitiativeTurnEnd(actor);

            foundation.nowState = foundation.nowState.ReflectView(foundation.methods.viewer);
            return foundation;
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