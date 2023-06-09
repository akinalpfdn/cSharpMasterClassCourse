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

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Mouse Clicked");
		}

		private void Button_MouseUp(object sender, MouseButtonEventArgs e)
		{
			MessageBox.Show("Mouse up");

		}

		private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
		{

			//MessageBox.Show("Mouse up");
		}
	}
}
