using System;
using System.Threading;

public static class MultiCores 
{
    public static void SharingTest(int threadCount, int offset, int gap, int size = 100000)
    {
        int[] sharedData = new int[threadCount * offset + gap * offset];
        Thread[] workers = new Thread[threadCount];

        for(int i = 0; i < threadCount; ++i)
        {
            workers[i] = new Thread(new ParameterizedThreadStart(idx => 
            {
                int index = (int)idx + gap;
                for(int j =0; j < size; ++j)
                {
                    sharedData[index * offset] = sharedData[index * offset] + 1;
                }
            }));
        }

        for(int i = 0; i < threadCount; ++i)
            workers[i].Start(i);
        for(int i = 0; i < threadCount; ++i)
            workers[i].Join();
    }
}