using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Models
{
    /// <summary>
    /// 何かしらを対象とするクラス全般インターフェース
    /// </summary>
    /// <typeparam name="Target">ターゲットとなるクラスの型</typeparam>
    interface ITargeting<Target>
    {
        /// <summary>
        /// 動作対象
        /// </summary>
        Target target { get; }
    }
}
