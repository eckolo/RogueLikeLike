using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// NPC系オブジェクト管理サービス
    /// </summary>
    public static class NpcManager
    {
        /// <summary>
        /// 次行動NPC決定関数
        /// </summary>
        /// <param name="previousActor">前回の行動者</param>
        /// <param name="npcList">候補NPCリスト</param>
        /// <returns>行動するNPC</returns>
        public static Npc CalcNextActNpc(this IEnumerable<Npc> npcList) => npcList
            .MaxKeys(npc => npc.nowInitiative)
            .MaxKeys(npc => npc.parameters.speed)
            .First();

        /// <summary>
        /// ターンエンド時のイニシアチブ演算
        /// </summary>
        /// <param name="_states"></param>
        /// <param name="nowActor"></param>
        /// <returns></returns>
        public static IGameStates CalcInitiativeTurnEnd(this IGameStates _states, Npc nowActor)
        {
            var states = _states.Duplicate();
            var npcList = states.npcList;
            foreach(var npc in npcList) if(npc != nowActor) npc.nowInitiative += npc.parameters.speed;
            var minInitiative = npcList.Min(npc => npc.nowInitiative);
            foreach(var npc in npcList) npc.nowInitiative -= minInitiative;
            return states;
        }

        /// <summary>
        /// スキルセット→キャラクタパラメータへの変換
        /// </summary>
        /// <param name="skills">変換元スキルセット</param>
        /// <returns>変換されたパラメータ</returns>
        public static Npc.Parameters ToParameters(this Dictionary<Skill.Key, int> skills)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 使用アビリティ決定関数
        /// </summary>
        /// <param name="actor">使用アビリティ決定対象</param>
        /// <returns>決定されたアビリティと使用対象を定めた行動パターンオブジェクト</returns>
        public static Selected DetermineAction(this Npc actor, IGameStates states)
        {
            var applicable = actor.actionAlgorithm
                .Where(term => term.Judge(actor, states))
                .Where(action => actor.SearchAbility(action.ability) != null)
                .Pick(states.seed);
            if(applicable == default(ActionTerm)) return null;

            var ability = actor.SearchAbility(applicable.ability);

            var targetNpc = actor.GetTermedNpc(states, applicable.targetType);
            var targetPoint = states.map.GetNpcCoordinate(targetNpc);

            var direction = actor.CalcTargetDirection(applicable, states.map, targetPoint, states.seed);

            var relativePoint = targetPoint - states.map.GetNpcCoordinate(actor);
            var movePolicy = applicable.moveType.CalcMovePoint(relativePoint);

            return new Selected(ability, targetPoint ?? Vector2.zero, direction, movePolicy);
        }

        /// <summary>
        /// 指定された条件に合致するNPCを取得する
        /// 該当NPCが存在しなければNullを返す
        /// </summary>
        /// <param name="myself">検索起点となるNPC</param>
        /// <param name="states">指定されたゲーム状態</param>
        /// <param name="targetType">検索条件タイプ</param>
        /// <returns>検索結果NPC</returns>
        static Npc GetTermedNpc(this Npc myself, IGameStates states, TargetType targetType)
        {
            var npcs = states.npcList;
            if(!targetType.includeMyself) npcs = npcs.Where(npc => npc != myself);
            switch(targetType.limited)
            {
                case TargetType.Limited.NONE:
                    break;
                case TargetType.Limited.FRIEND:
                    npcs = npcs.Where(npc => myself.friendship[npc] > 0);
                    break;
                case TargetType.Limited.STRANGER:
                    npcs = npcs.Where(npc => myself.friendship[npc] < 0);
                    break;
                default: throw new IndexOutOfRangeException();
            }
            switch(targetType.determination)
            {
                case TargetType.Determination.MYSELF:
                    return npcs.SingleOrDefault(npc => npc == myself);
                case TargetType.Determination.NEAR:
                    var maxDistance = states.map.size.magnitude;
                    return npcs
                        .MinKeys(npc => states.map.GetNpcsDistance(myself, npc) ?? maxDistance)
                        .Pick(states.seed);
                case TargetType.Determination.AWAY:
                    return npcs
                        .MaxKeys(npc => states.map.GetNpcsDistance(myself, npc) ?? 0)
                        .Pick(states.seed);
                case TargetType.Determination.STRONG:
                    return npcs
                        .MaxKeys(npc => npc.parameters.CalcStrong())
                        .Pick(states.seed);
                case TargetType.Determination.WEAK:
                    return npcs
                        .MinKeys(npc => npc.parameters.CalcStrong())
                        .Pick(states.seed);
                case TargetType.Determination.LIVELY:
                    return npcs
                        .MaxKeys(npc => npc.CalcLively())
                        .Pick(states.seed);
                case TargetType.Determination.WEAKENED:
                    return npcs
                        .MinKeys(npc => npc.CalcLively())
                        .Pick(states.seed);
                default: throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// アビリティ使用時の使用方向を決定する
        /// </summary>
        /// <param name="action">行動パターン</param>
        /// <param name="map">現在のマップ状態</param>
        /// <param name="_targetPoint">目標座標</param>
        /// <returns>目標座標からどの方向へ向けてアビリティを使用するか</returns>
        static Direction CalcTargetDirection(this Npc actor, ActionTerm action, Map map, Vector2? _targetPoint, UnityEngine.Random.State seed)
        {
            if(_targetPoint == null) return default(Direction);
            var targetPoint = _targetPoint ?? Vector2.zero;

            var _myself = map.GetNpcCoordinate(actor);
            if(_myself == null) return default(Direction);
            var myselfPoint = _myself ?? Vector2.zero;

            var relative = targetPoint - myselfPoint;

            var directions = new List<Direction>();
            if(Math.Abs(relative.x) <= relative.y)
            {
                if(relative.y >= 0) directions.Add(Direction.NORTH);
                if(relative.y <= 0) directions.Add(Direction.SOUTH);
            }
            if(Math.Abs(relative.y) <= relative.x)
            {
                if(relative.x >= 0) directions.Add(Direction.EAST);
                if(relative.x <= 0) directions.Add(Direction.WEST);
            }

            if(directions.Count == 1) return directions.Single();

            var targetType = action.targetType;
            var range = action.ability.behaviorList.FirstOrDefault()?.coverage;

            Func<KeyValuePair<Vector2, Npc>, bool> term = _ => true;
            switch(targetType.limited)
            {
                case TargetType.Limited.NONE:
                    break;
                case TargetType.Limited.FRIEND:
                    term = layout => actor.friendship[layout.Value] > 0;
                    break;
                case TargetType.Limited.STRANGER:
                    term = layout => actor.friendship[layout.Value] < 0;
                    break;
                default: throw new IndexOutOfRangeException();
            }

            var points = map.npcLayout
                .Where(term)
                .Where(layout => targetType.includeMyself || layout.Value != actor)
                .Select(layout => layout.Key);
            return directions
                .MaxKeys(direction => points.Count(point => range.OnTarget(point, targetPoint, direction)))
                .Pick(seed);
        }

        /// <summary>
        /// 移動方向を決定する
        /// </summary>
        /// <param name="moveType">移動方針</param>
        /// <param name="relativeTarget">目標地点の自身からの相対座標</param>
        /// <returns>移動方向</returns>
        static Vector2 CalcMovePoint(this ActionTerm.MoveType moveType, Vector2? relativeTarget)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// パラメータよりNPCの強さの基準値を算出する
        /// </summary>
        /// <param name="parameters">算出対象パラメータ</param>
        /// <returns>強さの基準値</returns>
        public static int CalcStrong(this Npc.Parameters parameters)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// NPCの「元気さ」を算出する
        /// 「元気さ」とは即ち、体力とかの変動系パラメータの残量割合の総合評価のこと
        /// </summary>
        /// <param name="npc">算出対象NPC</param>
        /// <returns>元気さを示す数値</returns>
        public static int CalcLively(this Npc npc)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// アビリティ雛形から所定のNPCが該当するアビリティを持っているか検索する
        /// 持っていなければ空値が返る
        /// </summary>
        /// <param name="myself">検索対象NPC</param>
        /// <param name="origin">検索元のアビリティ雛形</param>
        static Ability SearchAbility(this Npc myself, AbilityStationery origin)
        {
            throw new NotImplementedException();
        }
    }
}
