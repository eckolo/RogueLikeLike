using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Src.Models.Abilities;
using Assets.Src.Models;

namespace Assets.Src.Domains
{
    /// <summary>
    /// アビリティ生成・変更サービス
    /// </summary>
    public class AbilityFactory : IFactoryStationery<Ability, AbilityStationery>
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
        public Ability Generate(AbilityStationery stationery, List<Adjective> addableAdjectives, int level = 1)
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
        public Ability ResetAdjective(Ability origin, int index, Adjective setedAdjective)
        {
            throw new NotImplementedException();
        }
    }
}
