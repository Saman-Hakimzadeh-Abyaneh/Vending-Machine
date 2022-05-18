using Domain.Models;
using Domain.Interfaces;
using System.Collections.Generic;

namespace VendingMachine.Services
{
    public class RecipeService : IRecipeService
    {
        public List<Recipe> GetAll()
        {
            return new List<Recipe>()
            {
                new Recipe
                {
                    Description = "Hot Chocolate",
                    ImagePath = "../Assets/hot_chocolate.jpg",
                    Actions = new List<ActionsEnum>()
                    {
                        ActionsEnum.BoilWater,
                        ActionsEnum.AddDrinkingChocolateToCup,
                        ActionsEnum.AddWater
                    }
                },
                new Recipe
                {
                    Description = "White Coffee with 1 sugar",
                    ImagePath = "../Assets/white_coffee.jpg",
                    Actions = new List<ActionsEnum>()
                    {
                        ActionsEnum.BoilWater,
                        ActionsEnum.AddSugar,
                        ActionsEnum.AddCoffeeGranulesToCup,
                        ActionsEnum.AddWater,
                        ActionsEnum.AddMilk
                    }
                },
                new Recipe
                {
                    Description = "Lemon Tea",
                    ImagePath = "../Assets/lemon_tea.jpg",
                    Actions = new List<ActionsEnum>()
                    {
                        ActionsEnum.BoilWater,
                        ActionsEnum.AddWater,
                        ActionsEnum.SteepTeaBagInHotWater,
                        ActionsEnum.AddLemon
                    }
                },
                new Recipe
                {
                    Description = "Iced Coffee",
                    ImagePath = "../Assets/iced_coffee.jpg",
                    Actions = new List<ActionsEnum>()
                    {
                        ActionsEnum.CrushIce,
                        ActionsEnum.AddIceToBlender,
                        ActionsEnum.AddCoffeeSyrupToBlender,
                        ActionsEnum.BlendIngredients,
                        ActionsEnum.AddIngredients
                    }
                }
            };
        }
    }
}