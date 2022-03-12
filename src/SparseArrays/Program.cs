TextWriter textWriter = new StreamWriter(@"path", true);

int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

List<string> strings = new List<string>();

for (int i = 0; i < stringsCount; i++)
{
    string stringsItem = Console.ReadLine();
    strings.Add(stringsItem);
}

int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

List<string> queries = new List<string>();

for (int i = 0; i < queriesCount; i++)
{
    string queriesItem = Console.ReadLine();
    queries.Add(queriesItem);
}

List<int> res = Result.MatchingStrings(strings, queries);

textWriter.WriteLine(String.Join("\n", res));

textWriter.Flush();
textWriter.Close();

public class Result
{

    /*
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY strings
     *  2. STRING_ARRAY queries
     */

    public static List<int> MatchingStrings(List<string> strings, List<string> queries)
    {
        var stringsCount = strings.Count;
        var queriesCount = queries.Count;

        if(stringsCount < 1 || stringsCount > 1000)
        {
            return new List<int>();
        }

        if(queriesCount < 1 || queriesCount > 1000)
        {
            return new List<int>();
        }

        var match = new List<int>();

        foreach (var query in queries)
        {
            match.Add(strings.Where(x => x == query).Count());
        }

        return match;
    }

}