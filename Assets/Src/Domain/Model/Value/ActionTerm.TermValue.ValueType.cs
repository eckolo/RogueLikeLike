namespace Assets.Src.Domain.Model.Value
{
    public partial class ActionTerm
    {
        partial class TermValue
        {
            /// <summary>
            /// 条件に使用される値のパターン
            /// </summary>
            public enum ValueType
            {
                /// <summary>
                /// 自身との距離
                /// </summary>
                RANGE,
                /// <summary>
                /// NPC数
                /// </summary>
                HOW_MANY_NPC,
                /// <summary>
                /// 友好NPC数
                /// </summary>
                HOW_MANY_FRIEND,
                /// <summary>
                /// 敵対NPC数
                /// </summary>
                HOW_MANY_STRANGER,
                /// <summary>
                /// 最大HP
                /// </summary>
                MAX_HP,
                /// <summary>
                /// 最大スタミナ
                /// </summary>
                MAX_ENERGY,
                /// <summary>
                /// 最大精神力
                /// </summary>
                MAX_MENTAL,
                /// <summary>
                /// 現在HP
                /// </summary>
                NOW_HP,
                /// <summary>
                /// 現在スタミナ
                /// </summary>
                NOW_ENERGY,
                /// <summary>
                /// 現在精神力
                /// </summary>
                NOW_MENTAL,
                /// <summary>
                /// 物理攻撃力
                /// </summary>
                PHYSICAL_ATTACK,
                /// <summary>
                /// 物理防御力
                /// </summary>
                PHYSICAL_DEFENSE,
                /// <summary>
                /// 魔法攻撃力
                /// </summary>
                MAGIC_ATTACK,
                /// <summary>
                /// 魔法防御力
                /// </summary>
                MAGIC_DEFENSE,
                /// <summary>
                /// 命中率
                /// </summary>
                ACCURACY,
                /// <summary>
                /// 回避率
                /// </summary>
                EVASION,
                /// <summary>
                /// 行動速度
                /// </summary>
                SPEED,
            }
        }
    }
}
