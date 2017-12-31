using Assets.Src.Models;
using Assets.Src.Models.Behaviors;
using Assets.Src.Models.Npcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// 行動決定関数
        /// </summary>
        /// <param name="person">行動決定対象</param>
        /// <returns>決定された行動</returns>
        public static Behavior DetermineBehavior(this Npc person)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 各行動の実処理関数
        /// </summary>
        /// <param name="states">現在のゲーム状態</param>
        /// <param name="behavior">行動内容</param>
        /// <returns>行動結果を反映したゲーム状態</returns>
        public static GameStates ProcessBehavior(this GameStates states, Behavior behavior)
        {

            var result = behavior.Predicate(states);
            result.AddBehaviorLog(behavior);
            return result;
        }
    }
}
