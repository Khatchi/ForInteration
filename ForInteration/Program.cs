internal class Program
{
    private static void Main(string[] args)
    {
        //ForLoopInteration

        //for (int i = 0; i < 10;  i++)
        //{
        //    //Console.WriteLine(i);
        //    if (i == 7);
        //    {
        //        Console.WriteLine("Found seven!");
        //        break;
        //    }
        //}

        //for (int myValue = 0; myValue < 12; myValue++)
        //{
        //    Console.WriteLine(myValue);
        //}

        /* Understanding Arrays*/

        int[] numbers = new int[5];

        numbers[0] = 4;
        numbers[1] = 8;
        numbers[2] = 15;
        numbers[3] = 16;
        numbers[4] = 23;

        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers.Length);

        Console.ReadLine();
    }
}