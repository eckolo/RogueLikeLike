using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TEST.Domain.Model.Mock
{
    /// <summary>
    /// <see cref="Map"/>クラスのモック
    /// </summary>
    public class MapMock : Map
    {
        public static MapMock GetNpcsMock(List<Vector2> coordinates)
            => new MapMock(coordinates.ToDictionary(cod => cod, _ => (Npc)NpcMock.GetMock()));

        MapMock(Dictionary<Vector2, Npc> _npcList)
        {
            this._npcList = _npcList;
        }

        public Dictionary<Vector2, Npc> _npcList;
        public override Dictionary<Vector2, Npc> npcLayout
        {
            get { return _npcList; }
            set { _npcList = value; }
        }
    }
}
