using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Modeli;

namespace WpfApp1.Kontroler
{
    class Оформление
    {
        public int Itog;
        public int Time;
        public int Sebest;
        public int Сash;
        public string Name;
        public List<Заказ> Islam = new List<Заказ>();
        public List<Заказы> Lipton = new List<Заказы>();
        public Оформление()
        {
            Islam = new List<Заказ>();
            Lipton = new List<Заказы>();
        }
        public bool Vybrat(Bludo Yastva, int Velichie)
        {
            Заказ Lipton = new Заказ();
            Lipton.eda = Yastva;
            Lipton.Количество = Velichie;
            Islam.Add(Lipton);
            return true;
        }
        /*public bool Ovormit()
        {
            Itog = 0;
            foreach (Заказ Bogini in Islam)
            {
                Itog = Bogini.eda.price * Bogini.Количество + Itog;
            }
            Time = 0;
            foreach (Заказ Bogini in Islam)
            {
                if (Bogini.eda.time > Time)
                {
                    Time = Bogini.eda.time;
                }
            }
            Sebest = 0;
            foreach (Заказ Bogini in Islam)
            {
                Sebest = Bogini.eda.sebestoim * Bogini.Количество + Sebest;
            }
            Сash = 0;
            Сash = Itog - Sebest + Сash;
            Заказы Zakazy = new Заказы();
            Zakazy.SpisokBlud = Islam;
            Zakazy.Itog = Itog;
            Zakazy.Time = Time;
            Zakazy.Сash = Сash;
            Zakazy.Sebestoim = Sebest;
            Lipton.Add(Zakazy);
            Islam = new List<Заказ>();
            return true;
        }*/
    }
}