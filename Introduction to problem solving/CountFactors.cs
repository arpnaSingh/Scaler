public static class CountFactors
{
    public static int GetFactors(int A)
    {
        int count = 0;
        for (int i = 1; i * i <= A; i++)
        {
            if (A % i == 0)
            {
                if (i == A / i)
                {
                    count = count + 1;
                }
                else
                {
                    count = count + 2;
                }
            }
        }
        return count;
    }
}
