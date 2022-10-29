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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR_20._101_Zibereva_3
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void mass_lb_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        public int[] Sorting_Array(int[] array, int n)//метод сортировки массива
        {
            int index = 0;
            if (array[index] % 2 != 0)
            {
                for (int i = 1; i < n; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        int paste = array[i];
                        array[i] = array[index];
                        array[index] = paste;
                        index++;
                    }

                }
            }
            else
            {
                index++;
                for (int i = 2; i < n; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        int paste = array[i];
                        array[i] = array[index];
                        array[index] = paste;
                        index++;
                    }

                }
            }
            return array;
        }

        private void result_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(str_tb.Text);
                int t = Convert.ToInt32(top_tb.Text);
                int b = Convert.ToInt32(bottom_tb.Text);

               if (t>b)
               {
                    MessageBox.Show("Верхняя граница диапазона не может быть больше нижней границы. Введите верхнюю границу рамером меньше, чем нижняя граница.");
               }

                int[] array = new int[n];
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    array[i] = random.Next(t, b + 1); 
                    mass_lb.Items.Add(array[i]);
                }//генерация массива размером N в диапазоне от t до b
               

                array = Sorting_Array(array, n);//сортировка
                for (int i = 0; i < n; i++)
                {
                    sort_lb.Items.Add(array[i]);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильный формат данных. Введите данные заново.");
            }
        }

        private void mass_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void sort_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void sort_lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void clear_btn_Click(object sender, RoutedEventArgs e)//очищение полей
        {
            str_tb.Clear();
            top_tb.Clear();
            bottom_tb.Clear();
            mass_lb.Items.Clear();
            sort_lb.Items.Clear();
        }
    }
}