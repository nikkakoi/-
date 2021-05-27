using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Program
    {
        public static Random r = new Random();

        /// <summary>
        /// Нырки
        /// </summary>
        public static int nirki = r.Next(1, 144
            );
        /// <summary>
        /// Мадагаскарская кряква
        /// </summary>
        public static int mdKrykva = r.Next(1, 145 - nirki);
        /// <summary>
        /// Шилохвость
        /// </summary>
        public static int shilohovst = r.Next(1, 146 - nirki - mdKrykva);
        /// <summary>
        /// Чернети
        /// </summary>
        public static int cherneti = r.Next(1, 147 - nirki - mdKrykva - shilohovst);
        /// <summary>
        /// Чернети 2
        /// </summary>
        public static int cherneti2 = r.Next(1, 148 - nirki - mdKrykva - shilohovst - cherneti);
        /// <summary>
        /// Гоголи
        /// </summary>
        public static int gogoli = 149 - nirki - mdKrykva - shilohovst - cherneti - cherneti2;



        public static void Main(string[] args)
        {
            Ducks[] duck = new Ducks[149];
            for (int i = 0; i <= nirki; i++)
            {
                duck[i] = new Ducks();
                duck[i].swim = true;
                duck[i].home = true;
                duck[i].name = "Нырки";
                duck[i].lake = 0;
                duck[i].homeId = 0;
                duck[i].characht = "Имя: Боб, Вес: 2.5кг, Размер лап: средний, Пол: мужской";
                duck[i].caught = 0;
                duck[i].num = i + 1;
            }
            for (int i = nirki; i <= nirki + mdKrykva; i++)
            {
                duck[i] = new Ducks();
                duck[i].swim = true;
                duck[i].name = "Мадагаскарская кряква";
                duck[i].lake = 0;
                duck[i].homeId = 0;
                duck[i].characht = "Имя: Адам, Вес: 2.7кг, Окрас крыльев: коричневый, Ловкость: высокая";
                duck[i].caught = 0;
                duck[i].num = i + 1;
            }
            for (int i = nirki + mdKrykva; i <= nirki + mdKrykva + shilohovst; i++)
            {
                duck[i] = new Ducks();
                duck[i].hide = true;
                duck[i].name = "Шилохвость";
                duck[i].lake = 0;
                duck[i].homeId = 0;
                duck[i].characht = "Имя: Дино, Вес: 2.8кг, Форма крыльев: эллиптическая, Выносливость: средняя";
                duck[i].caught = 0;
                duck[i].num = i + 1;
            }
            for (int i = nirki + mdKrykva + shilohovst; i <= nirki + mdKrykva + shilohovst + cherneti; i++)
            {
                duck[i] = new Ducks();
                duck[i].swim = true;
                duck[i].home = true;
                duck[i].name = "Чернетти";
                duck[i].lake = 1;
                duck[i].homeId = 1;
                duck[i].characht = "Имя: Боби, Вес: 3.4кг, Возраст: 7 лет, Окрас оперения: серый";
                duck[i].caught = 0;
                duck[i].num = i + 1;
            }
            for (int i = nirki + mdKrykva + shilohovst + cherneti; i <= nirki + mdKrykva + shilohovst + cherneti + cherneti2; i++)
            {
                duck[i] = new Ducks();
                duck[i].swim = true;
                duck[i].home = true;
                duck[i].name = "Чернетти";
                duck[i].lake = 1;
                duck[i].homeId = 1;
                duck[i].characht = "Имя: Алекс, Вес: 3.7кг, Любимое блюдо: молюски, Окрас оперения: темно серый";
                duck[i].caught = 0;
                duck[i].num = i + 1;
            }
            for (int i = nirki + mdKrykva + shilohovst + cherneti + cherneti2; i < 149; i++)
            {
                duck[i] = new Ducks();
                duck[i].play = true;
                duck[i].name = "Гоголи";
                duck[i].lake = 1;
                duck[i].homeId = 1;
                duck[i].characht = "Имя: Робс, Вес: 2.8кг, Форма хвоста: острая, Сила: средняя";
                duck[i].caught = 0;
                duck[i].num = i + 1;
            }

            Lake[] lakes = new Lake[2];
            lakes[0] = new Lake("Челан");
            lakes[1] = new Lake("Пос");


            Console.WriteLine($"Нырки: {nirki}");
            Console.WriteLine($"Мадагаскарская кряква: {mdKrykva}");
            Console.WriteLine($"Шилохвость: {shilohovst}");
            Console.WriteLine($"Чернети: {cherneti}");
            Console.WriteLine($"Чернети: {cherneti2}");
            Console.WriteLine($"Гоголи: {gogoli}");

            Console.WriteLine("Выберите номер утки, чтобы узнать о ней. Если хотите начать сезон охоты, введите 150");
            int var = Convert.ToInt32(Console.ReadLine());

            while (var != 150)
            {
                var = var - 1;
                duck[var].GetInfo();
                var = Convert.ToInt32(Console.ReadLine());
            } //утки рассказывают о себе
            if (var == 150)
            {
                int daynum = 1;
                for (int day = 1; day <= 7; day++)
                {

                    Console.WriteLine($"День {daynum}");
                    daynum = daynum + 1;

                    for (int k = 0; k < 149; k++)
                    {
                        if (duck[k].lake == 0)
                        {
                            lakes[0].count++;
                            if (duck[k].swim == true)
                            {
                                lakes[0].swimming++;
                            }
                            if (duck[k].hide == true)
                            {
                                lakes[0].hiding++;
                            }
                            if (duck[k].play == true)
                            {
                                lakes[0].playing++;
                            }

                        } //подсчет уток
                        if (duck[k].lake == 1)
                        {
                            lakes[1].count++;
                            if (duck[k].swim == true)
                            {
                                lakes[1].swimming++;
                            }
                            if (duck[k].hide == true)
                            {
                                lakes[1].hiding++;
                            }
                            if (duck[k].play == true)
                            {
                                lakes[1].playing++;
                            }
                        }
                    }
                    Console.WriteLine($"На первом озере - {lakes[0].count}"); //вывод озер
                    Console.WriteLine($"Плавающих - {lakes[0].swimming}");
                    Console.WriteLine($"Прячущихся - {lakes[0].hiding}");
                    Console.WriteLine($"Играющих - {lakes[0].playing}");
                    Console.WriteLine("----------------------------------"); //разделитель
                    Console.WriteLine($"На втором озере - {lakes[1].count}");
                    Console.WriteLine($"Плавающих - {lakes[1].swimming}");
                    Console.WriteLine($"Прячущихся - {lakes[1].hiding}");
                    Console.WriteLine($"Играющих - {lakes[1].playing}");
                    Console.WriteLine("----------------------------------"); //разделитель


                    int hunt = r.Next(4, 6); //охотники первой фермы
                    int hunt2 = r.Next(1, 11);
                    Console.WriteLine($"Охотники 1-й фермы поймали {hunt + hunt2}");

                    for (int i = 1; i <= hunt; i++)
                    {
                        int popal = r.Next(1, 149);
                        if (duck[popal].lake == 3 && duck[popal].lake == 4)
                        {
                            while (duck[popal].lake == 3 && duck[popal].lake == 4)
                            {
                                popal = r.Next(1, 149);
                            }
                        }
                        duck[popal].lake = 3;
                        duck[popal].caught = duck[popal].caught + 1;
                    }

                    for (int i = 1; i <= hunt2; i++)
                    {
                        int popal2 = r.Next(1, 149);
                        if (duck[popal2].lake == 3 && duck[popal2].lake == 4)
                        {
                            while (duck[popal2].lake == 3 && duck[popal2].lake == 4)
                            {
                                popal2 = r.Next(1, 149);
                            }
                        }
                        duck[popal2].lake = 3;
                        duck[popal2].caught = duck[popal2].caught + 1;
                    }


                    int hunt3 = r.Next(4, 7); //охотники второй фермы
                    int hunt4 = r.Next(2, 7);
                    Console.WriteLine($"Охотники 2-й фермы поймали {hunt3 + hunt4}");

                    for (int i = 1; i <= hunt; i++)
                    {
                        int popal3 = r.Next(1, 149);
                        if (duck[popal3].lake == 3 && duck[popal3].lake == 4)
                        {
                            while (duck[popal3].lake == 3 && duck[popal3].lake == 4)
                            {
                                popal3 = r.Next(1, 149);
                            }
                        }
                        duck[popal3].lake = 4;
                        duck[popal3].caught = duck[popal3].caught + 1;
                    }

                    for (int i = 1; i <= hunt2; i++)
                    {
                        int popal4 = r.Next(1, 149);
                        if (duck[popal4].lake == 3 && duck[popal4].lake == 4)
                        {
                            while (duck[popal4].lake == 3 && duck[popal4].lake == 4)
                            {
                                popal4 = r.Next(1, 149);
                            }
                        }
                        duck[popal4].lake = 4;
                        duck[popal4].caught = duck[popal4].caught + 1;
                    }

                    for (int i = 0; i < 149; i++) //побег с фермы
                    {
                        if (duck[i].lake == 3)
                        {
                            if (duck[i].swim == true && duck[i].home == true && duck[i].caught < 2)
                            {
                                duck[i].lake = duck[i].homeId;
                            }
                        }
                        if (duck[i].lake == 4)
                        {
                            if (duck[i].swim == true && duck[i].home == true && duck[i].caught < 2)
                            {
                                duck[i].lake = duck[i].homeId;
                            }
                        }
                    }

                    int farm1 = 0;
                    int farm2 = 0;

                    for (int i = 0; i < 149; i++)
                    {
                        if (duck[i].lake == 3)
                        {
                            farm1 = farm1 + 1;
                        }

                        if (duck[i].lake == 4)
                        {
                            farm2 = farm2 + 1;
                        }
                    } //подсчет кол-ва на фермах
                    Console.WriteLine("----------------------------------"); //разделитель
                    Console.WriteLine($"На ферме 1 - {farm1}");
                    Console.WriteLine($"На ферме 2 - {farm2}");
                    Console.WriteLine("----------------------------------"); //разделитель
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    lakes[0].count = 0;
                    lakes[0].swimming = 0;
                    lakes[0].hiding = 0;
                    lakes[0].playing = 0;

                    lakes[1].count = 0;
                    lakes[1].swimming = 0;
                    lakes[1].hiding = 0;
                    lakes[1].playing = 0;
                }
            }
        }
    }
}
