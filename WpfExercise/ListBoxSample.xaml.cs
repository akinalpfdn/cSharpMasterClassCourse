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

namespace WpfExercise
{
    /// <summary>
    /// Interaction logic for ListBoxSample.xaml
    /// </summary>
    public partial class ListBoxSample : Page
    {
        public ListBoxSample()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>()
            {
                new Match() {Team1 = "Petrol City", Team2 = "Inter", Score1 =3 , Score2 =1, Completion = 90},
                new Match() {Team1 = "Real Madrid", Team2 = "Barselona", Score1 =3 , Score2 =4, Completion = 88},
                new Match() {Team1 = "FenerBahce", Team2 = "Galatasaray", Score1 =0 , Score2 =1, Completion = 11}
            };
            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbMatches.SelectedItem!= null)
            {
                MessageBox.Show("Selected Match: " + (lbMatches.SelectedItem as Match).Team1 + " vs " + (lbMatches.SelectedItem as Match).Team2);
            }
        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }
    }
}
