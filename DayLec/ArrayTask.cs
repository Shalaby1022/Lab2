namespace DayLec
{


    class ArrayTask
    {
        // Function to print the array
        static void PrintArray(int[] array)
        {
            Console.Write("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        // Function to search for a Grade in the array and return the index
        static int ArraySearch(int[] array, int Grade)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == Grade)
                {
                    return i;
                }
            }
            return -1;
        }

        // function to Find Minimum and Maximum Value
        static void FindMinMax(int[] array)
        {
            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine("Minimum value: " + min);
            Console.WriteLine("Maximum value: " + max);
        }

        // Function to Sort Array 
        static void SortedArray(int[] Grades)
        {
            for (int i = 0; i < Grades.Length - 1; i++)
            {
                for (int j = 0; j < Grades.Length - i - 1; j++)
                {
                    if (Grades[j] > Grades[j + 1])
                    {
                        int temp = Grades[j];
                        Grades[j] = Grades[j + 1];
                        Grades[j + 1] = temp;
                    }
                }
            }
        }


        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                Console.WriteLine("Invalid size. Exiting the program.");
                return;
            }

            int[] Grades = new int[size];

            // Read array values from the user
            for (int i = 0; i < Grades.Length; i++)
            {
                Console.Write($"Enter value for element {i + 1}: ");
                Grades[i] = int.Parse(Console.ReadLine());

            }

            // Print array values
            PrintArray(Grades);

            //Print Min and Max values
            FindMinMax(Grades);

            // print Array after sorting
            SortedArray(Grades);
            Console.Write("Sorted ");
            PrintArray(Grades);

            // Search for a number and return index
            Console.Write("Enter a number to search: ");
            if (!int.TryParse(Console.ReadLine(), out int searchNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            int index = ArraySearch(Grades, searchNumber);
            if (index == -1)
            {
                Console.WriteLine("Number not found in the array.");
            }
            else
            {
                Console.WriteLine($"Number found at index {index}.");
            }
        }

        

       
    }

}




