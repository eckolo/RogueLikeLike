using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
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
        public static NpcStationery.Parameters ToParameters(this Dictionary<Skill.Key, int> skills)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 使用アビリティ決定関数
        /// </summary>
        /// <param name="npc">使用アビリティ決定対象</param>
        /// <returns>決定されたアビリティと使用対象を定めた行動パターンオブジェクト</returns>
        public static ActionPattern DetermineAction(this Npc npc, IGameStates states)
        {
            var applicable = npc.actionAlgorithm
                .Where(term => term.Judge(npc, states))
                .Pick(states.seed);
            if(applicable == default(ActionTerm)) return null;

            var targetNpc = npc.GetTermedNpc(states, applicable.targetType);
            var coordinateNullable = states.GetCoordinate(targetNpc);
            var coordinate = coordinateNullable ?? Vector2.zero;
            if(coordinateNullable == null) return null;

            var ability = npc.SearchAbility(applicable.ability);
            if(ability == null) return null;

            return new ActionPattern(npc, ability, coordinate);
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
