using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// オブジェクト複製クラス
    /// </summary>
    public static class DuplicateManager
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
