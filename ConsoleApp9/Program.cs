using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            int size;
            size = int.Parse(Console.ReadLine());
            List<Worker> matrix=new List<Worker>(size);
            int averageSalary = 0;
            double accessOfBoss=15.05;//15 год май
            List<Worker> managersWithHighSalary = new List<Worker>();
            List<Worker> laterThanBoss = new List<Worker>();

            for (int i = 0; i < size; i++)
            {
                Worker worker = new Worker();
                Console.WriteLine("введите данные пользователя " + i + "\n");
                Console.Write("name: ");
                worker.work.Name= Console.ReadLine();
                Console.Write("surname: ");
                worker.work.Surname = Console.ReadLine();
                Console.Write("age: ");
                int age;
                bool check = int.TryParse(Console.ReadLine(), out age);

                if (check == false)
                {
                    Console.WriteLine("not correct\n");
                }

                else
                {
                    worker.work.Age = age;
                }

                Console.Write("salary: ");
                int salary;
                bool check2 = int.TryParse(Console.ReadLine(), out salary);

                if (check2 == false)
                {
                    Console.WriteLine("not correct\n");
                }

                else
                {
                    worker.work.Salary = salary;
                }

                Console.WriteLine("введите год и месяц(пример: 15,04)");
                double time;
                bool check3 = double.TryParse(Console.ReadLine(), out time);

                if (check3 == false)
                {
                    Console.WriteLine("not correct\n");
                }

                else
                {
                    worker.work.Time = time;
                    if(time>accessOfBoss)
                    {
                        laterThanBoss.Add(worker);
                    }
                }

                averageSalary += worker.work.Salary;
                matrix.Add(worker);
            }
            averageSalary /= matrix.Count;
            Console.WriteLine("--------------------------------------------------------");

            foreach(var workers in matrix)
            {
                Console.WriteLine("name - "+workers.work.Name);
                Console.WriteLine("surname - " + workers.work.Surname);
                Console.WriteLine("age - " + workers.work.Age);
                Console.WriteLine("salary - " + workers.work.Salary);
            }

            foreach(var workers in matrix)
            {
                if(workers.work.Salary>averageSalary)
                {
                    managersWithHighSalary.Add(workers);
                }
            }

            List<Worker> sortedList = managersWithHighSalary.OrderBy(x => x.work.Surname).ToList();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("все клерки с высокими зп! ");

            foreach(var workers in sortedList)
            {
                Console.WriteLine("name - " + workers.work.Name);
                Console.WriteLine("surname - " + workers.work.Surname);
                Console.WriteLine("age - " + workers.work.Age);
                Console.WriteLine("salary - " + workers.work.Salary);
            }

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("все клерки позднее босса! ");
            List<Worker> sortedList2 = laterThanBoss.OrderBy(x=>x.work.Surname).ToList();

            foreach (var workers in sortedList2)
            {
                Console.WriteLine("name - " + workers.work.Name);
                Console.WriteLine("surname - " + workers.work.Surname);
                Console.WriteLine("age - " + workers.work.Age);
                Console.WriteLine("salary - " + workers.work.Salary);
            }

            Console.ReadLine();
        }
    }
}
