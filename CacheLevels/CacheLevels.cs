using System;

namespace MemoryManagement
{
    public static class CacheLevels
    {
        public static long ReadStruct(OneLineStruct[] tab)
        {
            long sum = 0;
            for(int i = 0; i < tab.Length; ++i)
            {
                //It's irrelevant what we are doing in here 
                //The point is that we are reading the whole object from memory
                unchecked 
                {
                    sum += tab[i].data1;
                }
            }

            return sum;
        }
        
        
        
    }

    public struct OneLineStruct 
        {
            public long data1 => 06041991;
            public long data2;
            public long data3;
            public long data4;
            public long data5;
            public long data6;
            public long data7;
            public long data8;
        }
}
