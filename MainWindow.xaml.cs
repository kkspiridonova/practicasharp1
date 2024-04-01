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
            DirectorCountryIDCbx.ItemsSource = director.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                director.InsertQuery(DirectorNameTbx.Text, DirectorLastNameTbx.Text, Convert.ToInt32(DirectorCountryIDCbx.SelectedValue));
                DirectorDgr.ItemsSource = director.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var id = Convert.ToInt32((DirectorDgr.SelectedItem as DataRowView).Row[0]);
            director.UpdateQuery(DirectorNameTbx.Text, DirectorLastNameTbx.Text, Convert.ToInt32(DirectorCountryIDCbx.Text), id);
            DirectorDgr.ItemsSource = director.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (DirectorDgr.SelectedItem != null)
            {
                var id = Convert.ToInt32((DirectorDgr.SelectedItem as DataRowView).Row[0]);
                director.DeleteQuery(Convert.ToInt32(id));
                DirectorDgr.ItemsSource = director.GetData();
            }

        }
    }
}
