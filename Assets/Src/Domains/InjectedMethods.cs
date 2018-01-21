using Assets.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Domains
{
    /// <summary>
    /// DI用インターフェース保持クラス
    /// </summary>
    public class InjectedMethods
    {
        /// <summary>
        /// 画面描画処理
        /// </summary>
        public IViewManager viewer { get; set; }
        /// <summary>
        /// スキルリポジトリ
        /// </summary>
        public IRepository<SkillKey, Skill> skillRepository { get; set; }
    }
}
