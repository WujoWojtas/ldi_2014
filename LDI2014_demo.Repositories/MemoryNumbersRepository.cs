using System.Collections.Generic;

namespace LDI2014_demo.Repositories
{
    public class MemoryNumbersRepository : INumbersRepository
    {
        private List<int> numbers;

        public MemoryNumbersRepository()
        {
            this.InitializeNumbers();
        }

        private void InitializeNumbers()
        {
            this.numbers = new List<int>()
            {
                0,1,2,5,3,6,-1,7,9,8
            };
        }

        public List<int> GetNumbers()
        {
            return this.numbers;
        }
    }
}
