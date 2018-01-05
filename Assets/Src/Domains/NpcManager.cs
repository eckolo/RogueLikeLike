using Assets.Src.Models;
using Assets.Src.Models.Abilities;
using Assets.Src.Models.Npcs;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains
{
    /// <summary>
    /// NPC系オブジェクト管理サービス
    /// </summary>
    public static class NpcManager
    {
        /// <summary>
        /// 次行動NPC決定関数
        /// </summary>
        /// <param name="npcList">存在しているNPCリスト</param>
        /// <returns>行動するNPC</returns>
        public static Npc GetNextActNpc(this List<Npc> npcList)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// スキルセット→キャラクタパラメータへの変換
        /// </summary>
        /// <param name="skills">変換元スキルセット</param>
        /// <returns>変換されたパラメータ</returns>
        public static NpcStationery.Parameters ToParameters(this List<SkillParameter> skills)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 使用アビリティ決定関数
        /// </summary>
        /// <param name="npc">使用アビリティ決定対象</param>
        /// <returns>決定されたアビリティと使用対象を定めた行動パターンオブジェクト</returns>
        public static ActionPattern DetermineAction(this Npc npc, GameStates states)
        {
            var applicable = npc.actionAlgorithm.FirstOrDefault(term => term.Judge(npc, states));
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
        static Npc GetTermedNpc(this Npc myself, GameStates states, TargetType targetType)
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

        /// <summary>
        /// 各行動の実処理関数
        /// </summary>
        /// <param name="states">現在のゲーム状態</param>
        /// <param name="happened">行動内容</param>
        /// <returns>行動結果を反映したゲーム状態</returns>
        public static GameStates ProcessActually(this GameStates states, Happened happened)
        {
            var result = happened.Predicate(states);
            result.AddHappenedLog(happened);
            return result;
        }
    }
}
