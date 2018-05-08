using System.Collections.Generic;
using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Service;
using UnityEngine;

public static partial class TEST
{
    /// <summary>
    /// <see cref="IGameFoundation">を利用するテスト用のモック
    /// </summary>
    class GameFoundationMock : IGameFoundation
    {
        public static GameFoundationMock GetNpcListMock(IEnumerable<Npc> _npcList)
            => new GameFoundationMock(
                state: default(GameState),
                area: default(Area),
                map: default(Map),
                mapCondition: default(Vector2),
                npcList: _npcList);

        public GameFoundationMock(GameState state, Area area, Map map, Vector2 mapCondition, IEnumerable<Npc> npcList)
        {
            this.state = state;
            this.area = area;
            this.map = map;
            this.mapCondition = mapCondition;
            _npcList = npcList;
        }

        public InjectedMethods methods
        {
            get { throw new System.NotImplementedException(); }
        }

        public GameState state
        {
            get { throw new System.NotImplementedException(); }
            set { }
        }

        public Queue<Happened> viewQueue
        {
            get { throw new System.NotImplementedException(); }
        }

        public List<Area> areaList
        {
            get { throw new System.NotImplementedException(); }
        }

        public Area area
        {
            get { throw new System.NotImplementedException(); }
            set { }
        }
        public Map map
        {
            get { throw new System.NotImplementedException(); }
            set { }
        }
        public Vector2 mapCondition
        {
            get { throw new System.NotImplementedException(); }
            set { }
        }

        IEnumerable<Npc> _npcList = new List<Npc>();
        public IEnumerable<Npc> npcList => _npcList;

        public Random.State seed
        {
            get {
                throw new System.NotImplementedException();
            }
        }

        public Vector2? GetCoordinate(Npc npc)
        {
            throw new System.NotImplementedException();
        }

        public Npc GetNpc(Vector2 key)
        {
            throw new System.NotImplementedException();
        }

        public IGameFoundation MemberwiseClonePublic() => (GameFoundationMock)MemberwiseClone();
    }
}
