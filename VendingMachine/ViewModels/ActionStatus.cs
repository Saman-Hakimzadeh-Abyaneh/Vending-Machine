using Prism.Mvvm;
using Domain.Models;

namespace VendingMachine.ViewModels
{
    public class ActionStatus : BindableBase
    {
        States state;

        public ActionsEnum Action { set; get; }
        public States State
        {
            set
            {
                state = value;
                RaisePropertyChanged("State");
            }
            get { return state; }
        }
    }

    public enum States
    {
        Pending,
        Doing,
        Done
    }
}