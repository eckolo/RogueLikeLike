using Assets.Src.Domains.Models;
using System;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// セーブデータを管理するクラス
    /// </summary>
    public static class SaveDataManager
    {
        /// <summary>
        /// セーブ処理
        /// </summary>
        /// <param name="dataIndex">
        /// セーブ先データ番号
        /// 0は自動セーブ先
        /// </param>
        /// <param name="states">保存したいゲーム状態</param>
        /// <returns>セーブ処理成否</returns>
        public static bool Save(this int dataIndex, IStateEntity states)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// ロード処理
        /// </summary>
        /// <param name="dataIndex">
        /// ロード対象データ番号
        /// 0は自動セーブ先
        /// </param>
        /// <returns>ロードされたゲーム状態</returns>
        public static IStateEntity Load(this int dataIndex)
        {
            throw new NotImplementedException();
        }
    }
}
