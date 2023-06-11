using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
    {

     

        public MainWindow()
        {
            InitializeComponent();
            //Instead of xaml we can also use c# to create the application
            /*
			Grid grid = new Grid();
			this.Content = grid;
			Button button = new Button();
			button.FontSize = 26;
			WrapPanel wrapPanel = new WrapPanel();
			TextBlock textBlock = new TextBlock();
			textBlock.Text = "Code try";
			textBlock.Foreground = Brushes.Aquamarine;
			wrapPanel.Children.Add(textBlock);
			button.Content = wrapPanel;
			grid.Children.Add(button);
			*/
        }


        private void PageButton_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new PageExample());
        }
        private void PageButton2_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ListBoxSample());
        }
        private void PageButton3_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new TriggerSamples());
        }
    }


}
