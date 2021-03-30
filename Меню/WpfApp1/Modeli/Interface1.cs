using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Modeli
{
    public interface Bludo
    {
        // название блюда, цена, себестоимость, вес и длительность приготовления в минутах или секундах.
        string name { get; set; }
        int price { get; set; }
        int sebestoim { get; set; }
        int ves { get; set; }
        int time { get; set; }
    }
}