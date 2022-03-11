// See https://aka.ms/new-console-template for more information

Console.WriteLine("input five space-separated integers");

List<long>? arr = Console.ReadLine()?.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

if(arr == null)
{
    throw new ArgumentNullException(nameof(arr));
}

Result.MiniMaxSum(arr);

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void MiniMaxSum(List<long> numbers)
        {
        if (!NumbersIsValid(numbers))
        {
            Console.WriteLine($"invalid input");
            return;
        }

        var resultOfFirstSum = numbers.OrderBy(x => x).Take(4).Sum();
        var resultOfSecondSum = numbers.OrderByDescending(x => x).Take(4).Sum();

        Console.WriteLine($"{resultOfFirstSum} {resultOfSecondSum}");
    }

    private static bool NumbersIsValid(IEnumerable<long> numbers)
    {
        foreach (var number in numbers)
        {
            if (!NumberIsValid(number))
            {
                return false;
            }
        }

        return true;
    }

    private static bool NumberIsValid(long number)
    {
        return number >= 1 && number <= Math.Pow(10, 9);
    }

}
