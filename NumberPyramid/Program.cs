class NumberPyramid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int currentNumber = 1;

        for (int i = 1; i < n; i++)
        {

            for (int row = 1; currentNumber <= n; row++)
            {

                for (int col = 1; col <= row && currentNumber <= n; col++)
                {
                    Console.Write($"{currentNumber} ");
                    currentNumber++;
                }

                Console.WriteLine();

            }

        }
    }
}
