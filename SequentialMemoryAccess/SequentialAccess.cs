using System;

namespace MemoryManagement
{
    public class SequentialAccess
    {
        public void Sequential(int n, int m)
        {
            int[,] tab = new int[n, m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    tab[i, j] = 1;
                }
            }
        }
        
        public void NonSequential(int n, int m)
        {
            int[,] tab = new int[n, m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    tab[j, i] = 1;
                }
            }
        }
    }
}
