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
using System.Windows.Shapes;

namespace practica1._3
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        KINOPROKATPRACTICAEntities db = new KINOPROKATPRACTICAEntities();
        public Window1()
        {
            InitializeComponent();
            CountryDgr.ItemsSource = db.COUNTRY.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var con = new practica1._3.COUNTRY();
            con.Namee = CountryNameTbx.Text;

            db.COUNTRY.Add(con);
            db.SaveChanges();

            CountryDgr.ItemsSource = db.COUNTRY.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (CountryDgr.SelectedItem != null)
            {
                var con = CountryDgr.SelectedItem as COUNTRY;
                con.Namee = CountryNameTbx.Text;
                db.SaveChanges();
                CountryDgr.ItemsSource = db.COUNTRY.ToList();

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (CountryDgr.SelectedItem != null)
            {
                var con = CountryDgr.SelectedItem as COUNTRY;
                db.COUNTRY.Remove(con);
                db.SaveChanges();
                CountryDgr.ItemsSource = db.COUNTRY.ToList();

            }
        }
    }
}
