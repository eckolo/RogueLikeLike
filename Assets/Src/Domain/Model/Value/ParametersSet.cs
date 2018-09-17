using Assets.Src.Domain.Model.Entity;
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
    /// パラメータ種別とパラメータワンセットとの疑似辞書型クラス
    /// </summary>
    [Serializable]
    public class ParametersSet : IKeyValueLike<ParameterType, Npc.Parameters>
    {
        [SerializeField]
        ParameterType _parameterType = default(ParameterType);
        public ParameterType key => _parameterType;

        [SerializeField]
        Npc.Parameters _parameters = Npc.Parameters.zero;
        public Npc.Parameters value => _parameters;
    }
}
