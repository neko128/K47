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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XmlMaint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool gameEdited = false;
        private int gameSelectedIndex = -1;

        public MainWindow()
        {
            InitializeComponent();

            // Load games.
            //TODO

            // Load books.
            // Possibly filtered by games.
            //TODO

            // Load factions.
            // Possibly filtered by games or books.
            //TODO

            // Load Unit Structures.
            // Possibly filtered by books or factions.
            //TODO

            // Load units.
            // Possibly filtered by games, books, factions, unit structures.
            //TODO
        }

        private void gamesCmbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (gameEdited)
                if (MessageBox.Show("Are you sure you want to discard your edits?", "Save?", MessageBoxButton.OKCancel) != MessageBoxResult.OK)
                {
                    // Revert the changed selection.
                    gamesCmbBox.SelectedIndex = gameSelectedIndex;
                    return;
                }

            // Either it isn't edited or they say we're okay to discard it.
            gamesTxtBox.Text = gamesCmbBox.Text;
            gamesValTxtBox.Text = gamesCmbBox.SelectedValue.ToString();
            gameSelectedIndex = gamesCmbBox.SelectedIndex;
            gameEdited = false;
        }
    }
}
