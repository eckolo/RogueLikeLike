using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Model.Value;
using System.Collections.Generic;
using UnityEngine;

namespace TEST.Domain.Model.Mock
{
    /// <summary>
    /// <see cref="IGameFoundation">を利用するテスト用のモック
    /// </summary>
    public class GameStateMock : GameState
    {
        public static GameStateMock GetNpcListMock(IEnumerable<Npc> _npcList)
            => new GameStateMock(
                area: new Area(new AreaStationeryMock()),
                map: MapMock.GetMock(),
                mapCondition: Vector2.zero,
                npcList: _npcList,
                seed: 0);

        public GameStateMock(Area area, Map map, Vector2 mapCondition, IEnumerable<Npc> npcList, int seed)
            : base(seed)
        {
            this.area = area;
            this.map = map;
            this.area.nowMapCondition = mapCondition;
            _npcList = npcList;
        }

        readonly IEnumerable<Npc> _npcList = new List<Npc>();
        public override IEnumerable<Npc> npcList => _npcList;
    }
}
