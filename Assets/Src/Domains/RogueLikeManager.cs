using Assets.Src.Models;
using Assets.Src.Models.Abilities;
using Assets.Src.Models.Npcs;
using System;
using System.Collections.Generic;

namespace Assets.Src.Domains
{
    /// <summary>
    /// 各種ローグライク処理統括クラス
    /// </summary>
    public static class RogueLikeManager
    {
        /// <summary>
        /// ターン毎の処理実施
        /// </summary>
        /// <param name="states">現在のゲーム状態</param>
        /// <param name="methods">インフラメソッド集合</param>
        /// <returns>内部ステータス</returns>
        public static GameStates PerformTurnByTurn(this GameStates states)
        {
            var actor = states.npcList.GetNextActNpc();
            var abilityFirst = actor.DetermineAbility();
            var happenedList = states.GenerateHappenedList(actor, abilityFirst);

            foreach(var happened in happenedList) states = states.ProcessActually(happened);

            states.map = states.SetupNextMap();
            return states;
        }

        /// <summary>
        /// 起点となるNPC、アビリティからそのターンの行動リストを生成する
        /// </summary>
        /// <param name="states">現在のゲーム状態</param>
        /// <param name="npc">起点となる行動者</param>
        /// <param name="ability">起点となるアビリティ</param>
        /// <returns>ターン内行動リスト</returns>
        static List<Happened> GenerateHappenedList(this GameStates states, Npc npc, Ability ability)
        {
            throw new NotImplementedException();
        }
    }
}
