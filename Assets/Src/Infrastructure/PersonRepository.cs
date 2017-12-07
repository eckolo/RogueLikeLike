﻿using Assets.Src.Models.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// キャラクタリポジトリ
    /// </summary>
    public class PersonRepository : ResourceRepository<PersonStationery>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Person/";
    }
}