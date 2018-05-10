using System;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    public partial class NpcStationery
    {
        /// <summary>
        /// キャラクタの基礎ステータス
        /// </summary>
        [Serializable]
        public class Parameters
        {
            /// <summary>
            /// 全パラメータが0のパラメータオブジェクト
            /// </summary>
            public static readonly Parameters zero = new Parameters(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            /// <summary>
            /// コンストラクタ
            /// </summary>
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
                int maxHp,
                int maxEnergy,
                int maxMental,
                int physicalAttack,
                int physicalDefense,
                int magicAttack,
                int magicDefense,
                int accuracy,
                int evasion,
                int speed)
            {
                _maxHp = maxHp;
                _maxEnergy = maxEnergy;
                _maxMental = maxMental;
                _physicalAttack = physicalAttack;
                _physicalDefense = physicalDefense;
                _magicAttack = magicAttack;
                _magicDefense = magicDefense;
                _accuracy = accuracy;
                _evasion = evasion;
                _speed = speed;
            }

            /// <summary>
            /// 最大HP
            /// </summary>
            [SerializeField]
            readonly int _maxHp;
            /// <summary>
            /// 最大HP
            /// </summary>
            public int maxHp => _maxHp;
            /// <summary>
            /// 最大スタミナ
            /// </summary>
            [SerializeField]
            readonly int _maxEnergy;
            /// <summary>
            /// 最大スタミナ
            /// </summary>
            public int maxEnergy => _maxEnergy;
            /// <summary>
            /// 最大精神力
            /// </summary>
            [SerializeField]
            readonly int _maxMental;
            /// <summary>
            /// 最大精神力
            /// </summary>
            public int maxMental => _maxMental;
            /// <summary>
            /// 物理攻撃力
            /// </summary>
            [SerializeField]
            readonly int _physicalAttack;
            /// <summary>
            /// 物理攻撃力
            /// </summary>
            public int physicalAttack => _physicalAttack;
            /// <summary>
            /// 物理防御力
            /// </summary>
            [SerializeField]
            readonly int _physicalDefense;
            /// <summary>
            /// 物理防御力
            /// </summary>
            public int physicalDefense => _physicalDefense;
            /// <summary>
            /// 魔法攻撃力
            /// </summary>
            [SerializeField]
            readonly int _magicAttack;
            /// <summary>
            /// 魔法攻撃力
            /// </summary>
            public int magicAttack => _magicAttack;
            /// <summary>
            /// 魔法防御力
            /// </summary>
            [SerializeField]
            readonly int _magicDefense;
            /// <summary>
            /// 魔法防御力
            /// </summary>
            public int magicDefense => _magicDefense;
            /// <summary>
            /// 命中率
            /// </summary>
            [SerializeField]
            readonly int _accuracy;
            /// <summary>
            /// 命中率
            /// </summary>
            public int accuracy => _accuracy;
            /// <summary>
            /// 回避率
            /// </summary>
            [SerializeField]
            readonly int _evasion;
            /// <summary>
            /// 回避率
            /// </summary>
            public int evasion => _evasion;
            /// <summary>
            /// 行動速度
            /// </summary>
            [SerializeField]
            readonly int _speed;
            /// <summary>
            /// 行動速度
            /// </summary>
            public int speed => _speed;

            /// <summary>
            /// パラメータ補正値計算用の加算処理
            /// 減算も同じく
            /// </summary>
            /// <param name="x">可算されるパラメータ</param>
            /// <param name="y">可算するパラメータ</param>
            /// <returns>可算結果のパラメータ</returns>
            public static Parameters operator +(Parameters x, Parameters y)
                => new Parameters(
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
        }
    }
}
