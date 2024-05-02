using System.Text.RegularExpressions;

public static partial class Program
{
    static void Main(string[] args)
    {
        // example usage
        // please run test cases to verify the correctness of the code below
        Console.WriteLine("Manipulate: "+ string.Join(",", Manipulate("abc")));
        Console.WriteLine("OddNumber: "+ string.Join(",", OddNumber(new int[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1, 1 })));
        Console.WriteLine("Smily: "+ Smily(new string[] { ":)", ";(", ";}", ":-D" }));
    }

    public static List<string> Manipulate(string input)
    {
        if (input.Length == 1) return new List<string> { input };
        HashSet<string> permutations = new();
        for (int i = 0; i < input.Length; i++)
        {
            var character = input[i];
            var remaining = input.Remove(i, 1);
            foreach (var permutation in Manipulate(remaining))
            {
                permutations.Add(character + permutation);
            }
        }
        return permutations.ToList();
    }
    public static List<int> OddNumber(int[] input)
    {
        List<int> oddNumbers = input.GroupBy(x => x)
            .Where(g => g.Count() % 2 != 0)
            .Select(g => g.Key)
            .ToList();
        if (oddNumbers.Count > 0)
        {
            return oddNumbers;
        }

        throw new ArgumentException("No odd occurrence found");
    }
    public static int Smily(string[] input)
    {
        var smileyPattern = MyRegex();
        var count = 0;

        foreach (var str in input)
        {
            if (smileyPattern.IsMatch(str)) count++;
        }

        return count;
    }

    [GeneratedRegex("^[:;][-~]?[)D]$")]
    private static partial Regex MyRegex();
}
