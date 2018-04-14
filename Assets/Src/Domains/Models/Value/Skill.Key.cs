namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// スキルオブジェクト
    /// </summary>
    public partial class Skill
    {
        /// <summary>
        /// 内部からスキルを索引する際のキー
        /// </summary>
        public enum Key
        {
            /// <summary>
            /// 不屈
            /// </summary>
            INDOMITABLE = 00000,
            /// <summary>
            /// 穏やかの心
            /// </summary>
            GENTLE = 00001,
            /// <summary>
            /// 統率者の心得
            /// </summary>
            LEADER = 00002,
            /// <summary>
            /// 人心掌握
            /// </summary>
            HUMAN_CONTROL = 00003,

            /// <summary>
            /// 休息術
            /// </summary>
            RESTING = 10000,
            /// <summary>
            /// 指揮術
            /// </summary>
            COMMAND = 10001,
            /// <summary>
            /// 騎乗術
            /// </summary>
            RIDING = 10002,

            /// <summary>
            /// 生命力
            /// </summary>
            VITALITY = 20000,
            /// <summary>
            /// 持久力
            /// </summary>
            ENDURANCE = 20001,
            /// <summary>
            /// 精神力
            /// </summary>
            MENTAL = 20002,

            /// <summary>
            /// 筋力
            /// </summary>
            PHYSICAL = 20100,
            /// <summary>
            /// 耐久力
            /// </summary>
            DURABILITY = 20101,

            /// <summary>
            /// 魔力
            /// </summary>
            MAGICAL_POWER = 20200,
            /// <summary>
            /// 抵抗力
            /// </summary>
            RESISTANCE = 20201,

            /// <summary>
            /// 炎適応力
            /// </summary>
            FLAME_APTITUDE = 20300,
            /// <summary>
            /// 氷適応力
            /// </summary>
            ICE_APTITUDE = 20301,
            /// <summary>
            /// 雷適応力
            /// </summary>
            THUNDER_APTITUDE = 20302,
            /// <summary>
            /// 地適応力
            /// </summary>
            EARTH_APTITUDE = 20303,
            /// <summary>
            /// 風適応力
            /// </summary>
            WIND_APTITUDE = 20304,
            /// <summary>
            /// 重適応力
            /// </summary>
            GRAVITY_APTITUDE = 20305,
            /// <summary>
            /// 光適応力
            /// </summary>
            LIGHT_APTITUDE = 20306,
            /// <summary>
            /// 闇適応力
            /// </summary>
            DARK_APTITUDE = 20307,
            /// <summary>
            /// 命適応力
            /// </summary>
            LIFE_APTITUDE = 20308,
            /// <summary>
            /// 毒適応力
            /// </summary>
            POISON_APTITUDE = 20309,
        }
    }
}
