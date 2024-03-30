using System;
using System.Collections.Generic;
using System.Data;
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
using practica1._3.kinoprokarTableAdapters;


namespace practica1._3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        COUNTRYTableAdapter country = new COUNTRYTableAdapter();
        DIRECTORTableAdapter director = new DIRECTORTableAdapter();
        public MainWindow()
        {
            InitializeComponent();

            DirectorDgr.ItemsSource = director.GetData();//вывод таблицы в датагрид
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }
    }
}
