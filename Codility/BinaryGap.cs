namespace Codility;

public static class BinaryGap
{
    ///<Summary>
    /// Solving the Binary Gap Alogo
    ///</Summary>
    public static int Solution(int N)
    {
        // 32 = 100000
        // 20 = 10100 : 1
        int result = 0;
        string binary = Convert.ToString(N, 2);

        // convert to an array
        string[] ar = binary.Split("");

        for (int i = 0; i < ar.Length; i++)
        {
            // check when its a 1 
            if (ar[i] == "1")
            {
                // start counter

            }

            // if 1 and next is zero add to counter

            // save on next 1    
        }

        return result;
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