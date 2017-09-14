using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Creating an array of arrays (jagged array)
            //NOTE: The second [] param represents the outer array
            //which only knows that it will store arrays of float
            //it does not know anything about the length of inner arrays
            //because array length is not part of the type
            float[][] tempsGrid = new float[4][];
            Console.WriteLine("Jagged Length is: " + tempsGrid.Length);
            Console.WriteLine("Jagged Rank is: " + tempsGrid.Rank);

            for (int x = 0; x < 4; x++)
            {
                ///creating a float[3] array for every "x" value
                ///inside the jagged array
                tempsGrid[x] = new float[3];
                for (int y = 0; y < 3; y++)
                {
                    tempsGrid[x][y] = x + 10 * y;
                }
            }

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(tempsGrid[x][y] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
