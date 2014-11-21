using LDI2014_demo.Logic;
using LDI2014_demo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDI2014_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            INumbersRepository repo = new MemoryNumbersRepository();
            ISortingAlgorithm sortingAlgorithm = new QuickSortAlgorithm();

            List<int> numbers = repo.GetNumbers();

            DisplayNumbers(numbers);

            sortingAlgorithm.Sort(numbers);

            DisplayNumbers(numbers);
        }

        static void DisplayNumbers(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}
