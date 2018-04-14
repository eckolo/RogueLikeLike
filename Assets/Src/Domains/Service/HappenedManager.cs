using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using System;
using System.Collections.Generic;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// アクション関連の制御に関するサービス
    /// </summary>
    public static class HappenedManager
    {
        /// <summary>
        /// 各行動の実処理関数
        /// </summary>
        /// <param name="states">現在のゲーム状態</param>
        /// <param name="happened">行動内容</param>
        /// <returns>行動結果を反映したゲーム状態</returns>
        public static IGameStates ProcessActually(this IGameStates states, Happened happened)
        {
            var result = happened.Predicate(states);
            result.viewQueue.Enqueue(happened);
            return result;
        }

        /// <summary>
        /// 起点となるNPC、アビリティからそのターンの行動リストを生成する
        /// </summary>
        /// <param name="states">現在のゲーム状態</param>
        /// <param name="action">起点となる行動内容</param>
        /// <returns>ターン内行動リスト</returns>
        public static List<Happened> GenerateHappenedList(this IGameStates states, ActionPattern action)
        {
            throw new NotImplementedException();
        }
    }
}
