/*
Perfect number is a positive integer which is equal to the sum of its proper positive divisors.
A proper divisor of a natural number is the divisor that is strictly less than the number.

Example Explanation
Explanation 1:

For A = 4, the sum of its proper divisors = 1 + 2 = 3, is not equal to 4. i.e. not Perfect Number
Explanation 2:

For A = 6, the sum of its proper divisors = 1 + 2 + 3 = 6, is equal to 6.  i.e. Perfect Number
*/

public static class PerfectNumber
{
    public static bool IsPerfectNumber(int A)
    {
        if (A == 1) return false;

        int sum = 0;
        for (int i = 1; i * i <= A; i++)
        {
            if (A % i == 0)
            {
                sum += i; //add proper divisor for 6, if i=2, add 2
                if (i != A / i && i != 1)
                {
                    sum += A / i; //add other proper divisor, here add 3
                }
            }
        }
        return sum == A ? true : false;
    }
}