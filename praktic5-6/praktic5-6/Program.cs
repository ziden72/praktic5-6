using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace praktic5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int o = 0;
            while (o == 0)
            {
                Console.WriteLine("1. Показать Информацию о студентах\n2. Добавить студента\n3. Удалить студента\n4. Изменить студента\n5. Поиск студентов\n6. Выход\n");
                int l = Convert.ToInt32(Console.ReadLine());
                if (l == 1)
                {
                    Console.WriteLine("1. Вся информация о студентах\n2. Список студентов с инициалами\n3. Список студентов старше 18\n4. Список студентов младше 18");
                    int l1 = Convert.ToInt32(Console.ReadLine());
                    if (l1 == 1)
                    {
                        Student.Mov();
                    }
                    if (l1 == 2)
                    {
                        for (int i = 0; i < Student.bace.Count; i = i + 4)
                        {
                            Console.WriteLine(Student.bace[i + 1]);
                            Console.WriteLine();
                        }
                    }
                    if (l1 == 3)
                    {
                        for (int k = 1; k <= number; k++)
                        {
                            string d = "";
                            string D = "";
                            for (int i = 0; i < Student.bace.Count - 2; i++)
                            {
                                if (Student.bace[i].ToString().Equals(k.ToString()))
                                {
                                    d = d + Student.bace[i + 3].ToString();
                                    for (int j = 6; j < d.Length; j++)
                                    {
                                        D = D + d[j];
                                    }
                                    Convert.ToInt32(D);
                                    int s = 2021 - Convert.ToInt32(D);
                                    if (s > 18)
                                    {
                                        Console.WriteLine(Student.bace[i + 1]);
                                    }
                                    Console.WriteLine();
                                    break;
                                }
                            }
                        }
                    }
                    if (l1 == 4)
                    {
                        for (int k = 1; k <= number; k++)
                        {
                            string d = "";
                            string D = "";
                            for (int i = 0; i < Student.bace.Count - 2; i++)
                            {
                                if (Student.bace[i].ToString().Equals(k.ToString()))
                                {
                                    d = d + Student.bace[i + 3].ToString();
                                    for (int j = 6; j < d.Length; j++)
                                    {
                                        D = D + d[j];
                                    }
                                    Convert.ToInt32(D);
                                    int s = 2021 - Convert.ToInt32(D);
                                    if (s < 18)
                                    {
                                        Console.WriteLine(Student.bace[i + 1]);
                                    }
                                    Console.WriteLine();
                                    break;
                                }
                            }
                        }
                    }
                }
                if (l == 2)
                {
                    Console.WriteLine("Введите ФИО: ");
                    string name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите группу: ");
                    string group = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите дату рождения: ");
                    string date = Convert.ToString(Console.ReadLine());
                    Student.Add(name, group, date);
                    number++;
                }
                if (l == 3)
                {
                    Console.WriteLine("Введите id студента");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Student.Delete(i);
                    Console.WriteLine("Студент удалён\n");
                    Console.WriteLine();
                }
                if (l == 4)
                {
                    Student.Replace();
                }
                if (l == 5)
                {
                    Student.Movp();
                }
                if (l == 6)
                {
                    break;
                }
            }
        }
    }
}