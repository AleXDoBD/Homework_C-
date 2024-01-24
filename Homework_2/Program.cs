namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6 types of cycles 

            //1
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            //2
            int j = 0;
            while (j <= 100)
            {
                Console.WriteLine(j);
                j++;
            }

            //3
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k <= 100);

            //4
            foreach (int l in Enumerable.Range(0, 101))
            {
                Console.WriteLine(l);
            }
            //5

            foreach (int p in GenerateNumbers())
            {
                Console.WriteLine(p);
            }

            //6

            int t = 0;

            PrintNumbersWithGoto(ref t);

            Console.ReadLine();

        }

        //5-function
        static IEnumerable<int> GenerateNumbers()
        {
            for (int i = 0; i <= 100; i++)
            {
                yield return i;
            }
        }

        //6-function
        static void PrintNumbersWithGoto(ref int i)
        {
        start:
            if (i <= 100)
            {
                Console.WriteLine(i);
                i++;
                goto start;
            }
        }
    }
}
