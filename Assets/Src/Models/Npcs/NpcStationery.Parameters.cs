using System;

namespace Assets.Src.Models.Npcs
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
                this.maxHp = maxHp;
                this.maxEnergy = maxEnergy;
                this.maxMental = maxMental;
                this.physicalAttack = physicalAttack;
                this.physicalDefense = physicalDefense;
                this.magicAttack = magicAttack;
                this.magicDefense = magicDefense;
                this.accuracy = accuracy;
                this.evasion = evasion;
                this.speed = speed;
            }

            /// <summary>
            /// 最大HP
            /// </summary>
            public int maxHp { get; }
            /// <summary>
            /// 最大スタミナ
            /// </summary>
            public int maxEnergy { get; }
            /// <summary>
            /// 最大精神力
            /// </summary>
            public int maxMental { get; }
            /// <summary>
            /// 物理攻撃力
            /// </summary>
            public int physicalAttack { get; }
            /// <summary>
            /// 物理防御力
            /// </summary>
            public int physicalDefense { get; }
            /// <summary>
            /// 魔法攻撃力
            /// </summary>
            public int magicAttack { get; }
            /// <summary>
            /// 魔法防御力
            /// </summary>
            public int magicDefense { get; }
            /// <summary>
            /// 命中率
            /// </summary>
            public int accuracy { get; }
            /// <summary>
            /// 回避率
            /// </summary>
            public int evasion { get; }
            /// <summary>
            /// 行動速度
            /// </summary>
            public int speed { get; }

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
