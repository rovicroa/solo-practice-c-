Write a function:
class Solution { public int solution(int[] A); }
that, given an array A of N integers, returns the smallest positive integer (greater than 0) 
that does not occur in A.
For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
iven A = [1, 2, 3], the function should return 4.
Given A = [−1, −3], the function should return 1.
Write an efficient algorithm for the following assumptions:
N is an integer within the range [1..100,000]; 
each element of array A is an integer within the range [−1,000,000..1,000,000].


using System;

class Solution
{
    public int solution(int[] A)
    {
        Array.Sort(A);
        int smallestNum = 1;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == smallestNum)
            {
                smallestNum = smallestNum + 1;
            }
            else if (A[i] > smallestNum)
            {
                break;
            }
        }
        return smallestNum;
    }
}


using System;

class Solution
{
    public int solution(int[] A)
    {
        Array.Sort(A);
        int smallestNum = 1;

        foreach (int i in A)
        {
            if (i == smallestNum)
            {
                smallestNum = smallestNum + 1;
            }
            else if (i > smallestNum)
            {
                break;
            }

        }
        return smallestNum;
    }