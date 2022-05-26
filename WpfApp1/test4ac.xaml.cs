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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for test4ac.xaml
    /// </summary>
    public partial class test4ac : Window
    {
        public test4ac()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string Age = Console.ReadLine();
            string Profile = Console.ReadLine();
            string Sportsteacher = Console.ReadLine();
            string Advisor = Console.ReadLine();
            string GPA = Console.ReadLine();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            testlast pg9 = new testlast();
            pg9.Show();
            this.Close();
        }
    }
}
