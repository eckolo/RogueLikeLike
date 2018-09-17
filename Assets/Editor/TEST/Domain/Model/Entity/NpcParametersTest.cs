using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using NUnit.Framework;
using TEST.Domain.Model.Mock;

namespace TEST.Domain.Model.Entity
{
    /// <summary>
    /// <see cref="Npc.Parameters"/>のテスト
    /// </summary>
    public static class NpcParametersTest
    {
        static NpcStationery.Parameters parametersStationery = new NpcStationery.Parameters(
              maxHp: NpcParametersMock.MAX_HP,
              maxEnergy: NpcParametersMock.MAX_ENERGY,
              maxMental: NpcParametersMock.MAX_MENTAL,
              physicalAttack: NpcParametersMock.PHYSICAL_ATTACK,
              physicalDefense: NpcParametersMock.PHYSICAL_DEFENSE,
              magicAttack: NpcParametersMock.MAGIC_ATTACK,
              magicDefense: NpcParametersMock.MAGIC_DEFENSE,
              accuracy: NpcParametersMock.ACCURACY,
              evasion: NpcParametersMock.EVASION,
              speed: NpcParametersMock.SPEED);
        static Npc.Parameters parameters = new Npc.Parameters(
              nowHp: NpcParametersMock.NOW_HP,
              nowEnergy: NpcParametersMock.NOW_ENERGY,
              nowMental: NpcParametersMock.NOW_MENTAL,
              maxHp: NpcParametersMock.MAX_HP,
              maxEnergy: NpcParametersMock.MAX_ENERGY,
              maxMental: NpcParametersMock.MAX_MENTAL,
              physicalAttack: NpcParametersMock.PHYSICAL_ATTACK,
              physicalDefense: NpcParametersMock.PHYSICAL_DEFENSE,
              magicAttack: NpcParametersMock.MAGIC_ATTACK,
              magicDefense: NpcParametersMock.MAGIC_DEFENSE,
              accuracy: NpcParametersMock.ACCURACY,
              evasion: NpcParametersMock.EVASION,
              speed: NpcParametersMock.SPEED);

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
            Assert.AreEqual(parametersStationery[ParameterType.NOW_HP], NpcParametersMock.MAX_HP);
            Assert.AreEqual(parametersStationery[ParameterType.NOW_ENERGY], NpcParametersMock.MAX_ENERGY);
            Assert.AreEqual(parametersStationery[ParameterType.NOW_MENTAL], NpcParametersMock.MAX_MENTAL);
            Assert.AreEqual(parametersStationery[ParameterType.MAX_HP], NpcParametersMock.MAX_HP);
            Assert.AreEqual(parametersStationery[ParameterType.MAX_ENERGY], NpcParametersMock.MAX_ENERGY);
            Assert.AreEqual(parametersStationery[ParameterType.MAX_MENTAL], NpcParametersMock.MAX_MENTAL);
            Assert.AreEqual(parametersStationery[ParameterType.PHYSICAL_ATTACK], NpcParametersMock.PHYSICAL_ATTACK);
            Assert.AreEqual(parametersStationery[ParameterType.PHYSICAL_DEFENSE], NpcParametersMock.PHYSICAL_DEFENSE);
            Assert.AreEqual(parametersStationery[ParameterType.MAGIC_ATTACK], NpcParametersMock.MAGIC_ATTACK);
            Assert.AreEqual(parametersStationery[ParameterType.MAGIC_DEFENSE], NpcParametersMock.MAGIC_DEFENSE);
            Assert.AreEqual(parametersStationery[ParameterType.ACCURACY], NpcParametersMock.ACCURACY);
            Assert.AreEqual(parametersStationery[ParameterType.EVASION], NpcParametersMock.EVASION);
            Assert.AreEqual(parametersStationery[ParameterType.SPEED], NpcParametersMock.SPEED);
        }

        [Test]
        public static void IndexerTest2()
        {
            Assert.AreEqual(parameters[ParameterType.NOW_HP], NpcParametersMock.NOW_HP);
            Assert.AreEqual(parameters[ParameterType.NOW_ENERGY], NpcParametersMock.NOW_ENERGY);
            Assert.AreEqual(parameters[ParameterType.NOW_MENTAL], NpcParametersMock.NOW_MENTAL);
            Assert.AreEqual(parameters[ParameterType.MAX_HP], NpcParametersMock.MAX_HP);
            Assert.AreEqual(parameters[ParameterType.MAX_ENERGY], NpcParametersMock.MAX_ENERGY);
            Assert.AreEqual(parameters[ParameterType.MAX_MENTAL], NpcParametersMock.MAX_MENTAL);
            Assert.AreEqual(parameters[ParameterType.PHYSICAL_ATTACK], NpcParametersMock.PHYSICAL_ATTACK);
            Assert.AreEqual(parameters[ParameterType.PHYSICAL_DEFENSE], NpcParametersMock.PHYSICAL_DEFENSE);
            Assert.AreEqual(parameters[ParameterType.MAGIC_ATTACK], NpcParametersMock.MAGIC_ATTACK);
            Assert.AreEqual(parameters[ParameterType.MAGIC_DEFENSE], NpcParametersMock.MAGIC_DEFENSE);
            Assert.AreEqual(parameters[ParameterType.ACCURACY], NpcParametersMock.ACCURACY);
            Assert.AreEqual(parameters[ParameterType.EVASION], NpcParametersMock.EVASION);
            Assert.AreEqual(parameters[ParameterType.SPEED], NpcParametersMock.SPEED);
        }
    }
}
