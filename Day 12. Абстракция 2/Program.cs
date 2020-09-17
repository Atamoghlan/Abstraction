using System;

namespace Day_11_Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {


            string a = "";
            while (a != "Ф" || a != "Ю")
            {
                Console.WriteLine("Введите Ф, если вы Физическое лицо\nВведите Ю, если вы Юридическое лицо");
                a = Console.ReadLine();
                if (a == "Ф")
                {
                    Individual clientF = new Individual();
                    Console.WriteLine("Введите сумму депозита");
                    clientF.Sum = Convert.ToInt32(Console.ReadLine());
                    clientF.NumOfAccount = 1;
                    clientF.Date = "08.09.2020";
                    clientF.Percents();
                    clientF.issueofmoney();
                    clientF.DateOfAccountOpening();
                }

                else if (a == "Ю")
                {
                    int b = 0;
                    Company clientY = new Company();
                    while (b < 1 || b == 0)
                    {
                        Console.WriteLine("Введите сумму депозита");
                        b = Convert.ToInt32(Console.ReadLine());
                        if (b > 1 && b != 0)
                        { clientY.Sum = b; }
                        else { Console.WriteLine("Некорректные данные"); }
                    }

                    clientY.NumOfAccount = 1;
                    clientY.Date = "08.09.2020";
                    clientY.Percents();
                    clientY.issueofmoney();
                    clientY.DateOfAccountOpening();
                }



                else
                { Console.WriteLine("Ошибка!"); }
            }
        }
        public class Account
        {

            public int Sum { get; set;}
            
            public int NumOfAccount { get; set; }
            public string Date { get; set; }
            public Account() { }


            public Account(int sum, int accountnum, string date) { Sum = sum; accountnum = NumOfAccount; Date = date; }
            public void issueofmoney() { Console.WriteLine($"Сумма:{Sum} Номер аккаунта:{NumOfAccount}"); }
            public void DateOfAccountOpening() { Console.WriteLine($"Дата открытия счета:{Date}"); }

        }
        public class Individual : Account
        {

            public string AccountType { get; set; }
            public Individual() { }
            public Individual(int sum, int accountnum, string date, string accounttype) : base(sum, accountnum, date)
            { AccountType = accounttype; Sum = sum; }
            public void Percents()
            {
                double percent;
                double FinalSum;
                if (Sum <= 10000)
                {
                    AccountType = "classic";
                    percent = 1.03;
                    FinalSum = Sum * percent;
                    Console.WriteLine($"Предлагаем Вам по тарифу Classic 3% годовых. По окончанию срока вы получите {FinalSum} ");
                }
                else if (Sum <= 50000)
                {
                    AccountType = "premium";
                    percent = 1.05;
                    FinalSum = Sum * percent;
                    Console.WriteLine($"Предлагаем Вам по тарифу Premium 5% годовых. По окончанию срока вы получите {FinalSum} ");
                }
                else if (Sum > 50000)
                {
                    AccountType = "gold";
                    percent = 1.08;
                    FinalSum = Sum * percent;
                    Console.WriteLine($"Предлагаем Вам по тарифу Gold 8% годовых. По окончанию срока вы получите {FinalSum} ");
                }
            }

            public void CashOut()
            {
                Console.WriteLine("Введите сумму вывода");
                int s = Convert.ToInt32(Console.ReadLine());
                Sum = Sum - s;
                Console.WriteLine($"Осталось средств: {Sum}");
            }

        }
        public class Company : Account

        {
            public Company() { }
            public Company(int sum, int accountnum, string date)
            : base(sum, accountnum, date)
            { }
            public void Percents()
            {
                double percent;
                double FinalSum;
                if (Sum <= 10000)
                {
                    percent = 1.03;
                    FinalSum = Sum * percent;
                    Console.WriteLine($"Предлагаем Вам 3% годовых. По окончанию срока вы получите {FinalSum} ");
                }
                else if (Sum <= 50000)
                {
                    percent = 1.05;
                    FinalSum = Sum * percent;
                    Console.WriteLine($"Предлагаем Вам 5% годовых. По окончанию срока вы получите {FinalSum} ");
                }
                else if (Sum > 50000)
                {
                    percent = 1.08;
                    FinalSum = Sum * percent;
                    Console.WriteLine($"Предлагаем Вам 8% годовых. По окончанию срока вы получите {FinalSum} ");
                }
            }
        }
    }
}
