using TibiaBazar.Domain.Enum;

namespace TibiaBazar.Domain.Entity;

public class Character
{
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; }
    public World World { get; set; } = new();
    public Vocation Vocation { get; set; }
    public Sex Sex { get; set; }
}
