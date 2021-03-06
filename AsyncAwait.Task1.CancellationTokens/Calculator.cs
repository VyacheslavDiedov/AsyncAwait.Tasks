using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait.Task1.CancellationTokens
{
    static class Calculator
    {
        // todo: change this method to support cancellation token
        public static long Calculate(int n, CancellationToken token)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                // i + 1 is to allow 2147483647 (Max(Int32)) 
                sum = sum + (i + 1);
                Thread.Sleep(10);

                token.ThrowIfCancellationRequested();
            }

            return sum;
        }
    }
}