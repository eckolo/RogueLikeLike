using Assets.Src.Domain.Model.Abstract;
using Assets.Src.Domain.Model.Value;
using System;

namespace Assets.Src.Domain.Service
{
    /// <summary>
    /// 形容詞付きオブジェクト操作サービス
    /// </summary>
    public static class AdheredManager
    {
        /// <summary>
        /// オブジェクトの形容詞を付け替え・追加する関数
        /// </summary>
        /// <param name="origin">元オブジェクト</param>
        /// <param name="index">変更したい形容詞インデックス</param>
        /// <param name="setedAdjective">追加したい形容詞</param>
        /// <returns>変更されたオブジェクト</returns>
        public static TAdhered ResetAdjective<TAdhered, TStationery>(
            this TAdhered origin,
            int index,
            Adjective setedAdjective)
            where TAdhered : Adhered<TStationery>, new()
            where TStationery : Named
        {
            //TODO 実装する
            throw new NotImplementedException();
        }
    }
}