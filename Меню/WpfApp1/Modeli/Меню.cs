using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Modeli
{
    public class Меню
    {
        public List<Bludo> menu = new List<Bludo>();

        public Меню()

        {
            Bludo omuraisu = new Основныеблюда("Омурайсу", 135, 125, 100, 10); 
            Bludo gedza = new Основныеблюда("Гедза", 120, 110, 100, 10);
            Bludo udon = new Основныеблюда("Удон",130, 100, 100, 10);
            Bludo bento = new Основныеблюда("Бенто", 100, 70, 100, 10);

                menu.Add(omuraisu);
                menu.Add(gedza);
                menu.Add(udon);
                menu.Add(bento);

            Bludo оkonomiyaki = new Закуски("Окономияки", 45, 30, 90, 7);
            Bludo rollsr = new Закуски("Роллы", 30, 25, 100, 10);
            Bludo onigiri = new Закуски("Онигири", 25, 20, 110, 12);
            Bludo carpaccio = new Закуски("Карпаччо", 50, 45, 65, 6);

                menu.Add(оkonomiyaki);
                menu.Add(rollsr);
                menu.Add(onigiri);
                menu.Add(carpaccio);

            Bludo taiyaki = new Десерты("Тайяки", 150, 90, 50, 1);
            Bludo purin = new Десерты("Пурин", 45, 40, 50, 1);
            Bludo dango = new Десерты("Данго", 45, 25, 50, 1);
            Bludo warabimochi = new Десерты("Варабимоти", 300, 25, 200, 5);

                menu.Add(taiyaki);
                menu.Add(purin);
                menu.Add(dango);
                menu.Add(warabimochi);

            Bludo sake = new Напитки("Саке", 10, 5, 100, 0);
            Bludo tea = new Напитки("Чай", 30, 28, 100, 0);
            Bludo umeshu = new Напитки("Умэсю", 100, 99, 100, 0);
            Bludo asahi = new Напитки("Асахи", 90, 70, 100, 0);

                menu.Add(sake);
                menu.Add(tea);
                menu.Add(umeshu);
                menu.Add(asahi);
        }

    }
}
