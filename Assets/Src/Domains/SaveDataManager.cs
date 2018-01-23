using System;

namespace Assets.Src.Domains
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
        /// <returns>セーブ処理成否</returns>
        public static bool Save(int dataIndex = 0)
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
        /// <returns>ロード処理成否</returns>
        public static bool Load(int dataIndex = 0)
        {
            throw new NotImplementedException();
        }
    }
}
