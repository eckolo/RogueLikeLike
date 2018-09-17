using Assets.Src.Domain.Service;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TEST.Domain.Model.Mock;
using UnityEngine;

namespace TEST.Domain.Service
{
    /// <summary>
    /// <see cref="MapManager"/>サービスのテスト
    /// </summary>
    public static class MapManagerTest
    {
        [Test]
        public static void GetNpcVectorTest()
        {
            var vector = new Vector2(12, 3.4f);
            var map = MapMock.GetNpcsMock(new List<Vector2> { vector });
            var npc = map.npcLayout.First().Value;

            var result = map.GetNpcCoordinate(npc);

            Assert.AreEqual(vector, result);
        }
        [Test]
        public static void GetNpcsDistanceTest()
        {
            var vector1 = new Vector2(12, 3.4f);
            var vector2 = new Vector2(0, -1.6f);
            var map = MapMock.GetNpcsMock(new List<Vector2> { vector1, vector2 });
            var npc1 = map.npcLayout.First().Value;
            var npc2 = map.npcLayout.Last().Value;

            var result = map.GetNpcsDistance(npc1, npc2);

            Assert.AreEqual((vector1 - vector2).magnitude, result);
        }
    }
}
