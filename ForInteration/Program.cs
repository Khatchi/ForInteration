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

        //int[] numbers = new int[5];

        //numbers[0] = 4;
        //numbers[1] = 8;
        //numbers[2] = 15;
        //numbers[3] = 16;
        //numbers[4] = 23;

        //Console.WriteLine(numbers[1]);
        //Console.WriteLine(numbers.Length);

        /* Quick declaration of arrays */
        int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

        string[] names = new string[] { "Kachi", "Shaks", "Mike", "Dave" };

        /* for loop  */
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.WriteLine("================");

        /* Foreach loop */
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("===============");

        /* ARRAYS of different things */

        string zig = "You can get what you want out of life" + "if you help enough other people get what they want.";

        char[] charArray = zig.ToCharArray();
        Array.Reverse(charArray);

        foreach (char zigChar in charArray)
        {
            Console.Write(zigChar);
        }
      

        Console.ReadLine();
    }
}