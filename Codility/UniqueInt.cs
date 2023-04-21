namespace Codility;

public static class UniqueInt
{

    // Not optimal, needs to run faster 83% correctness, and slow
    public static int Solution(int[] A) {
        // Implement your solution here
        int result = 0;
        List<int> numbersOfMultipleOccurences = new List<int>();
        List<int> eachNumber = new List<int>();
        List<int> eachUniqueNumber = new List<int>();

        // count the number of occurences of each item
        foreach (int number in A)
        {
            Console.WriteLine($"checking int: {number}");

            // check number, if not in the array add it
            if (!eachNumber.Contains(number))
            {
                Console.WriteLine($"eachNumber.Add(number) = {number}");
                eachNumber.Add(number);

            } else
            {
                Console.WriteLine($"adding '{number}' into numbersOfMultipleOccurences");
                // else it exsits then add to multiple?
                numbersOfMultipleOccurences.Add(number);
            }

            // which int is not in the list of ints
            if (!numbersOfMultipleOccurences.Contains(number))
            {
                Console.WriteLine($"!numbersOfMultipleOccurences.Contains(number) eachUnique adding {number}");
                eachUniqueNumber.Add(number);
            } else 
            {
                // remove it is there now
                Console.WriteLine("Now remove it is in our list now");
                eachUniqueNumber.Remove(number);
            }
        }

        // does not work on codility
        //result = eachUniqueNumber.FirstOrDefault(-1);
        
        // same result here
        if (eachUniqueNumber.FirstOrDefault() > 0)
        {
            result = eachUniqueNumber.FirstOrDefault();
        } else
        {
            result = -1;
        }
        
        Console.WriteLine(result);

        return result;
    }
}