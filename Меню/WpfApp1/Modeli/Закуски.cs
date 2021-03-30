using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Modeli
{
    public class Закуски : Bludo
    {
        public string Name;
        public int Pricee;
        public int Sebestoim;
        public int Ves;
        public int Time;

        public string _name;
        public int _pricee, _sebestoim, _ves, _time;

        public Закуски (string Name, int Pricee, int Sebestoim, int Ves, int Time)
        {
            _name = Name;
            _pricee = Pricee;
            _sebestoim = Sebestoim;
            _ves = Ves;
            _time = Time;
        }

        public string name { get => _name; set => _name = value; }
        public int price { get => _pricee; set => _pricee = value; }
        public int sebestoim { get => _sebestoim; set => _sebestoim = value; }
        public int ves { get => _ves; set => _ves = value; }
        public int time { get => _time; set => _time = value; }
    }
}