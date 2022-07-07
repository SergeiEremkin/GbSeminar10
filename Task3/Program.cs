void ArrayOfDecNumbers(int[] data, int[] info)
{
    int[] ten = new int[info.Length];
    int count = 0;
    for (int i = 0; i < info.Length; i++)
    {
        for (int j = 0; j < info[i]; j++)
        {
            ten[i] += data[count + j] * (int)Math.Pow(2, info[i] - 1 - j);
        }
        count += info[i];
        Console.Write($"{ten[i]} ");
    }
}
int[] data = new int[] { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = new int[] { 2, 3, 3, 1 };
ArrayOfDecNumbers(data, info);
