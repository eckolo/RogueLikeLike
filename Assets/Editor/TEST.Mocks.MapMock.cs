using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static partial class TEST
{
    partial class Mocks
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
            public override Dictionary<Vector2, Npc> npcList
            {
                get { return _npcList; }
                set { _npcList = value; }
            }
        }
    }
}
