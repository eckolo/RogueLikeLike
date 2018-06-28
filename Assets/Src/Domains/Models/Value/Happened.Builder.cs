using Assets.Src.Domains.Models.Entity;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    public partial class Happened
    {
        /// <summary>
        /// <see cref="Happened"/>クラスのビルダー
        /// </summary>
        public class Builder
        {
            Npc _target = null;
            Npc.Parameters _variation = Npc.Parameters.zero;
            Dictionary<Ailment.Stationery, int> _ailmentAmount
                = new Dictionary<Ailment.Stationery, int>();
            Dictionary<Ailment.Stationery, int> _ailmentDuration
                = new Dictionary<Ailment.Stationery, int>();
            Vector2 _movement = Vector2.zero;
            EffectAnimation _animation = null;

            /// <summary>
            /// クラス生成
            /// </summary>
            /// <returns></returns>
            public Happened Build() => new Happened(
                target: _target,
                variation: _variation,
                ailmentAmount: _ailmentAmount,
                ailmentDuration: _ailmentDuration,
                movement: _movement,
                animation: _animation);

            /// <summary>
            /// 値の設定
            /// </summary>
            /// <param name="_target">設定値</param>
            /// <returns>値の設定されたビルダー</returns>
            public Builder Target(Npc _target)
            {
                this._target = _target;
                return this;
            }
            /// <summary>
            /// 値の設定
            /// </summary>
            /// <param name="_variation">設定値</param>
            /// <returns>値の設定されたビルダー</returns>
            public Builder Variation(Npc.Parameters _variation)
            {
                this._variation = _variation;
                return this;
            }
            /// <summary>
            /// 値の設定
            /// </summary>
            /// <param name="_ailmentAmount">設定値</param>
            /// <returns>値の設定されたビルダー</returns>
            public Builder AilmentAmount(Dictionary<Ailment.Stationery, int> _ailmentAmount)
            {
                this._ailmentAmount = _ailmentAmount;
                return this;
            }
            /// <summary>
            /// 値の設定
            /// </summary>
            /// <param name="_ailmentDuration">設定値</param>
            /// <returns>値の設定されたビルダー</returns>
            public Builder AilmentDuration(Dictionary<Ailment.Stationery, int> _ailmentDuration)
            {
                this._ailmentDuration = _ailmentDuration;
                return this;
            }
            /// <summary>
            /// 値の設定
            /// </summary>
            /// <param name="_movement">設定値</param>
            /// <returns>値の設定されたビルダー</returns>
            public Builder Movement(Vector2 _movement)
            {
                this._movement = _movement;
                return this;
            }
            /// <summary>
            /// 値の設定
            /// </summary>
            /// <param name="_animation">設定値</param>
            /// <returns>値の設定されたビルダー</returns>
            public Builder Animation(EffectAnimation _animation)
            {
                this._animation = _animation;
                return this;
            }
        }
    }
}
