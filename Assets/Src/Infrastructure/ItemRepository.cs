using Assets.Src.Domains.Models.Items;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// アイテムリポジトリ
    /// </summary>
    public class ItemRepository : ResourceRepository<ItemStationery>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Item/";
    }
}
