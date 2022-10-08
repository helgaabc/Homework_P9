class Program
{
    static int Sum(int[] array, int i = 0)
    {
        if (i >= array.Length)
            return 0;
        return array[i] + Sum(array, i + 1);
    }

    static void Main (string[] args)
    {
        Console.Write("Введите начальное число: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите начальное число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int x = n - m + 1;
        int[] array = new int[x];
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = m;
                m++;
            }  
        int result = Sum(array);
        Console.WriteLine("M = " + (m - array.Length) + "; " + "N = " + n + "  Сумма -> " + result);
    }
}
