using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using YummyCherryPie.Models;

[assembly: Xamarin.Forms.Dependency(typeof(YummyCherryPie.Services.MockUnitDataStore))]
namespace YummyCherryPie.Services
{
    public class MockUnitDataStore : IDataStore<Unit>
    {
        List<Unit> Units;

        public MockUnitDataStore()
        {
            Units = new List<Unit>
            {
                new Unit { UnitId = 1, ShortName = "tsp", FullName="teaspoon" },
                new Unit { UnitId = 2, ShortName = "tbs", FullName="tablespoon" },
                new Unit { UnitId = 3, ShortName = "fl oz", FullName="fluid ounce" },
                new Unit { UnitId = 4, ShortName = "gill", FullName="about 1/2 cup" },
                new Unit { UnitId = 5, ShortName = "c", FullName="cup" },
                new Unit { UnitId = 6, ShortName = "pt", FullName="pint" },
                new Unit { UnitId = 7, ShortName = "qt", FullName="quart" },
                new Unit { UnitId = 8, ShortName = "gal", FullName="gallon" },
                new Unit { UnitId = 9, ShortName = "ml", FullName="milliliter" },
                new Unit { UnitId = 10, ShortName = "l", FullName="liter" },
                new Unit { UnitId = 11, ShortName = "dl", FullName="deciliter" },
                new Unit { UnitId = 12, ShortName = "lb", FullName="pound" },
                new Unit { UnitId = 13, ShortName = "oz", FullName="ounce" },
                new Unit { UnitId = 14, ShortName = "mg", FullName="milligram" },
                new Unit { UnitId = 15, ShortName = "g", FullName="gram" },
                new Unit { UnitId = 16, ShortName = "kg", FullName="kilogram" },
                new Unit { UnitId = 17, ShortName = "p", FullName="piece" },
            };
        }

        public async Task<bool> AddItemAsync(Unit unit)
        {
            Units.Add(unit);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Unit unit)
        {
            var u = Units.Where((Unit arg) => arg.UnitId == unit.UnitId).FirstOrDefault();
            Units.Remove(u);
            Units.Add(unit);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Unit unit)
        {
            var u = Units.Where((Unit arg) => arg.UnitId == unit.UnitId).FirstOrDefault();
            Units.Remove(u);

            return await Task.FromResult(true);
        }

        public async Task<Unit> GetItemAsync(int id)
        {
            return await Task.FromResult(Units.FirstOrDefault(s => s.UnitId == id));
        }

        public async Task<IEnumerable<Unit>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(Units);
        }
    }
}