using System.Collections.Generic;
using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Service;
using UnityEngine;

public static partial class TEST
{
    /// <summary>
    /// <see cref="IGameStates">を利用するテスト用のモック
    /// </summary>
    class GameStatesMock : IGameStates
    {
        public static GameStatesMock GetNpcListMock(IEnumerable<Npc> _npcList)
            => new GameStatesMock(
                stateEntity: default(GameStateEntity),
                area: default(Area),
                map: default(Map),
                mapCondition: default(Vector2),
                npcList: _npcList);

        public GameStatesMock(GameStateEntity stateEntity, Area area, Map map, Vector2 mapCondition, IEnumerable<Npc> npcList)
        {
            this.stateEntity = stateEntity;
            this.area = area;
            this.map = map;
            this.mapCondition = mapCondition;
            _npcList = npcList;
        }

        public InjectedMethods methods
        {
            get { throw new System.NotImplementedException(); }
        }

        public GameStateEntity stateEntity
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

        public Vector2? GetCoordinate(Npc npc)
        {
            throw new System.NotImplementedException();
        }

        public Npc GetNpc(Vector2 key)
        {
            throw new System.NotImplementedException();
        }

        public IGameStates MemberwiseClonePublic() => (GameStatesMock)MemberwiseClone();
    }
}
