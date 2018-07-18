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
              nowHp: Default.NpcMock.NOW_HP,
              nowEnergy: Default.NpcMock.NOW_ENERGY,
              nowMental: Default.NpcMock.NOW_MENTAL,
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
        public static void InnerProductTest()
        {
            var result = parametersStationery + parameters;

            Assert.AreEqual(result.innerProduct, parameters.nowHp + parameters.nowEnergy + parameters.nowMental
                + parameters.maxHp + parametersStationery.maxHp
                + parameters.maxEnergy + parametersStationery.maxEnergy
                + parameters.maxMental + parametersStationery.maxMental
                + parameters.physicalAttack + parametersStationery.physicalAttack
                + parameters.physicalDefense + parametersStationery.physicalDefense
                + parameters.magicAttack + parametersStationery.magicAttack
                + parameters.magicDefense + parametersStationery.magicDefense
                + parameters.accuracy + parametersStationery.accuracy
                + parameters.evasion + parametersStationery.evasion
                + parameters.speed + parametersStationery.speed);
        }

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

        [Test]
        public static void MultiplyTest1()
        {
            var result = parameters * parametersStationery;

            Assert.AreEqual(result.nowHp, 0);
            Assert.AreEqual(result.nowEnergy, 0);
            Assert.AreEqual(result.nowMental, 0);
            Assert.AreEqual(result.maxHp, parameters.maxHp * parametersStationery.maxHp);
            Assert.AreEqual(result.maxEnergy, parameters.maxEnergy * parametersStationery.maxEnergy);
            Assert.AreEqual(result.maxMental, parameters.maxMental * parametersStationery.maxMental);
            Assert.AreEqual(result.physicalAttack, parameters.physicalAttack * parametersStationery.physicalAttack);
            Assert.AreEqual(result.physicalDefense, parameters.physicalDefense * parametersStationery.physicalDefense);
            Assert.AreEqual(result.magicAttack, parameters.magicAttack * parametersStationery.magicAttack);
            Assert.AreEqual(result.magicDefense, parameters.magicDefense * parametersStationery.magicDefense);
            Assert.AreEqual(result.accuracy, parameters.accuracy * parametersStationery.accuracy);
            Assert.AreEqual(result.evasion, parameters.evasion * parametersStationery.evasion);
            Assert.AreEqual(result.speed, parameters.speed * parametersStationery.speed);
        }

        [Test]
        public static void MultiplyTest2()
        {
            var result = parametersStationery * parameters;

            Assert.AreEqual(result.nowHp, 0);
            Assert.AreEqual(result.nowEnergy, 0);
            Assert.AreEqual(result.nowMental, 0);
            Assert.AreEqual(result.maxHp, parameters.maxHp * parametersStationery.maxHp);
            Assert.AreEqual(result.maxEnergy, parameters.maxEnergy * parametersStationery.maxEnergy);
            Assert.AreEqual(result.maxMental, parameters.maxMental * parametersStationery.maxMental);
            Assert.AreEqual(result.physicalAttack, parameters.physicalAttack * parametersStationery.physicalAttack);
            Assert.AreEqual(result.physicalDefense, parameters.physicalDefense * parametersStationery.physicalDefense);
            Assert.AreEqual(result.magicAttack, parameters.magicAttack * parametersStationery.magicAttack);
            Assert.AreEqual(result.magicDefense, parameters.magicDefense * parametersStationery.magicDefense);
            Assert.AreEqual(result.accuracy, parameters.accuracy * parametersStationery.accuracy);
            Assert.AreEqual(result.evasion, parameters.evasion * parametersStationery.evasion);
            Assert.AreEqual(result.speed, parameters.speed * parametersStationery.speed);
        }

        [Test]
        public static void IndexerTest1()
        {
            Assert.AreEqual(parametersStationery[ParameterType.NOW_HP], Default.NpcMock.MAX_HP);
            Assert.AreEqual(parametersStationery[ParameterType.NOW_ENERGY], Default.NpcMock.MAX_ENERGY);
            Assert.AreEqual(parametersStationery[ParameterType.NOW_MENTAL], Default.NpcMock.MAX_MENTAL);
            Assert.AreEqual(parametersStationery[ParameterType.MAX_HP], Default.NpcMock.MAX_HP);
            Assert.AreEqual(parametersStationery[ParameterType.MAX_ENERGY], Default.NpcMock.MAX_ENERGY);
            Assert.AreEqual(parametersStationery[ParameterType.MAX_MENTAL], Default.NpcMock.MAX_MENTAL);
            Assert.AreEqual(parametersStationery[ParameterType.PHYSICAL_ATTACK], Default.NpcMock.PHYSICAL_ATTACK);
            Assert.AreEqual(parametersStationery[ParameterType.PHYSICAL_DEFENSE], Default.NpcMock.PHYSICAL_DEFENSE);
            Assert.AreEqual(parametersStationery[ParameterType.MAGIC_ATTACK], Default.NpcMock.MAGIC_ATTACK);
            Assert.AreEqual(parametersStationery[ParameterType.MAGIC_DEFENSE], Default.NpcMock.MAGIC_DEFENSE);
            Assert.AreEqual(parametersStationery[ParameterType.ACCURACY], Default.NpcMock.ACCURACY);
            Assert.AreEqual(parametersStationery[ParameterType.EVASION], Default.NpcMock.EVASION);
            Assert.AreEqual(parametersStationery[ParameterType.SPEED], Default.NpcMock.SPEED);
        }

        [Test]
        public static void IndexerTest2()
        {
            Assert.AreEqual(parameters[ParameterType.NOW_HP], Default.NpcMock.NOW_HP);
            Assert.AreEqual(parameters[ParameterType.NOW_ENERGY], Default.NpcMock.NOW_ENERGY);
            Assert.AreEqual(parameters[ParameterType.NOW_MENTAL], Default.NpcMock.NOW_MENTAL);
            Assert.AreEqual(parameters[ParameterType.MAX_HP], Default.NpcMock.MAX_HP);
            Assert.AreEqual(parameters[ParameterType.MAX_ENERGY], Default.NpcMock.MAX_ENERGY);
            Assert.AreEqual(parameters[ParameterType.MAX_MENTAL], Default.NpcMock.MAX_MENTAL);
            Assert.AreEqual(parameters[ParameterType.PHYSICAL_ATTACK], Default.NpcMock.PHYSICAL_ATTACK);
            Assert.AreEqual(parameters[ParameterType.PHYSICAL_DEFENSE], Default.NpcMock.PHYSICAL_DEFENSE);
            Assert.AreEqual(parameters[ParameterType.MAGIC_ATTACK], Default.NpcMock.MAGIC_ATTACK);
            Assert.AreEqual(parameters[ParameterType.MAGIC_DEFENSE], Default.NpcMock.MAGIC_DEFENSE);
            Assert.AreEqual(parameters[ParameterType.ACCURACY], Default.NpcMock.ACCURACY);
            Assert.AreEqual(parameters[ParameterType.EVASION], Default.NpcMock.EVASION);
            Assert.AreEqual(parameters[ParameterType.SPEED], Default.NpcMock.SPEED);
        }
    }
}
