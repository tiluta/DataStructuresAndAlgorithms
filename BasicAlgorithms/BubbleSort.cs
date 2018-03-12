using System;
using System.Collections;

namespace BasicAlgorithms
{
    public class BubbleSort
    {
        public int[] ArrayOfIntegers { get; set; }

        public void Sort(int[] ArrayofIntegers)
        {
            int i = 0;
            int j = 0;
            for(i= 0; i <= ArrayofIntegers.Length - 1; i++)
            {
                for (j = i + 1; j <= ArrayofIntegers.Length - 1; j++)
                {
                    if(ArrayofIntegers[i] > ArrayofIntegers[j])
                    {
                        int aux = ArrayofIntegers[i];
                        ArrayofIntegers[i] = ArrayofIntegers[j];
                        ArrayofIntegers[j] = aux;
                    }
                }
            }
        }


    }
}
