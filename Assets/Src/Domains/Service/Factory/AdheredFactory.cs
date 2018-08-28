using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;
using System;
using System.Collections.Generic;

namespace Assets.Src.Domains.Service.Factory
{
    /// <summary>
    /// 形容詞付きオブジェクト生成サービス
    /// </summary>
    /// <typeparam name="TAdhered">生成オブジェクトの型</typeparam>
    /// <typeparam name="TStationery">生成オブジェクトの雛形となる型</typeparam>
    public static class AdheredFactory
    {
        /// <summary>
        /// オブジェクトの新規生成関数
        /// </summary>
        /// <param name="stationery">雛形となるオブジェクト</param>
        /// <param name="addableAdjectives">
        /// 付与され得る形容詞リスト
        /// 同要素を複数含むことで付与確率上昇
        /// </param>
        /// <param name="level">形容詞の最大付与数</param>
        /// <returns>生成されたオブジェクト</returns>
        public static TAdhered ToAdhered<TAdhered, TStationery>(
            this TStationery stationery,
            IEnumerable<Adjective> addableAdjectives,
            int level = 1)
            where TAdhered : Adhered<TStationery>
            where TStationery : Named
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// オブジェクトの新規生成関数
        /// </summary>
        /// <param name="stationery">雛形となるオブジェクト</param>
        /// <returns>生成されたオブジェクト</returns>
        public static TAdhered ToAdhered<TAdhered, TStationery>(this TStationery stationery)
            where TAdhered : Adhered<TStationery>
            where TStationery : Named
            => ToAdhered<TAdhered, TStationery>(stationery, new Adjective[0], 0);
        /// <summary>
        /// 固定接頭辞付きオブジェクトの新規生成関数
        /// </summary>
        /// <param name="stationery">雛形となるオブジェクト</param>
        /// <param name="prefix">固定で先頭に付与される形容詞（接頭辞）リスト</param>
        /// <param name="addableAdjectives">
        /// 付与され得る形容詞リスト
        /// 同要素を複数含むことで付与確率上昇
        /// </param>
        /// <param name="level">形容詞の最大付与数</param>
        /// <returns>生成されたオブジェクト</returns>
        public static TAdhered ToAdhered<TAdhered, TStationery>(
            this TStationery stationery,
            List<Adjective> prefix,
            IEnumerable<Adjective> addableAdjectives,
            int level = 1)
            where TAdhered : Adhered<TStationery>
            where TStationery : Named
        {
            throw new NotImplementedException();
        }
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
            where TAdhered : Adhered<TStationery>
            where TStationery : Named
        {
            throw new NotImplementedException();
        }
    }
}
