namespace VendingMachine.Handlers
{
    public interface IVendingMachine
    {
        void BoilWaterAsync();
        void AddDrinkingChocolateToCupAsync();
        void AddWaterAsync();
        void AddSugarAsync();
        void AddCoffeeGranulesToCupAsync();
        void AddMilkAsync();
        void SteepTeaBagInHotWaterAsync();
        void AddLemonAsync();
        void CrushIceAsync();
        void AddIceToBlenderAsync();
        void AddCoffeeSyrupToBlenderAsync();
        void BlendIngredientsAsync();
        void AddIngredientsAsync();
    }
}