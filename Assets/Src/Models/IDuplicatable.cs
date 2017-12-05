using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Models
{
    /// <summary>
    /// シャローコピー可能オブジェクトインターフェース
    /// </summary>
    /// <typeparam name="Duplicated"></typeparam>
    public interface IDuplicatable<Duplicated>
    {
        /// <summary>
        /// シャローコピーメソッド
        /// 基本的にMemberwiseClone()メソッドをキャストだけしてそのまま返せばOK
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        Duplicated Duplicate();
    }
}
