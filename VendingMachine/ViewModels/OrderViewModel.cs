using Prism.Mvvm;
using System.Linq;
using Domain.Models;
using Prism.Regions;
using Prism.Commands;
using System.Windows.Input;
using System.Threading.Tasks;
using VendingMachine.Handlers;
using System.Collections.Generic;

namespace VendingMachine.ViewModels
{
    public class OrderViewModel : BindableBase, INavigationAware
    {
        Recipe order;
        OrderStatus status;
        List<ActionStatus> actions;
        IRegionManager regionManager;
        IVendingMachine vendingMachine;
        ICommand cancelCommand, backCommand;

        public OrderStatus Status
        {
            set
            {
                status = value;
                RaisePropertyChanged("Status");
            }
            get { return status; }
        }
        public Recipe Order
        {
            set
            {
                order = value;
                RaisePropertyChanged("Order");
            }
            get { return order; }
        }
        public List<ActionStatus> Actions
        {
            set
            {
                actions = value;
                RaisePropertyChanged("Actions");
            }
            get { return actions; }
        }

        public ICommand CancelCommand
        {
            get
            {
                return cancelCommand ?? (cancelCommand = new DelegateCommand(() =>
                {
                    if (Status == OrderStatus.Doing)
                        Status = OrderStatus.Canceled;
                }));
            }
        }

        public ICommand BackCommand
        {
            get
            {
                return backCommand ?? (backCommand = new DelegateCommand(() =>
                {
                    regionManager.RequestNavigate("Body", "MenuView");
                }));
            }
        }

        public OrderViewModel(IVendingMachine vendingMachine, IRegionManager regionManager)
        {
            this.vendingMachine = vendingMachine;
            this.regionManager = regionManager;
        }

        public async void Brew()
        {
            Status = OrderStatus.Doing;
            for (int i = 0; i < Actions.Count && Status != OrderStatus.Canceled; i++)
            {
                Actions[i].State = States.Doing;
                await Task.Run(() =>
                {
                    switch (Actions[i].Action)
                    {
                        case ActionsEnum.AddCoffeeGranulesToCup:
                            vendingMachine.AddCoffeeGranulesToCupAsync();
                            break;
                        case ActionsEnum.AddCoffeeSyrupToBlender:
                            vendingMachine.AddCoffeeSyrupToBlenderAsync();
                            break;
                        case ActionsEnum.AddDrinkingChocolateToCup:
                            vendingMachine.AddDrinkingChocolateToCupAsync();
                            break;
                        case ActionsEnum.AddIceToBlender:
                            vendingMachine.AddIceToBlenderAsync();
                            break;
                        case ActionsEnum.AddIngredients:
                            vendingMachine.AddIngredientsAsync();
                            break;
                        case ActionsEnum.AddLemon:
                            vendingMachine.AddLemonAsync();
                            break;
                        case ActionsEnum.AddMilk:
                            vendingMachine.AddMilkAsync();
                            break;
                        case ActionsEnum.AddSugar:
                            vendingMachine.AddSugarAsync();
                            break;
                        case ActionsEnum.AddWater:
                            vendingMachine.AddWaterAsync();
                            break;
                        case ActionsEnum.BlendIngredients:
                            vendingMachine.BlendIngredientsAsync();
                            break;
                        case ActionsEnum.BoilWater:
                            vendingMachine.BoilWaterAsync();
                            break;
                        case ActionsEnum.CrushIce:
                            vendingMachine.CrushIceAsync();
                            break;
                        case ActionsEnum.SteepTeaBagInHotWater:
                            vendingMachine.SteepTeaBagInHotWaterAsync();
                            break;
                    }
                });
                Actions[i].State = States.Done;
            }
            if (Status != OrderStatus.Canceled)
                Status = OrderStatus.Done;
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            Order = (Recipe)(navigationContext.Parameters["Recipe"] as object[])[0];
            Actions = Order.Actions.Select(x => new ActionStatus
            {
                Action = x,
                State = States.Pending
            }).ToList();
            Brew();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }

    public enum OrderStatus
    {
        Doing,
        Done,
        Canceled
    }
}