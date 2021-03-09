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
using WpfApp1.Kontroler;
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
        Оформление оформление;
        int all_time; 
    
        public MainWindow()
        {
            InitializeComponent();
            Мое_Меню = new Меню();
            оформление = new Оформление();
            //Politkovskaya.ItemsSource = оформление.Islam;
            this.DataContext = Мое_Меню;
            Julia.ItemsSource = Мое_Меню.menu;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Number = Convert.ToInt32(Oksana.Text);
            оформление.Name = Ekaterina.Text;
            оформление.Сash = Convert.ToInt32(Naruto.Text) * Number;
            оформление.Sebest = Convert.ToInt32(PutinPresidentoftheworld) * Number;

            double Itog = 0;
            Itog += Convert.ToInt32(Naruto.Text) * Number;
            FinalpriceNavalny.Content = Itog.ToString();
            if (оформление.Time < Convert.ToInt32(KimJongUn)) ;
            оформление.Time = Convert.ToInt32(KimJongUn);

            // оформление.Islam.Add(оформление);

            Politkovskaya.Items.Add("Блюдо: " + оформление.Name + ", цена: " + оформление.Сash + "руб., себестоймость: " + оформление.Sebest + "руб., " + Number + "шт.");
            try
            {
                if (0 < Convert.ToInt32(Oksana.Text))
                {
                    /*Number = Convert.ToInt32(Oksana.Text);
                    Politkovskaya.ItemsSource = оформление.Islam;
                    оформление.Vybrat(Мое_Меню.menu [Julia.SelectedIndex], Number);
                    double Itog = 0;
                    foreach (Заказ zakaz in оформление.Islam)
                    {
                        Itog = zakaz.
                    .price * zakaz.Количество + Itog;
                    }
                    FinalpriceNavalny.Content = Itog.ToString();*/

                    Number = Convert.ToInt32(Oksana.Text);
                    оформление.Name = Ekaterina.Text;
                    оформление.Сash = Convert.ToInt32(Naruto.Text) * Number;
                    оформление.Sebest = Convert.ToInt32(PutinPresidentoftheworld) * Number;

                    Itog += Convert.ToInt32(Naruto.Text) * Number;
                    FinalpriceNavalny.Content = Itog.ToString();
                    if (оформление.Time < Convert.ToInt32(KimJongUn));
                    оформление.Time = Convert.ToInt32(KimJongUn);

                   // оформление.Islam.Add(оформление);

                    Politkovskaya.Items.Add("Блюдо: " + оформление.Name + ", цена: " + оформление.Сash + "руб., себестоймость: " + оформление.Sebest + "руб., " + Number + "шт.");
                }
                else
                {
                    MessageBox.Show("Совы не то, чем кажутся");
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Печеньки не то, чем кажутся");
                return;
            }

        }
    }
}
