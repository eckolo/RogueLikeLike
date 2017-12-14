using Assets.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Domains
{
    /// <summary>
    /// オブジェクト複製クラス
    /// </summary>
    public static class DuplicateFactory
    {
        /// <summary>
        /// 複製可能なオブジェクトの複製を行う
        /// Nullチェック付き
        /// </summary>
        /// <typeparam name="Duplicated">複製されるオブジェクト型</typeparam>
        /// <param name="origin">複製される雛形オブジェクト</param>
        /// <returns>複製されたオブジェクト</returns>
        public static Duplicated Duplicate<Duplicated>(this IDuplicatable<Duplicated> origin)
            where Duplicated : IDuplicatable<Duplicated>
            => origin != null ? origin.MemberwiseClonePublic() : default(Duplicated);
    }
}
