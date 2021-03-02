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
using WpfApp1.Modeli;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Number;
        
        List<Bludo> f = new List<Bludo>();
        Меню Мое_Меню;
        public MainWindow()
        {
            InitializeComponent();
            Мое_Меню = new Меню();
            Julia.ItemsSource = Мое_Меню.menu;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (0 < Convert.ToInt32(Oksana.Text))
                {
                    Number = Convert.ToInt32(Oksana.Text);
                }
                else MessageBox.Show("Совы не то, чем кажутся");
            }
            catch (Exception)
            {
                MessageBox.Show("Печеньки не то, чем кажутся");
            }
        }
    }
}
