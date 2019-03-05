namespace YummyCherryPie.Models
{
    /// <summary>
    /// Defines units of measurement (pint, ml, gramm, gallon etc). 
    /// </summary>
    public class Unit : BaseDBItem
    {
        //public Unit(string name, string fullName)
        //{
        //    ShortName = name;
        //    FullName = fullName;
        //}

        //public Unit(short id, string name, string fullName)
        //{
        //    UnitId = id;
        //    ShortName = name;
        //    FullName = fullName;
        //}

        public short UnitId { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
    }
}
