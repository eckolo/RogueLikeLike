using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using System;
using System.Collections.Generic;
using System.Linq;

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
        /// <param name="actor">起点となる行動者</param>
        /// <param name="selected">行動選択内容</param>
        /// <returns>ターン内行動リスト</returns>
        public static List<Happened> GenerateHappenedList(this IGameStates states, Npc actor, Selected selected)
        {
            if(selected == null) return new List<Happened>();
            var ability = selected.ability;
            var target = selected.target;
            var direction = selected.direction;
            var movement = selected.movement;

            return ability.behaviorList
                .Select(behavior => new Happened(actor, behavior, target, direction, movement))
                .ToList();
        }
    }
}
