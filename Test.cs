using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popovv
{
    class Test : Quetions
    {
        public List<Quetions> Sciense = new List<Quetions>();
        public List<Quetions> Med = new List<Quetions>();
        public List<Quetions> It = new List<Quetions>();
        public void CreateSciense()
        {
            Quetions quetions = new Quetions();
            quetions.Quetion = "Фамилия Илона";
            quetions.Right = "Маск";
            quetions.Wrong = "Каск";
            Sciense.Add(quetions);

            Quetions quetion1 = new Quetions();
            quetion1.Quetion = "Имя Маска";
            quetion1.Right = "Илон";
            quetion1.Wrong = "Саня";
            Sciense.Add(quetion1);

            Quetions quetions2 = new Quetions();
            quetions2.Quetion = "Н. Тесла это...";
            quetions2.Right = "Ученый";
            quetions2.Wrong = "Жмых";
            Sciense.Add(quetions2);

            Quetions quetions3 = new Quetions();
            quetions3.Quetion = "Что такое V";
            quetions3.Right = "Вольтаж";
            quetions3.Wrong = "Растояние";
            Sciense.Add(quetions3);

            Quetions quetion4 = new Quetions();
            quetion4.Quetion = "2 + 2 = ";
            quetion4.Right = "4";
            quetion4.Wrong = "5";
            Sciense.Add(quetion4);

            Quetions quetion5 = new Quetions();
            quetion5.Quetion = "9 чи 10";
            quetion5.Right = "9";
            quetion5.Wrong = "10";
            Sciense.Add(quetion5);
        }
        public void CreateScienseMed()
        {
            Quetions quetions1 = new Quetions();
            quetions1.Quetion = "Что такое кровь";
            quetions1.Right = "Жидкость";
            quetions1.Wrong = "ПАсатижы";
            Med.Add(quetions1);

            Quetions quetions2 = new Quetions();
            quetions2.Quetion = "Где растут пальцы";
            quetions2.Right = "На ноге";
            quetions2.Wrong = "На руке";
            Med.Add(quetions2);

            Quetions quetions3 = new Quetions();
            quetions3.Quetion = "Где растут ногти";
            quetions3.Right = "Пальцы";
            quetions3.Wrong = "Серега";
            Med.Add(quetions3);

            Quetions quetions4 = new Quetions();
            quetions4.Quetion = "Кол-во хромосом";
            quetions4.Right = "46";
            quetions4.Wrong = "47";
            Med.Add(quetions4);

            Quetions quetions5 = new Quetions();
            quetions5.Quetion = "Глаза";
            quetions5.Right = "Да";
            quetions5.Wrong = "Нет";
            Med.Add(quetions5);

            Quetions quetions6 = new Quetions();
            quetions6.Quetion = "Сердце качает";
            quetions6.Right = "кровь";
            quetions6.Wrong = "Бит";
            Med.Add(quetions6);
        }
        public void CreateScienseIt()
        {
            Quetions quetions = new Quetions();
            quetions.Quetion = "Что такое микрофон";
            quetions.Right = "Да";
            quetions.Wrong = "Нет";
            It.Add(quetions);

            Quetions quetions1 = new Quetions();
            quetions1.Quetion = "C++ это";
            quetions1.Right = "Язык";
            quetions1.Wrong = "клавиатура";
            It.Add(quetions1);

            Quetions quetions2 = new Quetions();
            quetions2.Quetion = "Где стоит процессор";
            quetions2.Right = "в сокете";
            quetions2.Wrong = "в жопе";
            It.Add(quetions2);

            Quetions quetions3 = new Quetions();
            quetions3.Quetion = "видеокарта это";
            quetions3.Right = "Карта";
            quetions3.Wrong = "Видео";
            It.Add(quetions3);

            Quetions quetions4 = new Quetions();
            quetions4.Quetion = "Програмист это";
            quetions4.Right = "Сверхразум";
            quetions4.Wrong = "Дизайнер";
            It.Add(quetions4);

            Quetions quetions5 = new Quetions();
            quetions5.Quetion = "Что быстрее";
            quetions5.Right = "SSD";
            quetions5.Wrong = "HDD";
            It.Add(quetions5);
        }
    }
}
