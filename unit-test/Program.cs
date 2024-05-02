public class Tests
{
    [Test]
    public void TestManipulate()
    {
        List<string> actual = new() { "a", "ab", "abc", "aabb" };
        List<List<string>> expected = new() {
            new() { "a" },
            new() { "ab", "ba" },
            new() { "abc", "acb", "bac", "bca", "cab", "cba" },
            new() { "aabb", "abab", "abba", "baab", "baba", "bbaa" }
         };
        foreach (var item in actual)
        {
            var result = Program.Manipulate(item);
            Assert.That(result, Has.Count.EqualTo(expected[actual.IndexOf(item)].Count));
            foreach (var permutation in result)
            {
                Assert.That(expected[actual.IndexOf(item)], Contains.Item(permutation));
            }
        }
    }
    [Test]
    public void TestOddNumber()
    {
        List<List<int>> actual = new() {
            new List<int> {7},
            new List<int> {0},
            new List<int> {1,1,2},
            new List<int> {0,1,0,1,0},
            new List<int> {1,2,2,3,3,3,4,3,3,3,2,2,1},
        };
        List<List<int>> expected = new() {
            new List<int> {7},
            new List<int> {0},
            new List<int> {2},
            new List<int> {0},
            new List<int> {4}
        };
        foreach (var item in actual)
        {
            List<int> result = Program.OddNumber(item.ToArray());
            Assert.That(result, Is.EqualTo(expected[actual.IndexOf(item)]));
        }
    }
    [Test]
    public void TestSmily()
    {
        List<List<string>> actual = new() {
            new List<string> {":)", ";(", ";}", ":-D"},
            new List<string> {";D", ":-(", ":-)", ";~)"},
            new List<string> {";]", ":[", ";*", ":$", ";-D"},
        };
        List<int> expected = new() {2, 3, 1};
        foreach (var item in actual)
        {
            int result = Program.Smily(item.ToArray());
            Assert.That(result, Is.EqualTo(expected[actual.IndexOf(item)]));
        }
    }
}
