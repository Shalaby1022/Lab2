namespace CheckAndUnchecked
{
    internal class CheckAndUnchec
    {
        static void Main(string[] args)
        {
            
            checked
            {
                try
                {
                    int Number = int.MaxValue;
                    Console.WriteLine($"MaxValue: {Number}");

                    //increment the max value will cause an overflow
                    Number++;
                    Console.WriteLine($"MaxValue after increment: {Number}");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Overflow exception occurred: " + ex.Message);
                }
            }

            Console.WriteLine();

            // Example 2: Using unchecked keyword
            unchecked
            {
                int Number2 = int.MinValue;
                Console.WriteLine($"MinValue: {Number2}");

                // Incrementing the min value will wrap around to the max value
                Number2++;
                Console.WriteLine($"MinValue after increment: {Number2}");
            }
        }

    }
    }
