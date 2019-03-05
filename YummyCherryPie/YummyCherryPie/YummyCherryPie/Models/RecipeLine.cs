using System;
using System.Collections.Generic;
using System.Text;

namespace YummyCherryPie.Models
{
    /// <summary>
    /// Defines recipe line as the relation between Recipe and Components
    /// </summary>
    public class RecipeLine
    {
        public RecipeLine(double servingSize, Recipe recipe, Component component)
        {
            ServingSize = servingSize;
            Recipe = recipe;
            Component = component;
        }

        public int RecipeLineId { get; set; }
        public double ServingSize { get; set; }
        public Recipe Recipe { get; set; }
        public Component Component { get; set; }
    }
}
