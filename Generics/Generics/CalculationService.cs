using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0) throw new ArgumentException("This list cant be empty");

            T maxValue = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(maxValue) > 0)
                {
                    maxValue = list[i];
                }

            }
            return maxValue;
        }
    }
}
