using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using DSAEditor.Views;


namespace DSAEditor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Datei-Menü
        private void NewFile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Neue Datei erstellen");
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON Dateien (*.json)|*.json|Alle Dateien (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                MessageBox.Show($"Datei geöffnet: {openFileDialog.FileName}");
            }
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Datei speichern");
        }

        private void SaveAsFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON Dateien (*.json)|*.json|Alle Dateien (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog() == true)
            {
                MessageBox.Show($"Datei gespeichert unter: {saveFileDialog.FileName}");
            }
        }

        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Bearbeiten-Menü
        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Rückgängig machen");
        }

        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wiederholen");
        }

        private void OpenSettings_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Einstellungen öffnen");
        }

        // Extras
        private void OpenOptions_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Optionen öffnen");
        }

        // Hilfe
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("DSA Charaktereditor - Version 1.0\nErstellt von Parios Avramidis");
        }

        private void ShowHelp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hilfe wird bald implementiert");
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
