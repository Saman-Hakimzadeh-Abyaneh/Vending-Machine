using System.Threading.Tasks;

namespace VendingMachine.Handlers
{
    public class SamVendingMachine : IVendingMachine
    {
        public void AddCoffeeGranulesToCupAsync()
        {
            Task.WaitAll(new Task[] { Task.Delay(1000) });
        }

        public void AddCoffeeSyrupToBlenderAsync()
        {
            Task.WaitAll(new Task[] { Task.Delay(1000) });
        }

        public void AddDrinkingChocolateToCupAsync()
        {
            Task.WaitAll(new Task[] { Task.Delay(1000) });
        }

        public void AddIceToBlenderAsync()
        {
            Task.WaitAll(new Task[] { Task.Delay(1000) });
        }

        public void AddIngredientsAsync()
        {
            Task.WaitAll(new Task[] { Task.Delay(1000) });
        }

        public void AddLemonAsync()
        {
            Task.WaitAll(new Task[] { Task.Delay(1000) });
        }

        public void AddMilkAsync()
        {
            Task.WaitAll(new Task[] { Task.Delay(1000) });
        }

        public void AddSugarAsync()
        {
            Task.WaitAll(new Task[] { Task.Delay(1000) });
        }

        public void AddWaterAsync()
        {
            Task.WaitAll(new Task[] { Task.Delay(1000) });
        }

        public void BlendIngredientsAsync()
        {
            Task.WaitAll(new Task[] { Task.Delay(1000) });
        }

        public void BoilWaterAsync()
        {
            Task.WaitAll(new Task[] { Task.Delay(1000) });
        }

        public void CrushIceAsync()
        {
            Task.WaitAll(new Task[] { Task.Delay(1000) });
        }

        public void SteepTeaBagInHotWaterAsync()
        {
            Task.WaitAll(new Task[] { Task.Delay(1000) });
        }
    }
}