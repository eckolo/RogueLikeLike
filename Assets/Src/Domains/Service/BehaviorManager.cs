using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// <see cref="Behavior"/>関連の計算処理に関するサービス
    /// </summary>
    public static class BehaviorManager
    {
        /// <summary>
        /// 動作内容からパラメータ変動量を算出する
        /// </summary>
        /// <param name="behavior">動作内容</param>
        /// <param name="actor">動作主体</param>
        /// <param name="target">動作対象</param>
        /// <returns>パラメータ変動量</returns>
        public static Npc.Parameters ToVariation(this Behavior behavior, Npc actor, Npc target)
        {
            var attack = behavior.attackParameters
                 .Select(parameters => new
                 {
                     type = parameters.Key,
                     value = (actor.parameters * parameters.Value).innerProduct.DividedBy(100)
                 });
            var defense = behavior.defenseParameters
                 .Select(parameters => new
                 {
                     type = parameters.Key,
                     value = (target.parameters * parameters.Value).innerProduct.DividedBy(100)
                 });
            var accuracy = (actor.parameters * behavior.accuracyParameters).innerProduct;
            var evasion = (target.parameters * behavior.evasionParameters).innerProduct;

            var individualVariation = attack.GroupJoin(
                defense,
                parameters => parameters.type,
                parameters => parameters.type,
                (_attack, defenses) => new
                {
                    _attack.type,
                    attack = _attack.value,
                    defense = defenses.SingleOrDefault()?.value ?? Fraction.zero
                })
                .Select(parameters => new
                {
                    parameters.type,
                    value = (parameters.attack + parameters.defense).LimitLower(Fraction.zero)
                })
                .Select(parameters => new
                {
                    parameters.type,
                    value = parameters.value * (accuracy - evasion) * behavior.power.DividedBy(100)
                })
                .ToDictionary(parameters => parameters.type, parameters => Mathf.CeilToInt(parameters.value.value));

            return new Npc.Parameters(individualVariation);
        }
    }
}
