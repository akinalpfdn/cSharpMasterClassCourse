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
    /// Interaction logic for PageExample.xaml
    /// </summary>
    public partial class PageExample : Page
    {
        public Sum SumObj { get; set; }
        public PageExample()
        {
            SumObj = new Sum { Num1 = "1", Num2 = "3" };
            InitializeComponent();
            this.DataContext = SumObj;
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
