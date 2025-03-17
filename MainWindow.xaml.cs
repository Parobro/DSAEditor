using System.Windows;

namespace DSAEditor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Navigation zwischen Tabs (Hier später Logik hinzufügen)
        private void EditQuickAccess(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Schnellzugriff bearbeiten!");
        }

        private void NavigateToCharacter(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Charakterseite anzeigen!");
        }

        private void NavigateToTalents(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Talentseite anzeigen!");
        }

        private void NavigateToSpells(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zauberseite anzeigen!");
        }

        private void NavigateToEquipment(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ausrüstungsseite anzeigen!");
        }

        private void NavigateToInventory(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Inventarseite anzeigen!");
        }

        private void NavigateToSettings(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Einstellungen anzeigen!");
        }
    }
}
