using UnityEngine;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// データ格納リポジトリの雛形
    /// </summary>
    /// <typeparam name="Contests">格納されたデータの種別</typeparam>
    public interface IRepository<Key, Contests> where Contests : ScriptableObject
    {
        /// <summary>
        /// 格納データ読み出し関数
        /// </summary>
        /// <param name="key">読み出しデータキー</param>
        /// <returns>読みだされたデータ</returns>
        Contests GetContests(Key key);
    }
}
