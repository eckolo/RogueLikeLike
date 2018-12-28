using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Model.Value;

namespace Assets.Editor.TEST.Domain.Model.Mock
{
    /// <summary>
    /// <see cref="Npc">を利用するテスト用のモック
    /// </summary>
    public class NpcStationeryMock : NpcStationery
    {
        public NpcStationeryMock(Npc.Parameters parameters)
        {
            this.parameters = parameters;
        }

        /// <summary>
        /// 外部から参照されるスキルパラメータ
        /// </summary>
        public override Npc.Parameters parameters { get; }
    }
}
