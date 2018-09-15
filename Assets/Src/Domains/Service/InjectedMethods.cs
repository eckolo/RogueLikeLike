using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Repository;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// DI用インターフェース保持クラス
    /// </summary>
    public class InjectedMethods
    {
        public InjectedMethods(
            IViewManager viewer, 
            IFileManager fileManager,
            IRepository<Skill.Key, Skill> skillRepository, 
            IRepository<string, AreaStationery> areaRepository)
        {
            this.viewer = viewer;
            this.fileManager = fileManager;
            this.skillRepository = skillRepository;
            this.areaRepository = areaRepository;
        }

        /// <summary>
        /// 画面描画処理
        /// </summary>
        public IViewManager viewer { get; }
        /// <summary>
        /// ファイル管理
        /// </summary>
        public IFileManager fileManager { get; }
        /// <summary>
        /// スキルリポジトリ
        /// </summary>
        public IRepository<Skill.Key, Skill> skillRepository { get; }
        /// <summary>
        /// エリアリポジトリ
        /// </summary>
        public IRepository<string, AreaStationery> areaRepository { get; }
    }
}
