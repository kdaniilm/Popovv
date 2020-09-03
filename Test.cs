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
            quetions.Quetion = "Имя Маска";
            quetions.Right = "Илон";
            quetions.Wrong = "Саня";
            Sciense.Add(quetion1);

            Quetions quetions2 = new Quetions();
            quetions.Quetion = "Н. Тесла это...";
            quetions.Right = "Ученый";
            quetions.Wrong = "Жмых";
            Sciense.Add(quetions2);

            Quetions quetions3 = new Quetions();
            quetions.Quetion = "Что такое V";
            quetions.Right = "Вольтаж";
            quetions.Wrong = "Растояние";
            Sciense.Add(quetions3);

            Quetions quetion4 = new Quetions();
            quetions.Quetion = "2 + 2 = ";
            quetions.Right = "4";
            quetions.Wrong = "5";
            Sciense.Add(quetion4);

            Quetions quetion5 = new Quetions();
            quetions.Quetion = "9 чи 10";
            quetions.Right = "9";
            quetions.Wrong = "10";
            Sciense.Add(quetion5);
        }
        public void CreateScienseMed()
        {
            Quetions quetions = new Quetions();
            quetions.Quetion = "Что такое кровь";
            quetions.Right = "Жидкость";
            quetions.Wrong = "ПАсатижы";
            Med.Add(quetions);

            quetions.Quetion = "Где растут пальцы";
            quetions.Right = "На ноге";
            quetions.Wrong = "На руке";
            Med.Add(quetions);

            quetions.Quetion = "Где растут ногти";
            quetions.Right = "Пальцы";
            quetions.Wrong = "Серега";
            Med.Add(quetions);

            quetions.Quetion = "Кол-во хромосом";
            quetions.Right = "46";
            quetions.Wrong = "47";
            Med.Add(quetions);

            quetions.Quetion = "Глаза";
            quetions.Right = "Да";
            quetions.Wrong = "Нет";
            Med.Add(quetions);

            quetions.Quetion = "Сердце качает";
            quetions.Right = "кровь";
            quetions.Wrong = "Бит";
            Med.Add(quetions);
        }
        public void CreateScienseIt()
        {
            Quetions quetions = new Quetions();
            quetions.Quetion = "Что такое микрофон";
            quetions.Right = "Да";
            quetions.Wrong = "Нет";
            It.Add(quetions);

            quetions.Quetion = "C++ это";
            quetions.Right = "Язык";
            quetions.Wrong = "клавиатура";
            It.Add(quetions);

            quetions.Quetion = "Где стоит процессор";
            quetions.Right = "в сокете";
            quetions.Wrong = "в жопе";
            It.Add(quetions);

            quetions.Quetion = "видеокарта это";
            quetions.Right = "Карта";
            quetions.Wrong = "Видео";
            It.Add(quetions);

            quetions.Quetion = "Програмист это";
            quetions.Right = "Сверхразум";
            quetions.Wrong = "Дизайнер";
            It.Add(quetions);

            quetions.Quetion = "Что быстрее";
            quetions.Right = "SSD";
            quetions.Wrong = "HDD";
            It.Add(quetions);
        }
    }
}
