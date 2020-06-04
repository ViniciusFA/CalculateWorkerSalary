using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValorHoraFunc.model;

namespace ValorHoraFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            HourContract hourContract = new HourContract();

            Console.WriteLine("\n   ***** Project Calculate Worker Salary *****\n");

            Console.Write(" Enter department:");
            Department department = new Department();
            department.name = Console.ReadLine();

            Console.WriteLine("\n Enter worker data:");

            Console.Write(" Name: ");
            var nameWorker = Console.ReadLine();                     

            Console.Write(" Level (Junior/MidLevel/Senior): ");
            Console.ReadLine();

            Console.Write(" Base salary: ");
            worker.baseSalary = double.Parse(Console.ReadLine());

            Console.Write(" How many contracts to this worker: ");
            var countContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i<= countContracts ; i++)
            {
                Console.WriteLine();

                Console.WriteLine(" Enter  #" + i + " contract data:");
                Console.Write(" Date (DD/MM/YYYY) :");
                var hourContractDate = Console.ReadLine();

                Console.Write(" Value per hour: ");
                var hourContractValuePerHour = Console.ReadLine();

                Console.Write(" Duration (hours): ");
                var hourContractDurationHours = Console.ReadLine();
                
                hourContract.date = DateTime.Parse(hourContractDate);
                hourContract.ValuePerHour = Double.Parse(hourContractValuePerHour);
                hourContract.hours = int.Parse(hourContractDurationHours);

                worker.AddContract(hourContract);
            }

            Console.WriteLine();
            Console.Write(" Enter month and year to calculate income (MM/YYYY):");
            var resultMonthYear = hourContract.getFormatterMonthYear(Console.ReadLine());

            

            var incomeWorker = worker.income(resultMonthYear[0], resultMonthYear[1]);

            Console.WriteLine("Name: " + nameWorker);
            Console.WriteLine("Department: " + department.name);
            Console.WriteLine("Income for " + resultMonthYear[0] + "/" + resultMonthYear[1] + ": " + incomeWorker);


            Console.ReadKey();
            
        }
    }
}
