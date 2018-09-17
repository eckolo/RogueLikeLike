using Assets.Src.Domain.Model.Value;

namespace Assets.Src.Domain.Service
{
    /// <summary>
    /// スキル関連サービス
    /// </summary>
    public static class SkillManager
    {
        /// <summary>
        /// スキルキークラスからリソースフォルダに検索かける際のキー文字列への変換処理
        /// </summary>
        /// <param name="key">スキルの索引キークラス</param>
        /// <returns>検索キーとなる文字列</returns>
        public static string ToFileName(this Skill.Key key)
            => $"{((int)key).ToString("D5")}_{key.ToString().ConvertSnakeToPascal()}";

        /// <summary>
        /// スキルキーからスキル分類への変換処理
        /// </summary>
        /// <param name="key">スキルの索引キークラス</param>
        /// <returns>スキルキーに紐づくスキル分類</returns>
        public static Skill.Section ToSection(this Skill.Key key) => (Skill.Section)(((int)key) / 10000);
    }
}
