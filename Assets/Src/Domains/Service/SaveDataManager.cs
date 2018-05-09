using Assets.Src.Domains.Models.Entity;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// セーブデータを管理するクラス
    /// </summary>
    public static class SaveDataManager
    {
        /// <summary>
        /// メインセーブデータ記録時のキー接頭辞
        /// </summary>
        const string KEY_PREFIX = "DataSlot";

        /// <summary>
        /// セーブ処理
        /// </summary>
        /// <param name="state">保存したいゲーム状態</param>
        /// <param name="dataIndex">
        /// セーブ先データ番号
        /// 0は自動セーブ先
        /// </param>
        /// <returns>保存されたゲーム状態</returns>
        public static GameState Save(this GameState state, int dataIndex, IFileManager fileManager)
        {
            fileManager.SetClass($"{KEY_PREFIX}{dataIndex}", state);
            fileManager.Save();
            return state;
        }
        /// <summary>
        /// ロード処理
        /// </summary>
        /// <param name="_state">ゲーム状態</param>
        /// <param name="dataIndex">
        /// ロード対象データ番号
        /// 0は自動セーブ先
        /// </param>
        /// <returns>ロードされたゲーム状態の実体</returns>
        public static GameState Load(this GameState _state, int dataIndex, IFileManager fileManager)
        {
            var state = _state.Duplicate();

            fileManager.Load();
            return fileManager.GetClass($"{KEY_PREFIX}{dataIndex}", state);
        }
    }
}
