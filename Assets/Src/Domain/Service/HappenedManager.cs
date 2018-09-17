using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Model.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domain.Service
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
        public static List<Happened> GenerateHappenedList(this GameState _state, Npc actor, Selected selected)
        {
            if(selected == null) return new List<Happened>();
            var state = _state.DuplicateFull();

            var ability = selected.ability;
            var target = selected.target;
            var direction = selected.direction;
            var movement = selected.movement;
            var happendList = new List<Happened>();

            foreach(var behavior in ability.behaviorList)
            {
                var stateHappend = state.GenerateHappenedList(actor, behavior, target, direction, movement);
                state = stateHappend.Item1;
                happendList = happendList.Concat(stateHappend.Item2).ToList();
            }

            var moveStateHappend = state.GenerateMoveHappened(actor, movement, ability.moveAnimations);
            state = moveStateHappend.Item1;
            happendList = happendList.Concat(new List<Happened> { moveStateHappend.Item2 }).ToList();

            return happendList;
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
        static ValueTuple<GameState, List<Happened>> GenerateHappenedList(
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
            var happendList = new List<Happened>();

            foreach(var target in npcs)
            {
                var stateHappend = state.GenerateHappenedList(actor, behavior, target, targetPoint);
                state = stateHappend.Item1;
                happendList = happendList.Concat(stateHappend.Item2).ToList();
            }

            return new ValueTuple<GameState, List<Happened>>(state, happendList);
        }
        /// <summary>
        /// 指定された行動内容の所定の対象への作用を起点とした発生事象一覧を生成
        /// </summary>
        /// <param name="state">現在のゲーム状態</param>
        /// <param name="actor">起点となる行動者</param>
        /// <param name="behavior">起点となる動作内容</param>
        /// <param name="target">動作対象</param>
        /// <returns></returns>
        static ValueTuple<GameState, List<Happened>> GenerateHappenedList(
            this GameState state,
            Npc actor,
            Behavior behavior,
            Npc target,
            Vector2 center)
        {
            var variation = behavior.ToVariation(actor: actor, target: target);
            var movement = (state.map.GetNpcCoordinate(target) ?? center - center).normalized * behavior.blowing;

            var result = Happened.builder
                  .Target(target)
                  .Variation(variation)
                  .AilmentAmount(behavior.ailmentAmount)
                  .AilmentDuration(behavior.ailmentDuration)
                  .Movement(movement)
                  .Animations(behavior.animations)
                  .Build();
            return new ValueTuple<GameState, List<Happened>>(result.Predicate(state), new List<Happened> { result });
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

        /// <summary>
        /// ゲーム状態と発生事象から事象発生後の状態と発生事象のセットを生成する
        /// </summary>
        /// <param name="happened">発生事象</param>
        /// <param name="state">元となるゲーム状態</param>
        /// <returns>事象発生後のゲーム状態と発生事象のセット</returns>
        public static ValueTuple<GameState, Happened> GenerateNextState(this Happened happened, GameState state)
            => new ValueTuple<GameState, Happened>(happened.Predicate(state), happened);
    }
}
