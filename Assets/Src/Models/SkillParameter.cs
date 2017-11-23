using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Models
{
    /// <summary>
    /// スキルに対して各エンティティが所持するスキル値のオブジェクト
    /// </summary>
    public class SkillParameter
    {
        /// <summary>
        /// 対応スキル
        /// </summary>
        public Skill skill { get; }
        /// <summary>
        /// スキル値
        /// </summary>
        public int value { get; set; }
    }
}
