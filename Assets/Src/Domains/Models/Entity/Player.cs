using System;
using System.Collections.Generic;
using Assets.Src.Domains.Models.Value;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// プレイヤーオブジェクト
    /// 操作可能という意味なので、複数あったり存在しなくてもよい
    /// </summary>
    [Serializable]
    public class Player : Npc
    {
        public Player(NpcStationery stationery, List<Adjective> adjectives, Friendship friendship = null, Parameters parametersAdjust = null, int? nowHp = null, int? nowEnergy = null, int? nowMental = null, int? nowInitiative = null, IEnumerable<Ailment.Stationery> statusAilmentList = null) : base(stationery, adjectives, friendship, parametersAdjust, nowHp, nowEnergy, nowMental, nowInitiative, statusAilmentList)
        {
        }
    }
}
