using System;

namespace ConsoleApp2
{
    class Pet
    {
        public int satiety = 55;
        public int thirst = 55;
        public int toilet = 25;
        public int fatigue = 25;
        public bool check = false;
        public void Enter()
        {
            Console.WriteLine("1. Покормить питомца");
            Console.WriteLine("2. Дать воды питомцу");
            Console.WriteLine("3. Сводить в туалет питомца");
            Console.WriteLine("4. Поиграть с питомцем");
        }

        public void Check_Information()
        {
            if (satiety > 100)
            {
                Console.WriteLine("Ваш питомец умер от переедания");
                check = true;
            }
            else
            if (satiety <= 0)
            {
                Console.WriteLine("Ваш питомец умер от голода");
                check = true;
            }

            if (thirst > 100)
            {
                Console.WriteLine("Ваш питомец умер от большого кол-ва воды");
                check = true;
            }
            else
            if (thirst <= 0)
            {
                Console.WriteLine("Ваш питомец умер от обезвоживания");
                check = true;
            }

            if (toilet <= 0)
            {
                toilet = 0;
            }
            if (toilet > 100)
            {
                Console.WriteLine("Ваш питомец умер от обезвоживания");
                check = true;
            }
            else
            if (toilet > 100)
            {
                Console.WriteLine("Ваш питомец сделал свои дела на ковер");
                toilet -= 35;
            }

            if (fatigue > 100)
            {
                fatigue = 100;
            }
            else
            if (fatigue <= 0)
            {
                Console.WriteLine("Ваш питомец умер от скуки :c");
                check = true;
            }
        }
        public void Information()
        {
            Console.WriteLine("Информация о параметрах питомца: ");
            Console.WriteLine("Сытность: " + satiety);
            Console.WriteLine("Жажда: " + thirst);
            Console.WriteLine("Сводить в туалет: " + toilet);
            Console.WriteLine("Выгулять питомца: " + fatigue);
            Console.WriteLine("");
        }
        public void Satiety()
        {
            satiety += 25;
            thirst -= 10;
            toilet += 5;
            fatigue += 15;
        }

        public void Thirst()
        {
            satiety += 5;
            thirst += 15;
            toilet += 10;
            fatigue -= 5;
        }

        public void Toilet()
        {
            satiety -= 20;
            thirst -= 15;
            toilet -= 25;
        }

        public void Fatigue()
        {
            satiety -= 15;
            thirst -= 15;
            toilet += 15;
            fatigue += 15;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int NumberPets = 0;
            int Number = 0;
            Pet pet = new Pet();
            
            tryE:
            Console.WriteLine("Выберите питомца:\n1. Кот\n2. Собака");
            NumberPets = Convert.ToInt32(Console.ReadLine());

            switch (NumberPets)
            {      
                case 1:
                    {
                        Console.WriteLine("Если вы желаете закрыть тамагочи, введите цифру 5");

                        catS:

                        Console.Clear();

                        pet.Check_Information();
                        if (pet.check == true)
                        {
                            goto end;
                        }

                        pet.Information();

                        Console.WriteLine("Выберите один из пунктов: ");
                        pet.Enter();
                        Number = Convert.ToInt32(Console.ReadLine());

                        if (Number == 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Конец");
                            goto end;
                        }

                        switch (Number)
                        {
                            case 1: pet.Satiety(); break;
                            case 2: pet.Thirst(); break;
                            case 3: pet.Toilet(); break;
                            case 4: pet.Fatigue(); break;
                            default: break;
                        }
                        goto catS;
                    }
                case 2:
                    dogS:

                    Console.Clear();

                    Console.WriteLine("Если вы желаете закрыть тамагочи, введите цифру 5");

                    pet.Check_Information();
                    if (pet.check == true)
                    {
                        goto end;
                    }

                    pet.Information();

                    Console.WriteLine("Выберите один из пунктов:: ");
                    pet.Enter();
                    Number = Convert.ToInt32(Console.ReadLine());

                    if (Number == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Конец");
                        goto end;
                    }

                    switch (Number)
                    {
                        case 1: pet.Satiety(); break;
                        case 2: pet.Thirst(); break;
                        case 3: pet.Toilet(); break;
                        case 4: pet.Fatigue(); break;
                        default: break;
                    }
                    goto dogS;

                default:
                    Console.Clear();
                    Console.WriteLine("Выберите питомца из списка.");
                    goto tryE;
                    end:
                    Console.ReadKey();
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}
