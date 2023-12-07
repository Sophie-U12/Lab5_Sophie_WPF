using ComponentModel;
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

namespace Lab5_Sophie_WPF
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(tbStart.Text, out double start) &&
                double.TryParse(tbEnd.Text, out double end) &&
                double.TryParse(tbStep.Text, out double step) &&
                int.TryParse(tbN.Text, out int N) && N > 1 &&
                (start > (-3d * Math.PI) && start < (3d * Math.PI)) &&
                (end > (-3d * Math.PI) && end < (3d * Math.PI)) && start < end && step > 0)
            {
                lbResult.Items.Clear();

                for(double i = start; i <= end; i += step)
                {
                    double result = Component.ExpFor(i, N);
                    lbResult.Items.Add($"x: {i} | r: {result}");
                }
            }
            else
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void btnCalculate2_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(tbStart.Text, out double start) &&
                double.TryParse(tbEnd.Text, out double end) &&
                double.TryParse(tbStep.Text, out double step) &&
                int.TryParse(tbN.Text, out int N) && N > 1 &&
                (start > (-3d * Math.PI) && start < (3d * Math.PI)) &&
                (end > (-3d * Math.PI) && end < (3d * Math.PI)) && start < end && step > 0)
            {
                lbResult.Items.Clear();

                for (double i = start; i <= end; i += step)
                {
                    double result = Component.ExpRec(i, N);
                    lbResult.Items.Add($"x: {i} | r: {result}");
                }
            }
            else
            {
                MessageBox.Show("Помилка!");
            }
        }
    }
}
