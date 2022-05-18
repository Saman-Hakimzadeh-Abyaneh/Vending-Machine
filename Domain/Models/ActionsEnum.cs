using System.ComponentModel;

namespace Domain.Models
{
    public enum ActionsEnum
    {
        [Description("Add coffee granules to cup")]
        AddCoffeeGranulesToCup,
        [Description("Add coffee syrup to blender")]
        AddCoffeeSyrupToBlender,
        [Description("Add drinking chocolate to cup")]
        AddDrinkingChocolateToCup,
        [Description("Add ice to blender")]
        AddIceToBlender,
        [Description("Add ingredients")]
        AddIngredients,
        [Description("Add lemon")]
        AddLemon,
        [Description("Add milk")]
        AddMilk,
        [Description("Add sugar")]
        AddSugar,
        [Description("Add water")]
        AddWater,
        [Description("Blend ingredients")]
        BlendIngredients,
        [Description("Boil water")]
        BoilWater,
        [Description("Crush ice")]
        CrushIce,
        [Description("Steep tea bag in hot water")]
        SteepTeaBagInHotWater,
    }
}