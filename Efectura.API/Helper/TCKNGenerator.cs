using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Efectura.API.Helper
{
    public class TCKNGenerator
    {
        public double Creator()
        {
            int[] numbers = new int[11];
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                numbers[i] = random.Next(0, 9);
            }
            if (numbers[0] == 0)
            {
                numbers[0] = random.Next(1, 9);
            }
           
                int beforelast = (((numbers[0] + numbers[2] + numbers[4] + numbers[6] + numbers[8]) * 7) - (numbers[1] + numbers[3] + numbers[5] + numbers[7]));
                int divide = beforelast % 10;
                int last = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] + numbers[5] + numbers[6] + numbers[7] + numbers[8] + numbers[9];
                int mod = last % 10;
                numbers[9] = divide;
                numbers[10] = mod;

            double result = double.Parse(string.Join("", numbers));
            return result;
        }
    }
}
