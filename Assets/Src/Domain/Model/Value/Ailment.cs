using Assets.Src.Domain.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Domain.Model.Value
{
    /// <summary>
    /// 状態オブジェクト
    /// </summary>
    public partial class Ailment : Substance<Ailment.Stationery>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="stationery">元となる雛形</param>
        /// <param name="addBehaviors">追加動作定義</param>
        public Ailment(Stationery stationery, Dictionary<OperationTiming, List<Behavior>> addBehaviors = null)
            : base(stationery)
        {
            this.addBehaviors = addBehaviors ?? new Dictionary<OperationTiming, List<Behavior>>();
        }

        /// <summary>
        /// 動作定義
        /// </summary>
        public Dictionary<OperationTiming, List<Behavior>> behaviors
            => stationery.behaviors.Concat(addBehaviors)
            .ToDictionary(behavior => behavior.Key, behavior => behavior.Value);
        /// <summary>
        /// 追加動作定義
        /// </summary>
        Dictionary<OperationTiming, List<Behavior>> addBehaviors = new Dictionary<OperationTiming, List<Behavior>>();
    }
}
