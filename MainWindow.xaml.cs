using System;
using System.Windows;
using System.Windows.Controls;
using DSAEditor.Views;


namespace DSAEditor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Dynamische Navigation: ContentControl mit UserControls aktualisieren
        private void NavigateToCharacter(object sender, RoutedEventArgs e)
        {
            MainContentArea.Content = new Views.CharacterView();
        }

        private void EditQuickAccess(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Quick-Access bearbeiten wird später implementiert!");
        }

        private void NavigateToTalents(object sender, RoutedEventArgs e)
        {
            MainContentArea.Content = new Views.TalentsView();
        }

        private void NavigateToSpells(object sender, RoutedEventArgs e)
        {
            MainContentArea.Content = new Views.SpellsView();
        }

        private void NavigateToEquipment(object sender, RoutedEventArgs e)
        {
            MainContentArea.Content = new Views.EquipmentView();
        }

        private void NavigateToInventory(object sender, RoutedEventArgs e)
        {
            MainContentArea.Content = new Views.InventoryView();
        }

        private void NavigateToSettings(object sender, RoutedEventArgs e)
        {
            MainContentArea.Content = new Views.SettingsView();
        }
    }
}
