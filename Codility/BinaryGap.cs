namespace Codility;

public static class BinaryGap
{
    ///<Summary>
    /// Solving the Binary Gap Alogo, count the number of zeros surrounded by ones.
    ///<code>example: int `20` in binary is `10100` which has a gap of `1`</code>
    ///</Summary>
    public static int Solution(int N)
    {
        int zeros = 0;
        int largestZerosCount = 0;

        // convert to binary
        string binary = Convert.ToString(N, 2);
        //Console.WriteLine($"binary : {binary}");

        // convert to an array
        char[] ar = binary.ToCharArray();

        // Loop through each char
        for (int i = 0; i < ar.Length; i++)
        {
            //Console.WriteLine($"ar[i] : {ar[i]}");
            // check when its a 1 
            if (ar[i] == '1')
            {
                // check if this is the largest zeros counted
                if (zeros > largestZerosCount)
                {
                    largestZerosCount = zeros;
                    zeros = 0; // reset zero counter
                    continue;
                }
            } else if (ar[i] == '0')
            {
                // count the zeros
                zeros += 1;
            }
        }
        return largestZerosCount;
    }

    ///<Summary>
    /// Answer Found
    ///</Summary>
    public static int FoundSolution(int N)
    {
        return Convert
        // convert to binary
        .ToString(N, 2)
        // remove leading and trailing 0s, as per requirement
        .Trim('0')
        // split the string by 1s
        .Split(new[] { '1' })
        // find the length of longest segment
        .Max(x => x.Length);
    }
}