using System;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// 動作対象の種類
    /// </summary>
    [Serializable]
    public partial class TargetType
    {
        /// <summary>
        /// 確定条件
        /// </summary>
        [SerializeField]
        Determination _determination = default(Determination);
        /// <summary>
        /// 確定条件
        /// </summary>
        public Determination determination => _determination;

        /// <summary>
        /// 限定条件
        /// </summary>
        [SerializeField]
        Limited _limited = default(Limited);
        /// <summary>
        /// 限定条件
        /// </summary>
        public Limited limited => _limited;

        /// <summary>
        /// 対象候補に自信を含むか否か
        /// </summary>
        [SerializeField]
        bool _includeMyself = false;
        /// <summary>
        /// 対象候補に自信を含むか否か
        /// </summary>
        public bool includeMyself => _includeMyself;
    }
}
