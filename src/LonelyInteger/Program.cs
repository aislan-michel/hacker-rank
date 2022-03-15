TextWriter textWriter = new StreamWriter(@"D:\dev\Projetos\HackerRank\src\LonelyInteger\test.txt", true);

int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

int result = Result.Lonelyinteger(a);

textWriter.WriteLine(result);

textWriter.Flush();
textWriter.Close();

public class Result
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int Lonelyinteger(List<int> numbers)
    {
        var result = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            result ^= numbers[i];
            //^ => exclusivo, atua no nivel de bits,
            //bits iguais == 0
            //bits diferentes == 1
            //vai zerar todos os valores iguais do array
            //sobrando somente o valor distinto, ou seja, que não se repete
        }

        return result;
    }

}