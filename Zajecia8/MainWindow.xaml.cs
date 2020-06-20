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

namespace Zajecia8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int allAnsw = 0;
        Dictionary<string, int> answ = new Dictionary<string, int>()
        {
            {"A", 0 },
            {"B", 0 },
            {"C", 0 },
            {"D", 0 }
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var b = (Button)sender;
            string choice = b.Content.ToString();
            answ[choice]++;
            allAnsw++;
            textBoxAllAnsw.Text = allAnsw.ToString();

            var maxheight = Canvas1.ActualHeight;

            A.Height = maxheight * (answ["A"] / (double)allAnsw);
            B.Height = maxheight * (answ["B"] / (double)allAnsw);
            C.Height = maxheight * (answ["C"] / (double)allAnsw);
            D.Height = maxheight * (answ["D"] / (double)allAnsw);

            
        }
    }
}
