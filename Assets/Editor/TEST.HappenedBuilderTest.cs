using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Service;
using NUnit.Framework;
using System.Linq;
using UnityEngine;

public static partial class TEST
{
    /// <summary>
    /// <see cref="Happened"/>クラスのビルダーの動作テスト
    /// </summary>
    public static class HappenedBuilderTest
    {
        [Test]
        public static void BuildTest()
        {
            var happened = Happened.builder.Build();

            Assert.IsNotNull(happened);

            Assert.IsNull(happened.target);

            Assert.IsNotNull(happened.variation);
            Assert.AreSame(Npc.Parameters.zero, happened.variation);

            Assert.IsNotNull(happened.ailmentAmount);
            Assert.IsFalse(happened.ailmentAmount.Any());

            Assert.IsNotNull(happened.ailmentDuration);
            Assert.IsFalse(happened.ailmentDuration.Any());

            Assert.AreEqual(Vector2.zero, happened.movement);

            Assert.IsNull(happened.animation);
        }
        [Test]
        public static void BuildTest2()
        {
            var speed = 4;
            var vector = new Vector2(1, 5);

            var happened = Happened.builder
                .Target(Mocks.NpcMock.GetSpeedMock(speed))
                .Variation(new Npc.Parameters(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, speed: speed))
                .AilmentAmount(new System.Collections.Generic.Dictionary<Ailment, int> { { new Ailment(), 0 } })
                .AilmentDuration(new System.Collections.Generic.Dictionary<Ailment, int> { { new Ailment(), 0 } })
                .Movement(vector)
                .Animation(new EffectAnimation())
                .Build();

            Assert.IsNotNull(happened);

            Assert.IsNotNull(happened.target);
            Assert.AreEqual(speed, happened.target.parameters.speed);

            Assert.IsNotNull(happened.variation);
            Assert.AreEqual(speed, happened.variation.speed);

            Assert.IsNotNull(happened.ailmentAmount);
            Assert.IsTrue(happened.ailmentAmount.Any());
            Assert.NotNull(happened.ailmentAmount.First().Key);
            Assert.AreEqual(0, happened.ailmentAmount.First().Value);

            Assert.IsNotNull(happened.ailmentDuration);
            Assert.IsTrue(happened.ailmentDuration.Any());
            Assert.NotNull(happened.ailmentDuration.First().Key);
            Assert.AreEqual(0, happened.ailmentDuration.First().Value);

            Assert.AreEqual(vector, happened.movement);

            Assert.IsNotNull(happened.animation);
        }
        [Test]
        public static void BuildNullTest()
        {
            var happened = Happened.builder
                .Target(null)
                .Variation(null)
                .AilmentAmount(null)
                .AilmentDuration(null)
                .Animation(null)
                .Build();

            Assert.IsNotNull(happened);
            Assert.IsNull(happened.target);
            Assert.IsNull(happened.variation);
            Assert.IsNull(happened.ailmentAmount);
            Assert.IsNull(happened.ailmentDuration);
            Assert.IsNull(happened.animation);
        }
        [Test]
        public static void BuildNullTest2()
        {
            var happened = Happened.builder
                .AilmentDuration(null)
                .Build();

            Assert.IsNotNull(happened);
            Assert.IsNull(happened.ailmentAmount);
            Assert.IsNull(happened.ailmentDuration);
        }
    }
}
