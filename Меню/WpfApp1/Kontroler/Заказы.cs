using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Kontroler
{
    struct Заказы
    {
        public double Itog { get; set; }
        public int Time { get; set; }
        public int Ves { get; set; }
        public double Sebestoim { get; set; }
        public double Сash { get; set; }
        public ObservableCollection<Заказ> SpisokBlud;
    }
}
