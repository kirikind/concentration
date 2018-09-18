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
using System.Text.RegularExpressions;
using System.Threading;

namespace концентрация_на_работу
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private int time;
        private string workidiscription;

        public MainWindow()
        {
            InitializeComponent();

            StartTimer();

        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void StartTimer()
        {
            time = Int32.Parse(worktimeTBox.Text);
            workidiscription = workidiscriptionTbox.Text;
        }
       

        void Timer(string[] args)
        {
            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(Count);
            // создаем таймер
            Timer timer = new Timer(tm, num, 0, 1000);
        }

        public void Count(object obj)
        {
            int x = time;
            for (int i = 0; i < x*60; i++)
            {
                
            }
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            StartTimer();
        }
    }
}
