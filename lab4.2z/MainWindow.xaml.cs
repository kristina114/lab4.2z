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

namespace lab4._2z
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ansver_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(textbox3.Text, out int A))
            {
                MessageBox.Show("Введите число А в поле ");
            }
            if (!int.TryParse(textbox5.Text, out int B))
            {
                MessageBox.Show("Введите число B в поле");
            }
             if (A!=B)
            {
                if (A > B)
                {
                    B = A;
                }
               else
                {
                    A = B;
                }                          
            }
             else
            {
                A = 0;
                B = 0;
            }

            
              textbox2.Text = ($"A={A} B={B}").ToString();
            
            
            
           
            
        }
}   }