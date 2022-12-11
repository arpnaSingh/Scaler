public static class CountOfPrime
{
    private static bool IsPrime(int P)
    {
        if (P == 1) return false;
        if (P == 2 || P == 3) return true;
        if (P % 2 == 0) return false;
        for (int i = 3; i * i <= P; i = i + 2)
        {
            if (P % i == 0) return false;
        }
        return true;
    }
    public static int GetCountOfPrimeNumber(int A)
    {
        int count = 0;

        for (int j = 1; j <= A; j++)
        {
            bool isPrime = IsPrime(j);
            count = isPrime ? count + 1 : count;
        }
        return count;
    }
}
