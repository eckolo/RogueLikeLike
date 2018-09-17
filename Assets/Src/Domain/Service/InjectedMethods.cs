using Assets.Src.Domain.Model.Value;
using Assets.Src.Domain.Repository;

namespace Assets.Src.Domain.Service
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
