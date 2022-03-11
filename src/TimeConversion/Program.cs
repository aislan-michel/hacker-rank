// See https://aka.ms/new-console-template for more information

TextWriter textWriter = new StreamWriter(@"D:\dev\Projetos\HackerRank\src\TimeConversion\teste.txt", true);

string s = Console.ReadLine();

string result = Result.TimeConversion(s);

textWriter.WriteLine(result);

textWriter.Flush();
textWriter.Close();

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string TimeConversion(string s)
    {
        if(!DateTime.TryParse(s, out var dateTime))
        {
            return string.Empty;
        }

        return dateTime.ToString("HH:mm:ss");
    }

}
