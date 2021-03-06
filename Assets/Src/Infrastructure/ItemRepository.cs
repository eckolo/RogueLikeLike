﻿using Assets.Src.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
