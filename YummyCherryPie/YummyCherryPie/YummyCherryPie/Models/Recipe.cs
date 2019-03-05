namespace YummyCherryPie.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Defines recipe as a set of components
    /// </summary>
    public class Recipe : BaseDBItem
    {
        public Recipe(int id, string name, double servingSize, Unit unit)
        {
            RecipeId = id;
            Name = name;
            ServingSize = servingSize;
            Unit = unit;
        }

        //public Recipe(string name, string description, int biscuitTemperature, TimeSpan biscuitTime, List<Component> components)
        //{
        //    Name = name;
        //    Description = description;
        //    BiscuitTemperature = biscuitTemperature;
        //    BiscuitTime = biscuitTime;
        //    Components = components;
        //}

        //public Recipe(int id, string name, string description, int biscuitTemperature, TimeSpan biscuitTime, List<Component> components)
        //{
        //    RecipeId = id;
        //    Name = name;
        //    Description = description;
        //    BiscuitTemperature = biscuitTemperature;
        //    BiscuitTime = biscuitTime;
        //    Components = components;
        //}

        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double ServingSize { get; set; }
        public Unit Unit { get; set; }
        public int BiscuitTemperature { get; set; }
        public TimeSpan BiscuitTime { get; set; }
        public List<RecipeLine> RecipeLines { get; set; }
    }
}
