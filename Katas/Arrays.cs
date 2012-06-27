using NUnit.Framework;

namespace Katas
{
    public class Arrays
    {
        [Test]
        public void InitializationOfDifferentTypesOfArrays()
        {
            // Declare a single-dimensional array 
            var array1 = new int[5];

            Assert.AreEqual(5, array1.Length);

            // Declare and set array element values
            var array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array
            var multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declare a jagged array
            var jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure
            jaggedArray[0] = new[] { 1, 2, 3, 4 };
        }
    }
}