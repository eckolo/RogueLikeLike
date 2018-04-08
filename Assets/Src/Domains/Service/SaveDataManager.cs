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
        public static IGameStates Save(this IGameStates states, int dataIndex)
        {
            var fileManager = states.methods.fileManager;
            var stateEntity = states.stateEntity;

            fileManager.SetClass($"{KEY_PREFIX}{dataIndex}", stateEntity);
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
        public static GameStateEntity Load(this IGameStates _states, int dataIndex)
        {
            var states = _states.Duplicate();
            var fileManager = states.methods.fileManager;
            var stateEntity = states.stateEntity;

            fileManager.Load();
            return fileManager.GetClass($"{KEY_PREFIX}{dataIndex}", stateEntity);
        }
    }
}
