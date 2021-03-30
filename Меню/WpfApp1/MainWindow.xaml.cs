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
        

        Меню Мое_Меню;
        Оформление оформление;
<<<<<<< HEAD
        int Itog;


=======
        int all_time; 
    
>>>>>>> 57740f21e4723f4197f0cffcec6b1e94ddcf3899
        public MainWindow()
        {
            InitializeComponent();
            Мое_Меню = new Меню();
            оформление = new Оформление();
<<<<<<< HEAD
=======
            //Politkovskaya.ItemsSource = оформление.Islam;
>>>>>>> 57740f21e4723f4197f0cffcec6b1e94ddcf3899
            this.DataContext = Мое_Меню;
            Julia.ItemsSource = Мое_Меню.menu;
            Bulkfrog.ItemsSource = оформление.Lipton;
            Oksana.Text = Convert.ToString(1);
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
<<<<<<< HEAD
                    Politkovskaya.ItemsSource = оформление.Islam;
                    оформление.Vybrat(Мое_Меню.menu [Julia.SelectedIndex], Number);
                    
                    foreach (Заказ zakaz in оформление.Islam)
                    {
                        Itog = zakaz.eda.price * zakaz.Количество + Itog;
                    }
                    FinalpriceNavalny.Content = Itog.ToString();
=======
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
>>>>>>> 57740f21e4723f4197f0cffcec6b1e94ddcf3899
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Печеньки не то, чем кажутся");
                return;
            }

<<<<<<< HEAD
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            оформление.clean_off();
            Politkovskaya.ItemsSource = оформление.Islam;
            Itog = 0;
            FinalpriceNavalny.Content = Itog.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            оформление.Ovormit();
            Politkovskaya.ItemsSource = оформление.Islam;
            Itog = 0;
            FinalpriceNavalny.Content = Itog.ToString();
        }

        private void Bulkfrog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Politkovskaya.ItemsSource = оформление.Lipton[Bulkfrog.SelectedIndex].SpisokBlud;
=======
>>>>>>> 57740f21e4723f4197f0cffcec6b1e94ddcf3899
        }
    }
}
