using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ValorHoraFunc.model.enums;
using System.Threading.Tasks;

namespace ValorHoraFunc.model
{
    class Worker
    {
        public string name { get; set; }
        public WorkerLevel workerLevel { get; set; }
        public double baseSalary { get; set; }
        public Department department { get; set; }
        public List<HourContract> contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel workerLevel, double baseSalary, Department department)
        {
            this.name = name;
            this.workerLevel = workerLevel;
            this.baseSalary = baseSalary;
            this.department = department;
        }

        public void AddContract(HourContract contract)
        {
            contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            contracts.Remove(contract);
        }

        public Double income(int month, int year)
        {
            var totalValuePerContract = baseSalary;
            foreach (HourContract contract in contracts)
            {
                if (contract.date.Month == month && contract.date.Year == year)
                {
                    totalValuePerContract += contract.totalValue();
                }
            }

            return totalValuePerContract;
        }
    }
}
