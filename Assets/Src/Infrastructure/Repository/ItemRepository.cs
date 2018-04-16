﻿using Assets.Src.Domains.Models.Value;

namespace Assets.Src.Infrastructure.Repository
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