using Assets.Src.Domains.Models.Interface;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    public partial class Ailment
    {
        public partial class Stationery
        {
            /// <summary>
            /// 状態異常に対する数値の疑似辞書型オブジェクト
            /// </summary>
            [Serializable]
            public class Parameters : IKeyValueLike<Stationery, KeyValuePair<int, int>>
            {
                /// <summary>
                /// コンストラクタ
                /// </summary>
                /// <param name="key">状態異常オブジェクト</param>
                /// <param name="amount">状態異常レベル</param>
                /// <param name="duration">状態異常継続ターン数</param>
                public Parameters(Stationery key, int amount, int duration)
                {
                    _key = key;
                    _amount = amount;
                    _duration = duration;
                }

                /// <summary>
                /// 対応状態異常
                /// </summary>
                [SerializeField]
                Stationery _key = default(Stationery);
                /// <summary>
                /// 辞書型変換用プロパティ
                /// </summary>
                public Stationery key => _key;

                /// <summary>
                /// 状態異常レベル
                /// </summary>
                [SerializeField]
                int _amount = 0;
                /// <summary>
                /// 状態異常継続期間
                /// </summary>
                [SerializeField]
                int _duration = 0;

                /// <summary>
                /// 状態異常値
                /// </summary>
                public KeyValuePair<int, int> value => new KeyValuePair<int, int>(_amount, _duration);
            }
        }
    }
}
