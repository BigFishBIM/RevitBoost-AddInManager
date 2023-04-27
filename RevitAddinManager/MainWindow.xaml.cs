using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RevitAddinManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string All = "All";
        private const string UK = "Unknow";

        public MainWindow()
        {
            InitializeComponent();
            GetVersions();

            // Detect when skin changes
            versionBox.SelectionChanged += VersionBox_SelectionChanged;
        }

        private void GetVersions()
        {
            var versions = new Addins().Select(x => x.Version).Distinct().ToList();
            versions.Sort();
            for (int i = 0; i < versions.Count; i++)
            {
                if (versions[i] == string.Empty)
                {
                    versions[i] = UK;
                }
            }
            versions.Insert(0, All);
            versionBox.ItemsSource = versions;
        }

        private void Button_OpenClick(object sender, RoutedEventArgs e)
        {
            var dirs = new List<string>();
            foreach (Addin item in list.SelectedItems)
            {
                var dir = item.Filepath;
                dirs.Add(dir);
            }
            OpenExplorer.OpenFolderAndSelectedFiles(dirs);
        }

        private void VersionBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Change the skin
            var selectedValue = (string)e.AddedItems[0];
            var newAddins = new Addins();

            switch (selectedValue)
            {
                case (All):
                    list.ItemsSource = newAddins;
                    break;
                case (UK):
                    list.ItemsSource = newAddins.Where(x => x.Version == string.Empty);
                    break;
                default:
                    list.ItemsSource = newAddins.Where(x => x.Version == selectedValue);
                    break;
            }
        }

        private void Button_RefleshClick(object sender, RoutedEventArgs e)
        {
            GetVersions();
            // Detect when skin changes
            var vs = versionBox.SelectedItem;
            versionBox.SelectedItem = All;
            try
            {
                versionBox.SelectedItem = vs;
            }
            catch { }
        }
    }
}
