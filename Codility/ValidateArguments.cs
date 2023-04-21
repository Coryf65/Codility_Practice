namespace Codility;

/// My quiz for a interview
public class ValidateArguments
{
    // values returned 
    // -1 = user passed invalid data / args, empty args, empty array, null
    // 0 = ok
    // 1 = user asked to print help info

    // each param matches an output
    // --count = an int (10 and 100)
    // --name = string length of (3 - 10 chars)
    // --help = print help info

    // examples
    // string[] args = { "--name", "SOME_NAME", "--count", "10" }
    public int Validate(string[] args)
    {
        int result = -100;
        string currentCheck = string.Empty;
        bool helpFlag = false;
        // to lower each argument, caseing does not matter

        Console.WriteLine($"args.Length {args.Length}");
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"index '{i}'");
            Console.WriteLine($"checking now '{args[i]}'");
            currentCheck = args[i].ToLower();

            if (currentCheck == "--name")
            {
                // now check next param
                string nextParam = args[i +1];
                // validate name passed in
                // check if its 3 to 100 chars
                if (nextParam.Length <= 100 && nextParam.Length >= 3)
                {
                    // good
                    result = (int)VaildateStatus.OK;
                } 
                else
                {
                    return result = (int)VaildateStatus.INVALID;    
                }
            }
            
            if (currentCheck == "--count")
            {
                // now check next param
                string nextParam = args[i +1];
                
                if (int.TryParse(nextParam, out int number))
                {
                    if (number <= 100 && number >= 3)
                    {
                        // good
                        result = (int)VaildateStatus.OK;
                    } 
                    else
                    {
                        return result = (int)VaildateStatus.INVALID;    
                    }
                }                
            }

            if (currentCheck == "--help")
            {
                helpFlag = true;
            }
        }

        if (helpFlag)
        {
            if (result == (int)VaildateStatus.OK || result == -100)
            {
                return (int)VaildateStatus.HELP;
            }
        }

        return result;
    }

    public enum VaildateStatus
    {
        INVALID = -1,
        OK = 0,
        HELP = 1
    }
}