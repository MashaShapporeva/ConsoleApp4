namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = new int[25];
            sequence[0] = 0;
            sequence[1] = 1;
            for (int counter = 2; counter <= 24; counter++)
                sequence[counter] = sequence[counter - 2] + sequence[counter - 1];
            for (int counter = 0; counter <= 24; counter++)
                Console.WriteLine("Fibonacci Number " + counter + " is " + sequence[counter]);
        }
    }
}