using Assets.Src.Domain.Model.Entity;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domain.Model.Value
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
            Dictionary<Ailment, int> _ailmentAmount = new Dictionary<Ailment, int>();
            Dictionary<Ailment, int> _ailmentDuration = new Dictionary<Ailment, int>();
            Vector2 _movement = Vector2.zero;
            List<EffectAnimation> _animations = new List<EffectAnimation>();

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
                animations: _animations);

            /// <summary>
            /// 動作対象を設定する
            /// </summary>
            /// <param name="_target">動作対象</param>
            /// <returns>動作対象の設定されたビルダー</returns>
            public Builder Target(Npc _target)
            {
                this._target = _target;
                return this;
            }
            /// <summary>
            /// パラメータ変動量を設定する
            /// </summary>
            /// <param name="_variation">パラメータ変動量</param>
            /// <returns>パラメータ変動量の設定されたビルダー</returns>
            public Builder Variation(Npc.Parameters _variation)
            {
                this._variation = _variation;
                return this;
            }
            /// <summary>
            /// 状態異常付与量（レベル）を設定する
            /// </summary>
            /// <param name="_ailmentAmount">状態異常付与量（レベル）</param>
            /// <returns>状態異常付与量（レベル）の設定されたビルダー</returns>
            public Builder AilmentAmount(Dictionary<Ailment, int> _ailmentAmount)
            {
                this._ailmentAmount = _ailmentAmount;
                return this;
            }
            /// <summary>
            /// 状態異常延長ターン数を設定する
            /// </summary>
            /// <param name="_ailmentDuration">状態異常延長ターン数</param>
            /// <returns>状態異常延長ターン数の設定されたビルダー</returns>
            public Builder AilmentDuration(Dictionary<Ailment, int> _ailmentDuration)
            {
                this._ailmentDuration = _ailmentDuration;
                return this;
            }
            /// <summary>
            /// 移動方向・量を設定する
            /// </summary>
            /// <param name="_movement">移動方向・量</param>
            /// <returns>移動方向・量の設定されたビルダー</returns>
            public Builder Movement(Vector2 _movement)
            {
                this._movement = _movement;
                return this;
            }
            /// <summary>
            /// 表示エフェクト情報を設定する
            /// </summary>
            /// <param name="_animations">表示エフェクト情報</param>
            /// <returns>表示エフェクト情報の設定されたビルダー</returns>
            public Builder Animations(List<EffectAnimation> _animations)
            {
                this._animations = _animations;
                return this;
            }
        }
    }
}
