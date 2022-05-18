using Prism.Regions;
using System.Windows;

namespace VendingMachine.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();

            regionManager.RegisterViewWithRegion("Header", typeof(HeaderView));
            regionManager.RegisterViewWithRegion("Body", typeof(MenuView));
        }
    }
}