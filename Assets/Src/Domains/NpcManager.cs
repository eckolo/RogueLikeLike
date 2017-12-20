using Assets.Src.Models;
using Assets.Src.Models.Person;
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
        /// スキルセット→キャラクタパラメータへの変換
        /// </summary>
        /// <param name="skills">変換元スキルセット</param>
        /// <returns>変換されたパラメータ</returns>
        public static PersonStationery.Parameters ToParameters(this List<SkillParameter> skills)
        {
            return default(PersonStationery.Parameters);
        }

        /// <summary>
        /// 行動決定関数
        /// </summary>
        /// <param name="person">行動決定対象</param>
        /// <returns>決定された行動</returns>
        public static PersonBehavior DetermineAction(this Npc person)
        {
            return new PersonBehavior();
        }
    }
}
