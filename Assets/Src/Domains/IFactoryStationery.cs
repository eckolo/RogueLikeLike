using Assets.Src.Models;
using System.Collections.Generic;

namespace Assets.Src.Domains
{
    /// <summary>
    /// 生成・変更系サービスの雛形
    /// </summary>
    /// <typeparam name="Entity">管理対象オブジェクトの型</typeparam>
    /// <typeparam name="Stationery">管理対象オブジェクトの雛形となる型</typeparam>
    public interface IFactoryStationery<Entity, Stationery> where Entity : Stationery, IAdhered where Stationery : Named
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
        Entity Generate(Stationery stationery, IEnumerable<Adjective> addableAdjectives, int level = 1);
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
        Entity Generate(Stationery stationery, List<Adjective> prefix, IEnumerable<Adjective> addableAdjectives, int level = 1);
        /// <summary>
        /// オブジェクトの形容詞を付け替え・追加する関数
        /// </summary>
        /// <param name="origin">元オブジェクト</param>
        /// <param name="index">変更したい形容詞インデックス</param>
        /// <param name="setedAdjective">追加したい形容詞</param>
        /// <returns>変更されたオブジェクト</returns>
        Entity ResetAdjective(Entity origin, int index, Adjective setedAdjective);
    }
}
