using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

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
        /// <param name="state">現在のゲーム状態</param>
        /// <param name="happened">行動内容</param>
        /// <returns>行動結果を反映したゲーム状態</returns>
        public static GameState ProcessActually(this GameState state, Happened happened)
        {
            var result = happened.Predicate(state);
            result.viewQueue.Enqueue(happened);
            return result;
        }

        /// <summary>
        /// 起点となるNPC、アビリティからそのターンの発生事象一覧を生成する
        /// </summary>
        /// <param name="state">現在のゲーム状態</param>
        /// <param name="actor">起点となる行動者</param>
        /// <param name="selected">行動選択内容</param>
        /// <returns>ターン内発生事象一覧</returns>
        public static List<Happened> GenerateHappenedList(this GameState state, Npc actor, Selected selected)
        {
            if(selected == null) return new List<Happened>();
            var ability = selected.ability;
            var target = selected.target;
            var direction = selected.direction;
            var movement = selected.movement;

            return ability.behaviorList
                .SelectMany(behavior => state.GenerateHappenedList(actor, behavior, target, direction, movement))
                .Concat(new List<Happened> { state.GenerateMoveHappened(actor, movement, ability.moveAnimation) })
                .ToList();
        }

        /// <summary>
        /// 指定された動作内容クラスを起点とする発生事象一覧を生成する
        /// </summary>
        /// <param name="state">現在のゲーム状態</param>
        /// <param name="actor">起点となる行動者</param>
        /// <param name="behavior">起点となる動作内容</param>
        /// <param name="targetPoint">動作目標地点</param>
        /// <param name="direction">動作方向</param>
        /// <param name="movement">行動に付随する移動量</param>
        /// <returns>発生事象一覧</returns>
        static List<Happened> GenerateHappenedList(
            this GameState state,
            Npc actor,
            Behavior behavior,
            Vector2 targetPoint,
            Direction direction,
            Vector2 movement)
        {
            var range = behavior.coverage.Move(targetPoint, direction);
            var npcs = state.npcLayout
                .Where(layout => range.OnTarget(layout.Key))
                .Select(layout => layout.Value);

            return npcs.SelectMany(npc => state.GenerateHappenedList(actor, behavior, npc)).ToList();
        }
        /// <summary>
        /// 指定された行動内容の所定の対象への作用を起点とした発生事象一覧を生成
        /// </summary>
        /// <param name="state">現在のゲーム状態</param>
        /// <param name="actor">起点となる行動者</param>
        /// <param name="behavior">起点となる動作内容</param>
        /// <param name="target">動作対象</param>
        /// <returns></returns>
        static List<Happened> GenerateHappenedList(this GameState state, Npc actor, Behavior behavior, Npc target)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 移動のみの発生事象クラスを生成
        /// </summary>
        /// <param name="state">現在のゲーム状態</param>
        /// <param name="actor">移動者</param>
        /// <param name="movement">予定移動量</param>
        /// <param name="animations">移動エフェクト</param>
        /// <returns>移動のみの発生事象クラス</returns>
        static ValueTuple<GameState, Happened> GenerateMoveHappened(
            this GameState state,
            Npc actor,
            Vector2 movement,
            List<EffectAnimation> animations)
            => Happened.builder
                .Target(actor)
                .Movement(movement.CorrectMoving(actor, state.map))
                .Animations(animations)
                .Build()
                .GenerateNextState(state);
    }
}
