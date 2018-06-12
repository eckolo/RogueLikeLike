namespace Assets.Src.Domains.Value
{
    /// <summary>
    /// キーの押下タイミング
    /// </summary>
    public enum KeyTiming
    {
        /// <summary>
        /// 押した瞬間
        /// </summary>
        DOWN,
        /// <summary>
        /// 押している状態
        /// </summary>
        ON,
        /// <summary>
        /// 離した瞬間
        /// </summary>
        UP,
        /// <summary>
        /// 押していない状態
        /// </summary>
        OFF
    }
}
