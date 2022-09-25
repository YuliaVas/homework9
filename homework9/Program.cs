// See https://aka.ms/new-console-template for more information
//Task 9.1
//Given a positive integer n, return the smallest positive integer that is a multiple of both 2 and n.
//    Constraints:
//1 <= n <= 150

Console.WriteLine("Введите положитльное число от 0 до 150");
int n = Convert.ToInt32(Console.ReadLine());

int smallestEvenMultiple(int n)
{
        if ((1 <= n) && (n <= 150))
        {
            if ((n % 2 == 0))
            { return n; }
            else { return n * 2; }
        }
        else
            Console.WriteLine("Число вне диапазона");
        return 0;
}
    Console.WriteLine(smallestEvenMultiple(n)); 

