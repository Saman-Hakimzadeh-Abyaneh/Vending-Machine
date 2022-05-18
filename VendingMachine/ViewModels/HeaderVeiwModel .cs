using Prism.Mvvm;
using Domain.Model;
using Domain.Interfaces;

namespace VendingMachine.ViewModels
{
    public class HeaderViewModel : BindableBase
    {
        public User CurrentUser { set; get; }

        public HeaderViewModel(IUserService userService)
        {
            CurrentUser = userService.Get("", "");
        }
    }
}