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
        IRepository<Skill, string> skillRepository { get; set; }
    }
}
