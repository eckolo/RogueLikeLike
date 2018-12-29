using Assets.Editor.TEST.Domain.Model.Mock;
using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Model.Value;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Editor.TEST.Domain.Model.Value
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

            happened.IsNotNull();

            happened.target.IsNull();

            happened.variation.IsNotNull();
            happened.variation.IsSameReferenceAs(Npc.Parameters.zero);

            happened.ailmentAmount.IsNotNull();
            happened.ailmentAmount.Any().IsFalse();

            happened.ailmentDuration.IsNotNull();
            happened.ailmentDuration.Any().IsFalse();

            happened.movement.Is(Vector2.zero);

            happened.animations.IsNotNull();
            happened.animations.Any().IsFalse();
        }
        [Test]
        public static void BuildTest2()
        {
            var speed = 4;
            var vector = new Vector2(1, 5);

            var happened = Happened.builder
                .Target(NpcMock.GetSpeedMock(speed))
                .Variation(new Npc.Parameters(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, speed: speed))
                .AilmentAmount(new Dictionary<Ailment, int> { { new Ailment(new AilmentStationeryMock()), 0 } })
                .AilmentDuration(new Dictionary<Ailment, int> { { new Ailment(new AilmentStationeryMock()), 1 } })
                .Movement(vector)
                .Animations(new List<EffectAnimation> { new EffectAnimation() })
                .Build();

            happened.IsNotNull();

            happened.target.IsNotNull();
            happened.target.parameters.IsNotNull();
            happened.target.parameters.speed.Is(speed);

            happened.variation.IsNotNull();
            happened.variation.speed.Is(speed);

            happened.ailmentAmount.IsNotNull();
            happened.ailmentAmount.Count().Is(1);
            happened.ailmentAmount.First().Key.IsNotNull();
            happened.ailmentAmount.First().Value.Is(0);

            happened.ailmentDuration.IsNotNull();
            happened.ailmentDuration.Count().Is(1);
            happened.ailmentDuration.First().Key.IsNotNull();
            happened.ailmentDuration.First().Value.Is(1);

            happened.movement.Is(vector);

            happened.animations.IsNotNull();
            happened.animations.Count().Is(1);
        }
        [Test]
        public static void BuildNullTest()
        {
            var happened = Happened.builder
                .Target(null)
                .Variation(null)
                .AilmentAmount(null)
                .AilmentDuration(null)
                .Animations(null)
                .Build();

            happened.IsNotNull();
            happened.target.IsNull();
            happened.variation.IsNull();
            happened.ailmentAmount.IsNull();
            happened.ailmentDuration.IsNull();
            happened.animations.IsNull();
        }
        [Test]
        public static void BuildNullTest2()
        {
            var happened = Happened.builder
                .AilmentDuration(null)
                .Build();

            happened.IsNotNull();
            happened.ailmentAmount.IsNull();
            happened.ailmentDuration.IsNull();
        }
    }
}
