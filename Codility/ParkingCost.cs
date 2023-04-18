namespace Codility;

public static class ParkingCost
{

    // example given E = 10:00 and L = 13:21 answer = 17
    // 2 + 3 + (3 * 4) = 17

    public static int Solution(string E, string L)
    {
        int cost = 0;
        int entranceFee = 2;
        int firstHourFee = 3; // first hour
        int additionalFee = 4; // hours after first

        DateTime startTime = Convert.ToDateTime(E);
        Console.WriteLine($"startTime: {startTime}");
        DateTime endTime = Convert.ToDateTime(L);
        Console.WriteLine($"endTime: {endTime}");

        double uh = (endTime - startTime).TotalHours;
        Console.WriteLine($"uh: {uh}");

        int totalHours = (int)Math.Ceiling(uh);

        Console.WriteLine($"totalHours: {totalHours}");

        if (totalHours > 1)
            totalHours -= 1;
        else if (totalHours <= 1)
            totalHours = 0;

        Console.WriteLine($"totalHours: {totalHours}");

        // enter fee
        cost = entranceFee + firstHourFee + (totalHours * additionalFee);
        Console.WriteLine("entranceFee + firstHourFee + (totalHours * additionalFee)");
        Console.WriteLine($"{entranceFee} + {firstHourFee} + ({totalHours} * {additionalFee})");
        Console.WriteLine($"cost: {cost}");

        return cost;
    }

} 