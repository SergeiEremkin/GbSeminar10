void SumOfTwoNumbers(int A, int B)
{
    int N = 5;
    int C = 0;
    System.Console.Write($"{A} {B} ");
    for (int i = 0; i < N; i++)
    {
        C = A + B;
        A = B;
        B = C;
        System.Console.Write($"{C} ");
    }
}
SumOfTwoNumbers(3, 4);
