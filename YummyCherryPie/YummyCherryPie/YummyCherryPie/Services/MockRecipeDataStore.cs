using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using YummyCherryPie.Models;

[assembly: Xamarin.Forms.Dependency(typeof(YummyCherryPie.Services.MockRecipeDataStore))]
namespace YummyCherryPie.Services
{
    public class MockRecipeDataStore : IDataStore<Recipe>
    {
        List<Recipe> Recipes;
        MockUnitDataStore unitsMock = new MockUnitDataStore();
        MockComponentsDataStore componentsMock = new MockComponentsDataStore();

        public MockRecipeDataStore()
        {
            Recipes = new List<Recipe>();

            string[] recipeNames = new string[] 
            {
                "Шоколадный бисквит",
                "Сметанник",
                "Шифоновый бисквит с желтками",
                "Красный вельвет",
                "Цветной бисквит"
            };


            int recipeId = 1;
            foreach (string recipeName in recipeNames)
            {
                Recipe r = new Recipe(recipeId, recipeName, 2, unitsMock.GetItemAsync(16).Result);

                Recipes.Add(r);

                switch ((int)recipeId)
                {
                    case 1 /*"Шоколадный бисквит"*/:
                        {
                            var list = new List<RecipeLine>
                            {
                                new RecipeLine(2, r, componentsMock.GetItemAsync(1).Result),//яйцо 2
                                new RecipeLine(75, r, componentsMock.GetItemAsync(11).Result),//масло подсолнечное 75
                                new RecipeLine(150, r, componentsMock.GetItemAsync(13).Result),//молоко 150
                                new RecipeLine(120, r, componentsMock.GetItemAsync(5).Result),//сахар 120
                                new RecipeLine(100, r, componentsMock.GetItemAsync(14).Result),//какао 100
                                new RecipeLine(225, r, componentsMock.GetItemAsync(2).Result),//мука 225
                                new RecipeLine(5, r, componentsMock.GetItemAsync(6).Result),//сода 5
                                new RecipeLine(0, r, componentsMock.GetItemAsync(8).Result),//разрыхлитель 2
                                new RecipeLine(30, r, componentsMock.GetItemAsync(15).Result),//кофе 30
                            };

                            r.RecipeLines = list;
                        }
                        break;
                    case 2 /*"Сметанник"*/:
                        {
                            var list = new List<RecipeLine>
                            {
                                new RecipeLine(3, r, componentsMock.GetItemAsync(1).Result),//"яйцо 3"
                                new RecipeLine(400, r, componentsMock.GetItemAsync(5).Result),//сахар 400
                                new RecipeLine(750, r, componentsMock.GetItemAsync(17).Result),//сметана 750
                                new RecipeLine(500, r, componentsMock.GetItemAsync(2).Result),//мука 500
                                new RecipeLine(200, r, componentsMock.GetItemAsync(19).Result),//маргарин 200
                                new RecipeLine(5, r, componentsMock.GetItemAsync(6).Result),//сода 5
                            };

                            r.RecipeLines = list;
                        }
                        break;
                    case 3 /*"Шифоновый бисквит с желтками"*/:
                        {
                            var list = new List<RecipeLine>
                            {
                                new RecipeLine(3, r, componentsMock.GetItemAsync(1).Result),//яйцо 4
                                new RecipeLine(120, r, componentsMock.GetItemAsync(5).Result),//сахар 120
                                new RecipeLine(45, r, componentsMock.GetItemAsync(11).Result),//масло подсолнечное 45
                                new RecipeLine(52, r, componentsMock.GetItemAsync(13).Result),//молоко 52
                                new RecipeLine(90, r, componentsMock.GetItemAsync(2).Result),//мука 90
                                new RecipeLine(30, r, componentsMock.GetItemAsync(4).Result),//крахмал кукурузный 30
                                new RecipeLine(1, r, componentsMock.GetItemAsync(9).Result),//ванилин 1
                                new RecipeLine(100, r, componentsMock.GetItemAsync(16).Result),//кокос 100
                                new RecipeLine(1, r, componentsMock.GetItemAsync(8).Result),//разрыхлитель 1
                            };

                            r.RecipeLines = list;
                        }
                        break;
                    case 4 /*"Красный вельвет"*/:
                        {
                            var list = new List<RecipeLine>
                            {
                                new RecipeLine(200, r, componentsMock.GetItemAsync(2).Result),//200 гр. муки
                                new RecipeLine(160, r, componentsMock.GetItemAsync(5).Result),//160 гр. сахара
                                new RecipeLine(5, r, componentsMock.GetItemAsync(14).Result),//5 гр. какао
                                new RecipeLine(3, r, componentsMock.GetItemAsync(7).Result),//3 гр соли
                                new RecipeLine(15, r, componentsMock.GetItemAsync(8).Result),//15 гр разрыхлитель
                                new RecipeLine(90, r, componentsMock.GetItemAsync(53).Result),//90 гр белка (3 шт)
                                new RecipeLine(116, r, componentsMock.GetItemAsync(11).Result),//116 гр растительного масла
                                new RecipeLine(120, r, componentsMock.GetItemAsync(12).Result),//120 мл. кефира
                                new RecipeLine(1, r, componentsMock.GetItemAsync(9).Result),//1 гр ванилина
                                new RecipeLine(30, r, componentsMock.GetItemAsync(52).Result),//30 гр. краситель
                            };

                            r.RecipeLines = list;
                        }
                        break;
                    case 5 /*"Цветной бисквит"*/:
                        {
                            var list = new List<RecipeLine>
                            {
                                new RecipeLine(200, r, componentsMock.GetItemAsync(2).Result),//200 гр. муки
                                new RecipeLine(160, r, componentsMock.GetItemAsync(5).Result),//160 гр. сахара
                                new RecipeLine(5, r, componentsMock.GetItemAsync(14).Result),//5 гр. какао
                                new RecipeLine(3, r, componentsMock.GetItemAsync(7).Result),//3 гр соли
                                new RecipeLine(15, r, componentsMock.GetItemAsync(8).Result),//15 гр разрыхлитель
                                new RecipeLine(90, r, componentsMock.GetItemAsync(53).Result),//90 гр белка (3 шт)
                                new RecipeLine(116, r, componentsMock.GetItemAsync(11).Result),//116 гр растительного масла
                                new RecipeLine(120, r, componentsMock.GetItemAsync(12).Result),//120 мл. кефира
                                new RecipeLine(1, r, componentsMock.GetItemAsync(9).Result),//1 гр ванилина
                                new RecipeLine(30, r, componentsMock.GetItemAsync(52).Result),//30 гр. краситель
                            };

                            r.RecipeLines = list;
                        }
                        break;
                }

                recipeId++;
            }
        }

        public async Task<bool> AddItemAsync(Recipe recipe)
        {
            Recipes.Add(recipe);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Recipe Recipe)
        {
            var r = Recipes.Where((Recipe arg) => arg.RecipeId == Recipe.RecipeId).FirstOrDefault();
            Recipes.Remove(r);
            Recipes.Add(Recipe);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Recipe recipe)
        {
            var r = Recipes.Where((Recipe arg) => arg.RecipeId == recipe.RecipeId).FirstOrDefault();
            Recipes.Remove(r);

            return await Task.FromResult(true);
        }

        public async Task<Recipe> GetItemAsync(int id)
        {
            return await Task.FromResult(Recipes.FirstOrDefault(s => s.RecipeId == id));
        }

        public async Task<IEnumerable<Recipe>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(Recipes);
        }
    }
}