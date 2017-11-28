using System;

namespace Assets.Src.Models.Person
{
    public partial class PersonStationery
    {
        /// <summary>
        /// キャラクタの基礎ステータス
        /// </summary>
        [Serializable]
        public class Parameters
        {
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
        }
    }
}
