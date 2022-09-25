// See https://aka.ms/new-console-template for more information
//Task 9.3

//    You are climbing a staircase. It takes n steps to reach the top.
//Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
//Example 1:

//Input: n = 2
//Output: 2
//Explanation: There are two ways to climb to the top.
//1. 1 step + 1 step
//2. 2 steps

Console.WriteLine("Введите количество шагов");
int n =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("количество способов: " + (ClimbStairs(n)));
int ClimbStairs(int n) 
{
    if (n < 2)
    {
        return n;
    }

    int[] ans = new int[n];
    ans[0] = 1;
    ans[1] = 2;

    for (int i = 2; i < n; i++) 
    {
        ans[i] = ans[i - 1] + ans[i - 2];
    }
    return ans[n - 1];
}



