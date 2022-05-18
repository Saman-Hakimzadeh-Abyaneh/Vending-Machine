using Prism.Regions;
using System.Windows.Controls;

namespace VendingMachine.Views
{
    /// <summary>
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MenuView : UserControl
    {
        IRegionManager regionManager;

        public MenuView(IRegionManager regionManager)
        {
            this.regionManager = regionManager;

            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedItem != null)
            {
                NavigationParameters parameters = new NavigationParameters();
                parameters.Add("Recipe", e.AddedItems);
                regionManager.RequestNavigate("Body", "OrderView", parameters);
                listBox.SelectedItem = null;
            }
        }
    }
}
