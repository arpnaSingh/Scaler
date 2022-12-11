/*
Given two integers A and B. 
. A represents the count of mangoes
. B represent the count of slices of mangoes.
. Mango can be cut into three slices of mangoes. 
. A glass of mango shake can be formed by two slices of mangoes.
Find the maximum number of glasses of mango shakes you can make with A mangoes and B slices of mangoes initially.
*/
public static class MangoShake
{
    public static int GetMangoShakeGlass(int A, int B)
    {
        //A=3B
        //glass=2B
        int totalNumSlices = (3 * A) + B;
        int maxNumberOfGlasses = totalNumSlices / 2;
        return maxNumberOfGlasses;
    }
}
