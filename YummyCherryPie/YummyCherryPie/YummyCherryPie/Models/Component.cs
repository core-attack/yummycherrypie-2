namespace YummyCherryPie.Models
{

    /// <summary>
    /// Defines product component (egg, sugar, water etc)
    /// </summary>
    public class Component : BaseDBItem
    {
        public Component(string name, Unit unit)
        {
            Name = name;
            Unit = unit;
        }

        public Component(int id, string name, Unit unit)
        {
            ComponentId = id;
            Name = name;
            Unit = unit;
        }

        public int ComponentId { get; set; }
        public string Name { get; set; }
        public Unit Unit { get; set; }
    }
}
