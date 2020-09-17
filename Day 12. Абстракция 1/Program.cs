using System;

namespace Day_11_Задание_1
{
     class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ввести студента - 1\nВвести аспиранта - 2\nВыйти - 3");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case ("1"):
                    while (answer == "1")
                    {
                        Student Atamoghlan = new Student(lastname(), course(), creditbooknumber());
                        Atamoghlan.Print();
                        Console.WriteLine("\nSystem.Object Методы:");
                        Console.WriteLine(Atamoghlan.Course);
                        Console.WriteLine(Atamoghlan.GetType());
                        Console.WriteLine(Atamoghlan.GetHashCode());
                        bool EqualOrNot = Atamoghlan.Course.Equals(Atamoghlan.CreditBookNumber);
                        Console.WriteLine(EqualOrNot);
                        Console.WriteLine("Ввести студента - 1\nВвести аспиранта -2\nВыйти -3");
                        answer = Console.ReadLine();
                    }
                    break;

                case ("2"):
                    while (answer == "2")
                    {
                        
                        Aspirant Araz = new Aspirant(lastname(), course(), creditbooknumber(), dissertation());
                        Araz.Print();
                        Console.WriteLine("\nSystem.Object Методы:");
                        Console.WriteLine(Araz.Course);
                        Console.WriteLine(Araz.GetType());
                        Console.WriteLine(Araz.GetHashCode());
                        bool EqualOrNot = Araz.Course.Equals(Araz.CreditBookNumber);
                        Console.WriteLine(EqualOrNot);
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

             string lastname()
            {
                string lastname = "";
                
                while (lastname == null || lastname.Length < 2 || lastname.Length > 30)
                {
                    Console.WriteLine("Введите фамилию студента");
                    lastname = Console.ReadLine();
                    if (lastname != null && lastname.Length > 2 && lastname.Length < 30)
                    {

                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Фамилия должна состоять из английских букв и быть не длиннее 30-ти символов");
                    }
                }
                return lastname;
                
            }
             int course()
            {
                int course = 0;
                while (course < 1 || course > 5)
                {
                    Console.WriteLine("Введите курс студента");
                    course = Convert.ToInt32(Console.ReadLine());
                    if (course > 0 && course < 6)
                    {

                        continue;
                    }
                    else { Console.WriteLine("Ошибка!"); }
                }
                return course;
            }
            int creditbooknumber ()
            {
                int creditbooknumber = 0;
                while (creditbooknumber < 1 || creditbooknumber > 10000)
                {
                    Console.WriteLine("Введите номер зачетной книги");
                    creditbooknumber = Convert.ToInt32(Console.ReadLine());
                    if (creditbooknumber > 0 && creditbooknumber < 10000)
                    {

                        continue;
                    }
                    else { Console.WriteLine("Ошибка!"); }
                }
                return creditbooknumber;
            }
            int dissertation()
            {
                int dissertation = 0;
                while (dissertation < 1 || dissertation > 10000)
                {
                    Console.WriteLine("Введите номер диссертации");
                    dissertation = Convert.ToInt32(Console.ReadLine());
                    if (dissertation > 0 && dissertation < 10000)
                    {

                        continue;
                    }
                    else { Console.WriteLine("Ошибка!"); }
                }
                return dissertation;
            }
        }
    }
    public abstract class Educated
    {
        public abstract string Lastname { get; set; }
        public abstract int Course { get; set; }
        public abstract int CreditBookNumber { get; set; }
        public abstract void Print();

    }
    public class Student : Educated
    {
        public override string Lastname { get; set; }

        public override int Course { get; set; }
        public override int CreditBookNumber { get; set; }
        public Student(string lastname, int course, int creditbooknumber) 
        { Lastname = lastname; Course = course; CreditBookNumber = creditbooknumber; }
       
        public override void Print()
        { Console.WriteLine($"Студент {Lastname} учится на {Course}-ом(ем) курсе. Номер зачетной книги: {CreditBookNumber}"); }

    }
    public class Aspirant : Educated
    {
        public override string Lastname { get; set; }

        public override int Course { get; set; }
        public override int CreditBookNumber { get; set; }
        public int Dissertation { get; set; }
        public Aspirant(string lastname, int course, int creditbooknumber, int dissertation)
        { Lastname = lastname; Course = course; CreditBookNumber = creditbooknumber; Dissertation = dissertation; }


        public override void Print()
        { Console.WriteLine($"Студент {Lastname} учится на {Course}-ом(ем) курсе. Номер зачетной книги: {CreditBookNumber}. Номер диссертации: {Dissertation}"); }

    }
}

