public static class PrimeNumber
{
    public static bool IsPrimeNumer(long A)
    {
        int count = 2;
        if (A == 1) return false;
        if (A == 2 || A == 3) return true;
        if (A % 2 == 0) return false;

        for (long i = 3; i * i <= A; i = i + 2)
        {
            if (count > 2)  return false;
            if (A % i == 0)
            {
                if (i == A / i)
                {
                    count += 1;
                }
                else
                {
                    count += 2;
                }
            }
        }
        return count == 2 ? true : false;

    }
}
