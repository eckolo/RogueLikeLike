using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using NUnit.Framework;
public static partial class TEST
{
    /// <summary>
    /// <see cref="Npc.Parameters"/>のテスト
    /// </summary>
    public static class NpcParametersTest
    {
        static NpcStationery.Parameters parametersStationery = new NpcStationery.Parameters(
              maxHp: Default.NpcMock.MAX_HP,
              maxEnergy: Default.NpcMock.MAX_ENERGY,
              maxMental: Default.NpcMock.MAX_MENTAL,
              physicalAttack: Default.NpcMock.PHYSICAL_ATTACK,
              physicalDefense: Default.NpcMock.PHYSICAL_DEFENSE,
              magicAttack: Default.NpcMock.MAGIC_ATTACK,
              magicDefense: Default.NpcMock.MAGIC_DEFENSE,
              accuracy: Default.NpcMock.ACCURACY,
              evasion: Default.NpcMock.EVASION,
              speed: Default.NpcMock.SPEED);
        static Npc.Parameters parameters = new Npc.Parameters(
              nowHp: Default.NpcMock.MAX_HP,
              nowEnergy: Default.NpcMock.MAX_ENERGY,
              nowMental: Default.NpcMock.MAX_MENTAL,
              maxHp: Default.NpcMock.MAX_HP,
              maxEnergy: Default.NpcMock.MAX_ENERGY,
              maxMental: Default.NpcMock.MAX_MENTAL,
              physicalAttack: Default.NpcMock.PHYSICAL_ATTACK,
              physicalDefense: Default.NpcMock.PHYSICAL_DEFENSE,
              magicAttack: Default.NpcMock.MAGIC_ATTACK,
              magicDefense: Default.NpcMock.MAGIC_DEFENSE,
              accuracy: Default.NpcMock.ACCURACY,
              evasion: Default.NpcMock.EVASION,
              speed: Default.NpcMock.SPEED);

        [Test]
        public static void AddTest1()
        {
            var result = parameters + parametersStationery;

            Assert.AreEqual(result.nowHp, parameters.nowHp);
            Assert.AreEqual(result.nowEnergy, parameters.nowEnergy);
            Assert.AreEqual(result.nowMental, parameters.nowMental);
            Assert.AreEqual(result.maxHp, parameters.maxHp + parametersStationery.maxHp);
            Assert.AreEqual(result.maxEnergy, parameters.maxEnergy + parametersStationery.maxEnergy);
            Assert.AreEqual(result.maxMental, parameters.maxMental + parametersStationery.maxMental);
            Assert.AreEqual(result.physicalAttack, parameters.physicalAttack + parametersStationery.physicalAttack);
            Assert.AreEqual(result.physicalDefense, parameters.physicalDefense + parametersStationery.physicalDefense);
            Assert.AreEqual(result.magicAttack, parameters.magicAttack + parametersStationery.magicAttack);
            Assert.AreEqual(result.magicDefense, parameters.magicDefense + parametersStationery.magicDefense);
            Assert.AreEqual(result.accuracy, parameters.accuracy + parametersStationery.accuracy);
            Assert.AreEqual(result.evasion, parameters.evasion + parametersStationery.evasion);
            Assert.AreEqual(result.speed, parameters.speed + parametersStationery.speed);
        }

        [Test]
        public static void AddTest2()
        {
            var result = parametersStationery + parameters;

            Assert.AreEqual(result.nowHp, parameters.nowHp);
            Assert.AreEqual(result.nowEnergy, parameters.nowEnergy);
            Assert.AreEqual(result.nowMental, parameters.nowMental);
            Assert.AreEqual(result.maxHp, parameters.maxHp + parametersStationery.maxHp);
            Assert.AreEqual(result.maxEnergy, parameters.maxEnergy + parametersStationery.maxEnergy);
            Assert.AreEqual(result.maxMental, parameters.maxMental + parametersStationery.maxMental);
            Assert.AreEqual(result.physicalAttack, parameters.physicalAttack + parametersStationery.physicalAttack);
            Assert.AreEqual(result.physicalDefense, parameters.physicalDefense + parametersStationery.physicalDefense);
            Assert.AreEqual(result.magicAttack, parameters.magicAttack + parametersStationery.magicAttack);
            Assert.AreEqual(result.magicDefense, parameters.magicDefense + parametersStationery.magicDefense);
            Assert.AreEqual(result.accuracy, parameters.accuracy + parametersStationery.accuracy);
            Assert.AreEqual(result.evasion, parameters.evasion + parametersStationery.evasion);
            Assert.AreEqual(result.speed, parameters.speed + parametersStationery.speed);
        }
    }
}
