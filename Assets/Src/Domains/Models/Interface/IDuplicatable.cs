namespace Assets.Src.Domains.Models.Interface
{
    /// <summary>
    /// シャローコピー可能オブジェクトインターフェース
    /// </summary>
    /// <typeparam name="Duplicated">コピー対象オブジェクトクラス</typeparam>
    public interface IDuplicatable<Duplicated> where Duplicated : IDuplicatable<Duplicated>
    {
        /// <summary>
        /// シャローコピーメソッド
        /// 基本的にMemberwiseClone()メソッドをキャストだけしてそのまま返せばOK
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        Duplicated MemberwiseClonePublic();
    }
}
