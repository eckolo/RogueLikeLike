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
        /// <param name="states">保存したいゲーム状態</param>
        /// <param name="dataIndex">
        /// セーブ先データ番号
        /// 0は自動セーブ先
        /// </param>
        /// <returns>保存されたゲーム状態</returns>
        public static IGameFoundation Save(this IGameFoundation states, int dataIndex)
        {
            var fileManager = states.methods.fileManager;
            var state = states.state;

            fileManager.SetClass($"{KEY_PREFIX}{dataIndex}", state);
            fileManager.Save();
            return states;
        }
        /// <summary>
        /// ロード処理
        /// </summary>
        /// <param name="_states">ゲーム状態</param>
        /// <param name="dataIndex">
        /// ロード対象データ番号
        /// 0は自動セーブ先
        /// </param>
        /// <returns>ロードされたゲーム状態の実体</returns>
        public static GameState Load(this IGameFoundation _states, int dataIndex)
        {
            var states = _states.Duplicate();
            var fileManager = states.methods.fileManager;
            var state = states.state;

            fileManager.Load();
            return fileManager.GetClass($"{KEY_PREFIX}{dataIndex}", state);
        }
    }
}
