﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models.Values
{
    /// <summary>
    /// 行動条件クラス
    /// </summary>
    [Serializable]
    public class ActionTerm
    {
        /// <summary>
        /// 該当行動パターン
        /// </summary>
        [SerializeField]
        ActionPattern actionPattern = default(ActionPattern);
    }
}
