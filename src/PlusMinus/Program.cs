// See https://aka.ms/new-console-template for more information

Console.Write("size of array: ");

int arraySize = Convert.ToInt32(Console.ReadLine()?.Trim());

Console.WriteLine("\ninput the numbers, example: -4 3 -9 0 4 1");

var numbers = Console.ReadLine()?.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

Console.WriteLine("\n");

Result.PlusMinus(numbers);


class Result
{
    public static void PlusMinus(List<int>? arr)
    {
        if(arr == null)
        {
            throw new ArgumentNullException(nameof(arr));
        }
        
        var elements = arr.Count;

        if(elements < 0 || elements > 100)
        {
            Console.WriteLine("size of array between 0 and 100");
            return;
        }

        foreach (var n in arr)
        {
            if(n > -100 || n > 100)
            {
                Console.WriteLine("numbers of array between -100 and 100");
                return;
            }
        }

        var positives = arr.Where(x => x > 0).Count();
        var negatives = arr.Where(x => x < 0).Count();
        var zeros = arr.Where(x => x == 0).Count();

        var positiveRatios = ((decimal)positives / elements).ToString("0.000000");
        var negativeRatios = ((decimal)negatives / elements).ToString("0.000000");
        var zeroRatios = ((decimal)zeros / elements).ToString("0.000000");

        Console.WriteLine(positiveRatios);
        Console.WriteLine(negativeRatios);
        Console.WriteLine(zeroRatios);
    }
}





