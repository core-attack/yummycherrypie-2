[assembly: Xamarin.Forms.Dependency(typeof(YummyCherryPie.Services.MockComponentsDataStore))]
namespace YummyCherryPie.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using YummyCherryPie.Models;

    public class MockComponentsDataStore : IDataStore<Component>
    {
        List<Component> Components;

        MockUnitDataStore unitsMock = new MockUnitDataStore();

        public MockComponentsDataStore()
        {
            Components = new List<Component>
            {
                new Component(1, "яйца", unitsMock.GetItemAsync(17).Result),
                new Component(2, "мука", unitsMock.GetItemAsync(15).Result),
                new Component(3, "крахмал картофельный", unitsMock.GetItemAsync(15).Result),
                new Component(4, "крахмал кукурузный", unitsMock.GetItemAsync(15).Result),
                new Component(5, "сахар", unitsMock.GetItemAsync(15).Result),
                new Component(6, "сода", unitsMock.GetItemAsync(15).Result),
                new Component(7, "соль", unitsMock.GetItemAsync(15).Result),
                new Component(8, "разрыхлитель", unitsMock.GetItemAsync(15).Result),
                new Component(9, "ванилин", unitsMock.GetItemAsync(17).Result),
                new Component(10, "масло сливочное", unitsMock.GetItemAsync(15).Result),
                new Component(11, "масло подсолнечное", unitsMock.GetItemAsync(15).Result),
                new Component(12, "кефир", unitsMock.GetItemAsync(9).Result),
                new Component(13, "молоко", unitsMock.GetItemAsync(9).Result),
                new Component(14, "какао", unitsMock.GetItemAsync(15).Result),
                new Component(15, "кофе", unitsMock.GetItemAsync(15).Result),
                new Component(16, "кокос", unitsMock.GetItemAsync(15).Result),
                new Component(17, "сметана", unitsMock.GetItemAsync(9).Result),
                new Component(18, "мёд", unitsMock.GetItemAsync(9).Result),
                new Component(19, "маргарин", unitsMock.GetItemAsync(15).Result),
                new Component(20, "сгущенное молоко", unitsMock.GetItemAsync(9).Result),
                new Component(21, "шоколад", unitsMock.GetItemAsync(15).Result),
                new Component(22, "мастика для обтяжки", unitsMock.GetItemAsync(15).Result),
                new Component(23, "мастика для фигурок", unitsMock.GetItemAsync(15).Result),
                new Component(24, "загуститель для сметаны", unitsMock.GetItemAsync(15).Result),
                new Component(25, "грецкий орех", unitsMock.GetItemAsync(15).Result),
                new Component(26, "арахис", unitsMock.GetItemAsync(15).Result),
                new Component(27, "фундук", unitsMock.GetItemAsync(15).Result),
                new Component(28, "вареная сгущенка", unitsMock.GetItemAsync(9).Result),
                new Component(29, "мак", unitsMock.GetItemAsync(15).Result),
                new Component(30, "сироп банан", unitsMock.GetItemAsync(9).Result),
                new Component(31, "сироп кокос", unitsMock.GetItemAsync(9).Result),
                new Component(32, "соус шоколад", unitsMock.GetItemAsync(9).Result),
                new Component(33, "соус тоффи", unitsMock.GetItemAsync(9).Result),
                new Component(34, "соус малина", unitsMock.GetItemAsync(9).Result),
                new Component(35, "соус лесные ягоды", unitsMock.GetItemAsync(9).Result),
                new Component(36, "соус киви", unitsMock.GetItemAsync(9).Result),
                new Component(37, "ароматизатор ваниль", unitsMock.GetItemAsync(17).Result),
                new Component(38, "ароматизатор миндаль", unitsMock.GetItemAsync(17).Result),
                new Component(39, "ароматизатор ром", unitsMock.GetItemAsync(17).Result),
                new Component(40, "курага", unitsMock.GetItemAsync(15).Result),
                new Component(41, "чернослив", unitsMock.GetItemAsync(15).Result),
                new Component(42, "ананас консервированный", unitsMock.GetItemAsync(15).Result),
                new Component(43, "персики консервированные", unitsMock.GetItemAsync(15).Result),
                new Component(44, "клубника замороженная", unitsMock.GetItemAsync(15).Result),
                new Component(45, "вишня замороженная", unitsMock.GetItemAsync(15).Result),
                new Component(46, "лимон", unitsMock.GetItemAsync(15).Result),
                new Component(47, "апельсин", unitsMock.GetItemAsync(15).Result),
                new Component(48, "бананы", unitsMock.GetItemAsync(15).Result),
                new Component(49, "малина", unitsMock.GetItemAsync(15).Result),
                new Component(50, "клубника", unitsMock.GetItemAsync(15).Result),
                new Component(51, "черника", unitsMock.GetItemAsync(15).Result),
                new Component(52, "краситель", unitsMock.GetItemAsync(15).Result),
                new Component(53, "яйца (белок)", unitsMock.GetItemAsync(15).Result),
                new Component(54, "сливки", unitsMock.GetItemAsync(15).Result),
                new Component(55, "цукаты", unitsMock.GetItemAsync(15).Result),
                new Component(56, "миндаль", unitsMock.GetItemAsync(15).Result),
                new Component(57, "шоколадная плитка (белая)", unitsMock.GetItemAsync(15).Result),
                new Component(58, "имбирь", unitsMock.GetItemAsync(15).Result),
                new Component(59, "несквик", unitsMock.GetItemAsync(15).Result),
                new Component(60, "шарики для фигурок", unitsMock.GetItemAsync(15).Result),
                new Component(61, "желатин", unitsMock.GetItemAsync(15).Result),
            };
        }

        public async Task<bool> AddItemAsync(Component comp)
        {
            Components.Add(comp);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Component comp)
        {
            var c = Components.Where((Component arg) => arg.ComponentId == comp.ComponentId).FirstOrDefault();
            Components.Remove(c);
            Components.Add(comp);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Component comp)
        {
            var c = Components.Where((Component arg) => arg.ComponentId == comp.ComponentId).FirstOrDefault();
            Components.Remove(c);

            return await Task.FromResult(true);
        }

        public async Task<Component> GetItemAsync(int id)
        {
            return await Task.FromResult(Components.FirstOrDefault(s => s.ComponentId == id));
        }

        public async Task<IEnumerable<Component>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(Components);
        }
    }
}