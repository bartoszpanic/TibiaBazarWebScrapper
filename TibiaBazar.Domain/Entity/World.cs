using TibiaBazar.Domain.Enum;

namespace TibiaBazar.Domain.Entity
{
    public class World
    {
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string PvpType { get; set; } = string.Empty;
        public string BattleEye { get; set; } = string.Empty;
    }
}
