using Prism.Mvvm;
using Domain.Models;
using Domain.Interfaces;
using System.Collections.Generic;

namespace VendingMachine.ViewModels
{
    public class MenuViewModel : BindableBase
    {
        public List<Recipe> Recipes { set; get; }

        public MenuViewModel(IRecipeService recipeService)
        {
            Recipes = recipeService.GetAll();
        }
    }
}