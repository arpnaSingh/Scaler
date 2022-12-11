public static class Iterations
{
    public static int FindIterationsForSqrt(int N)//Give N is perfect sqrt number
    {
        int count = 0;
        for (int i = 1; i <= N; i++)
        {
            if (i * i == N)
                return i;
           
            count++;
        }
        return count;
    }
}
//Ans:Math.Sqrt(N); 