using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorHoraFunc.model
{
    class HourContract
    {
        public DateTime date { get; set; }
        public double ValuePerHour { get; set; }
        public int hours { get; set; }

        public HourContract() { }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.date = date;
            ValuePerHour = valuePerHour;
            this.hours = hours;
        }

        public double totalValue()
        {           
            return ValuePerHour * hours;
        }

        public List<int> getFormatterMonthYear(string monthYear)
        {
            List<int> listMonthYear = new List<int>();

            var monthYarSplit = monthYear.Split('/');
            var month = int.Parse(monthYarSplit[0]);
            var year = int.Parse(monthYarSplit[1]);

            listMonthYear.Add(month);
            listMonthYear.Add(year);

            return listMonthYear;
        }
    }
}
