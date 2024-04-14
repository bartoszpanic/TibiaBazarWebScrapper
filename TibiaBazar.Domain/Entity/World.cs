using TibiaBazar.Domain.Enum;

namespace TibiaBazar.Domain.Entity
{
    public class World
    {
        public string Name { get; set; } = string.Empty;
        public Location Location { get; set; }
        public PvpType PvpType { get; set; }
        public BattleEye MyProperty { get; set; }
    }
}
