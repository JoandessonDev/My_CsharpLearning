using System;


namespace Composicao.Entites
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValueHour {  get; set; }
        public int Hour {  get; set; }

        public HourContract() { }

        public HourContract(DateTime date, double valueHour, int hour)
        {
            Date = date;
            ValueHour = valueHour;
            Hour = hour;
        }

        public double TotalValue()
        {
            return Hour * ValueHour;
        }
    }
}
