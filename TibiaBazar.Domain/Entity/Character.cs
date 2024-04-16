using TibiaBazar.Domain.Enum;

namespace TibiaBazar.Domain.Entity;

public class Character
{
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; }
    public World World { get; set; } = new();
    public string Vocation { get; set; } = string.Empty;
    public Sex Sex { get; set; }
}



