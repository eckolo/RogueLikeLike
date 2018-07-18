using Assets.Src.Domains.Models.Value;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Models.Entity
{
    public partial class Npc
    {
        /// <summary>
        /// キャラクタの基礎ステータス
        /// </summary>
        [Serializable]
        public class Parameters : NpcStationery.Parameters
        {
            /// <summary>
            /// 全パラメータが0のパラメータオブジェクト
            /// </summary>
            public static new readonly Parameters zero = new Parameters(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="nowHp">現在HP</param>
            /// <param name="nowEnergy">現在スタミナ</param>
            /// <param name="nowMental">現在精神力</param>
            /// <param name="maxHp">最大HP</param>
            /// <param name="maxEnergy">最大スタミナ</param>
            /// <param name="maxMental">最大精神力</param>
            /// <param name="physicalAttack">物理攻撃力</param>
            /// <param name="physicalDefense">物理防御力</param>
            /// <param name="magicAttack">魔法攻撃力</param>
            /// <param name="magicDefense">魔法防御力</param>
            /// <param name="accuracy">命中率</param>
            /// <param name="evasion">回避率</param>
            /// <param name="speed">行動速度</param>
            public Parameters(
                int nowHp, int nowEnergy, int nowMental,
                int maxHp, int maxEnergy, int maxMental,
                int physicalAttack, int physicalDefense,
                int magicAttack, int magicDefense,
                int accuracy, int evasion, int speed)
                : base(
                      maxHp: maxHp,
                      maxEnergy: maxEnergy,
                      maxMental: maxMental,
                      physicalAttack: physicalAttack,
                      physicalDefense: physicalDefense,
                      magicAttack: magicAttack,
                      magicDefense: magicDefense,
                      accuracy: accuracy,
                      evasion: evasion,
                      speed: speed)
            {
                _nowHp = nowHp;
                _nowEnergy = nowEnergy;
                _nowMental = nowMental;
            }

            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="nowHp">現在HP</param>
            /// <param name="nowEnergy">現在スタミナ</param>
            /// <param name="nowMental">現在精神力</param>
            /// <param name="parameters">元となるパラメータクラス</param>
            public Parameters(int nowHp, int nowEnergy, int nowMental, NpcStationery.Parameters parameters)
                : this(
                      nowHp: nowHp,
                      nowEnergy: nowEnergy,
                      nowMental: nowMental,
                      maxHp: parameters.maxHp,
                      maxEnergy: parameters.maxEnergy,
                      maxMental: parameters.maxMental,
                      physicalAttack: parameters.physicalAttack,
                      physicalDefense: parameters.physicalDefense,
                      magicAttack: parameters.magicAttack,
                      magicDefense: parameters.magicDefense,
                      accuracy: parameters.accuracy,
                      evasion: parameters.evasion,
                      speed: parameters.speed)
            { }

            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="parameters">元となるパラメータクラス</param>
            public Parameters(NpcStationery.Parameters parameters)
                : this(
                      nowHp: 0,
                      nowEnergy: 0,
                      nowMental: 0,
                      maxHp: parameters.maxHp,
                      maxEnergy: parameters.maxEnergy,
                      maxMental: parameters.maxMental,
                      physicalAttack: parameters.physicalAttack,
                      physicalDefense: parameters.physicalDefense,
                      magicAttack: parameters.magicAttack,
                      magicDefense: parameters.magicDefense,
                      accuracy: parameters.accuracy,
                      evasion: parameters.evasion,
                      speed: parameters.speed)
            { }

            /// <summary>
            /// 現在HP
            /// </summary>
            [SerializeField]
            int _nowHp;
            /// <summary>
            /// 現在HP
            /// </summary>
            public int nowHp
            {
                get {
                    return _nowHp;
                }
                set {
                    _nowHp = Mathf.Min(value, maxHp);
                }
            }

            /// <summary>
            /// 現在スタミナ
            /// </summary>
            [SerializeField]
            int _nowEnergy;
            /// <summary>
            /// 現在スタミナ
            /// </summary>
            public int nowEnergy
            {
                get {
                    return _nowEnergy;
                }
                set {
                    _nowEnergy = Mathf.Min(value, maxEnergy);
                }
            }

            /// <summary>
            /// 現在精神力
            /// </summary>
            [SerializeField]
            int _nowMental;
            /// <summary>
            /// 現在精神力
            /// </summary>
            public int nowMental
            {
                get {
                    return _nowMental;
                }
                set {
                    _nowMental = Mathf.Min(value, maxMental);
                }
            }

            public override int this[ParameterType index]
            {
                get {
                    switch(index)
                    {
                        case ParameterType.NOW_HP:
                            return nowHp;
                        case ParameterType.NOW_ENERGY:
                            return nowEnergy;
                        case ParameterType.NOW_MENTAL:
                            return nowMental;
                        default:
                            return base[index];
                    }
                }
            }

            /// <summary>
            /// パラメータの全合計値
            /// </summary>
            public float innerProduct
                => nowHp + nowEnergy + nowMental
                + maxHp + maxEnergy + maxMental
                + physicalAttack + physicalDefense
                + magicAttack + magicDefense
                + accuracy + evasion + speed;

            /// <summary>
            /// パラメータ補正値計算用の加算処理
            /// 減算も同じく
            /// </summary>
            /// <param name="x">可算されるパラメータ</param>
            /// <param name="y">可算するパラメータ</param>
            /// <returns>可算結果のパラメータ</returns>
            public static Parameters operator +(Parameters x, Parameters y)
                => new Parameters(
                    nowHp: x.nowHp + y.nowHp,
                    nowEnergy: x.nowEnergy + y.nowEnergy,
                    nowMental: x.nowMental + y.nowMental,
                    maxHp: x.maxHp + y.maxHp,
                    maxEnergy: x.maxEnergy + y.maxEnergy,
                    maxMental: x.maxMental + y.maxMental,
                    physicalAttack: x.physicalAttack + y.physicalAttack,
                    physicalDefense: x.physicalDefense + y.physicalDefense,
                    magicAttack: x.magicAttack + y.magicAttack,
                    magicDefense: x.magicDefense + y.magicDefense,
                    accuracy: x.accuracy + y.accuracy,
                    evasion: x.evasion + y.evasion,
                    speed: x.speed + y.speed);
            /// <summary>
            /// パラメータ補正値計算用の加算処理
            /// </summary>
            /// <param name="x">可算されるパラメータ</param>
            /// <param name="y">可算するパラメータ</param>
            /// <returns>可算結果のパラメータ</returns>
            public static Parameters operator +(Parameters x, NpcStationery.Parameters y) => x + new Parameters(y);
            /// <summary>
            /// パラメータ補正値計算用の加算処理
            /// </summary>
            /// <param name="x">可算されるパラメータ</param>
            /// <param name="y">可算するパラメータ</param>
            /// <returns>可算結果のパラメータ</returns>
            public static Parameters operator +(NpcStationery.Parameters x, Parameters y) => new Parameters(x) + y;

            /// <summary>
            /// パラメータ補正値計算用の乗算処理
            /// </summary>
            /// <param name="x">可算されるパラメータ</param>
            /// <param name="y">可算するパラメータ</param>
            /// <returns>可算結果のパラメータ</returns>
            public static Parameters operator *(Parameters x, Parameters y)
                => new Parameters(
                    nowHp: x.nowHp * y.nowHp,
                    nowEnergy: x.nowEnergy * y.nowEnergy,
                    nowMental: x.nowMental * y.nowMental,
                    maxHp: x.maxHp * y.maxHp,
                    maxEnergy: x.maxEnergy * y.maxEnergy,
                    maxMental: x.maxMental * y.maxMental,
                    physicalAttack: x.physicalAttack * y.physicalAttack,
                    physicalDefense: x.physicalDefense * y.physicalDefense,
                    magicAttack: x.magicAttack * y.magicAttack,
                    magicDefense: x.magicDefense * y.magicDefense,
                    accuracy: x.accuracy * y.accuracy,
                    evasion: x.evasion * y.evasion,
                    speed: x.speed * y.speed);
            /// <summary>
            /// パラメータ補正値計算用の加算処理
            /// </summary>
            /// <param name="x">可算されるパラメータ</param>
            /// <param name="y">可算するパラメータ</param>
            /// <returns>可算結果のパラメータ</returns>
            public static Parameters operator *(Parameters x, NpcStationery.Parameters y) => x * new Parameters(y);
            /// <summary>
            /// パラメータ補正値計算用の加算処理
            /// </summary>
            /// <param name="x">可算されるパラメータ</param>
            /// <param name="y">可算するパラメータ</param>
            /// <returns>可算結果のパラメータ</returns>
            public static Parameters operator *(NpcStationery.Parameters x, Parameters y) => new Parameters(x) * y;
        }
    }
}
