void GroupsOfSimpeNumbers()
{
    Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Math.Log(n, 2));
    Console.WriteLine("Число групп = " + m);
    Console.WriteLine("Группа 1: 1");
    for (int i = 1; i < m; i++)
    {
        Console.Write($"Группа {i + 1}: ");
        for (int k = Convert.ToInt32(Math.Pow(2, i)); k < Convert.ToInt32(Math.Pow(2, (i + 1))) && k < (n + 1); k++)
        {
            Console.Write(k + " ");
        }
        Console.WriteLine();
    }
}
GroupsOfSimpeNumbers();