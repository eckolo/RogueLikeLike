using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Model.Value;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Editor.TEST.Domain.Model.Mock
{
    /// <summary>
    /// <see cref="Map"/>クラスのモック
    /// </summary>
    public class MapMock : Map
    {
        public static MapMock GetMock() => new MapMock(new Dictionary<Vector2, Npc>());

        public static MapMock GetNpcsMock(List<Vector2> coordinates)
            => new MapMock(coordinates.ToDictionary(cod => cod, _ => (Npc)NpcMock.GetMock()));

        MapMock(Dictionary<Vector2, Npc> _npcList)
            : base(Vector2.zero, new MapEvent(), _npcList, new Dictionary<Vector2, MapChip>())
        {
            this._npcList = _npcList;
        }

        public Dictionary<Vector2, Npc> _npcList;
        public override Dictionary<Vector2, Npc> npcLayout => _npcList;
    }
}
