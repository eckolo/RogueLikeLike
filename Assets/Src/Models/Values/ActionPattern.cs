using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models.Values
{
    /// <summary>
    /// 行動パターン
    /// </summary>
    public class ActionPattern : ScriptableObject
    {
        /// <summary>
        /// パターンを構成する行動要素リスト
        /// </summary>
        [SerializeField]
        List<ActionElement> _actionElements = new List<ActionElement>();
        /// <summary>
        /// パターンを構成する行動要素リスト
        /// </summary>
        public List<ActionElement> actionElementList => _actionElements;
    }
}
