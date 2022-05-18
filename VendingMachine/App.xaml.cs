using Prism.Ioc;
using Prism.Unity;
using System.Windows;
using Domain.Interfaces;
using VendingMachine.Views;
using VendingMachine.Services;
using VendingMachine.Handlers;

namespace VendingMachine
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve(typeof(MainWindow)) as Window;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IUserService, UsersService>();
            containerRegistry.Register<IRecipeService, RecipeService>();
            containerRegistry.Register<IVendingMachine, SamVendingMachine>();

            containerRegistry.RegisterForNavigation<MenuView>();
            containerRegistry.RegisterForNavigation<OrderView>();
        }
    }
}