using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Domain.Model.Value
{
    /// <summary>
    /// 各パラメータを示す型
    /// </summary>
    public enum ParameterType
    {
        /// <summary>
        /// 現在生命力
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
        /// 最大生命力
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
        SPEED
    }
}
