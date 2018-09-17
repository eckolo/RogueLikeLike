using UnityEngine;

namespace Assets.Src.Domain.Model.Value
{
    /// <summary>
    /// 動作対象の決定種別
    /// </summary>
    public partial class TargetDecisionType : TargetType
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
    }
}
