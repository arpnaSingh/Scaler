public static class SquareRoot
{
    public static int GetSquareRoot(int A)
    {
        for (int i = 1; i * i <= A; i++)
        {
            if (A % i == 0)
            {
                if (i == A / i) return i;
            }
        }
        return -1;
    }
}
