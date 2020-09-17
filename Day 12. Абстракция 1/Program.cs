using System;

namespace Day_11_Задание_1
{
    class Program
    {
        public static void Main()
        {
            Student Atamoghlan = new Student();
            Aspirant Araz = new Aspirant();
            Console.WriteLine("Ввести студента - 1\nВвести аспиранта - 2\nВыйти - 3");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case ("1"):
                    while (answer == "1")
                    {
                        string lastname = "";
                        int course = 0;
                        int creditbooknumber = 0;
                        while (lastname == null || lastname.Length < 2 || lastname.Length > 30)
                        {
                            Console.WriteLine("Введите фамилию студента");
                            lastname = Console.ReadLine();
                            if (lastname != null && lastname.Length > 2 && lastname.Length < 30)
                            {
                                Atamoghlan.Lastname = lastname;
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка! Фамилия должна состоять из английских букв и быть не длиннее 30-ти символов");
                            }
                        }
                        while (course < 1 || course > 5)
                        {
                            Console.WriteLine("Введите курс студента");
                            course = Convert.ToInt32(Console.ReadLine());
                            if (course > 0 && course < 6)
                            {
                                Atamoghlan.Course = course;
                                continue;
                            }
                            else { Console.WriteLine("Ошибка!"); }
                        }
                        while (creditbooknumber < 1 || creditbooknumber > 10000)
                        {
                            Console.WriteLine("Введите номер зачетной книги");
                            creditbooknumber = Convert.ToInt32(Console.ReadLine());
                            if (creditbooknumber > 0 && creditbooknumber < 10000)
                            {
                                Atamoghlan.CreditBookNumber = creditbooknumber;
                                continue;
                            }
                            else { Console.WriteLine("Ошибка!"); }
                        }
                        Atamoghlan.Print();


                        Console.WriteLine("Ввести студента - 1\nВвести аспиранта -2\nВыйти -3");
                        answer = Console.ReadLine();


                    }
                    break;

                case ("2"):
                    while (answer == "2")
                    {
                        string lastname2;
                        int course2 = 0;
                        int creditbooknumber2 = 0;
                        int dissertation = 0;
                        while (Araz.Lastname == null || Araz.Lastname.Length < 2 || Araz.Lastname.Length > 30)
                        {
                            Console.WriteLine("Введите фамилию аспиранта");
                            lastname2 = Console.ReadLine();
                            if (lastname2 != null && lastname2.Length > 2 && lastname2.Length < 30)
                            { Araz.Lastname = lastname2; continue; }
                            else
                            {
                                Console.WriteLine("Ошибка! Фамилия должна состоять из английских букв и быть не длиннее 30-ти символов");
                            }
                        }
                        while (course2 < 1 || course2 > 5)
                        {
                            Console.WriteLine("Введите курс аспиранта");
                            course2 = Convert.ToInt32(Console.ReadLine());
                            if (course2 > 0 && course2 < 6)
                            { Araz.Course = course2; continue; }
                            else { Console.WriteLine("Ошибка!"); }
                        }
                        while (creditbooknumber2 < 1 || creditbooknumber2 > 10000)
                        {
                            Console.WriteLine("Введите номер зачетной книги");
                            creditbooknumber2 = Convert.ToInt32(Console.ReadLine());
                            if (creditbooknumber2 > 0 && creditbooknumber2 < 10000)
                            { Araz.CreditBookNumber = creditbooknumber2; continue; }
                            else { Console.WriteLine("Ошибка!"); }
                        }
                        while (dissertation < 1 || dissertation > 10000)
                        {
                            Console.WriteLine("Введите номер диссертации");
                            dissertation = Convert.ToInt32(Console.ReadLine());
                            if (dissertation > 0 && dissertation < 10000)
                            {
                                Araz.Dissertation = dissertation;
                                continue;
                            }
                            else { Console.WriteLine("Ошибка!"); }
                        }
                        Araz.Print();

                        Console.WriteLine("Ввести студента - 1\nВвести аспиранта -2\nВыйти -3");
                        answer = Console.ReadLine();
                        break;
                    }
                    break;
                case ("3"):
                    break;
                default:
                    Console.WriteLine("\t   Ошибка!\nВвести студента - 1\nВвести аспиранта - 2\nВыйти - 3");
                    answer = Console.ReadLine();
                    break;

            }
            Console.WriteLine("System.Object Методы:");
            Console.WriteLine(Atamoghlan.Course);
            Console.WriteLine(Atamoghlan.GetType());
            Console.WriteLine(Atamoghlan.GetHashCode());
            bool EqualOrNot = Atamoghlan.Course.Equals(Atamoghlan.CreditBookNumber);
            Console.WriteLine(EqualOrNot);

        }
    }
    public abstract class Educated
    {
        public abstract string Lastname { get; set; }
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Lastname))
                return base.ToString();
            return Lastname;
        }
        public abstract int Course { get; set; }
        public abstract int CreditBookNumber { get; set; }
        public abstract void Print();

    }
    public class Student : Educated
    {
        public override string Lastname { get; set; }

        public override int Course { get; set; }
        public override int CreditBookNumber { get; set; }
        public Student() { }
       
        public override void Print()
        { Console.WriteLine($"Студент {Lastname}учится на {Course}-ом(ем) курсе. Номер зачетной книги: {CreditBookNumber}"); }

    }
    public class Aspirant : Educated
    {
        public override string Lastname { get; set; }

        public override int Course { get; set; }
        public override int CreditBookNumber { get; set; }
        public int Dissertation { get; set; }
        public Aspirant() { }
        
        public override void Print()
        { Console.WriteLine($"Студент {Lastname} учится на {Course}-ом(ем) курсе. Номер зачетной книги: {CreditBookNumber}. Номер диссертации: {Dissertation}"); }

    }
}

