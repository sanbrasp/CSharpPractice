using traditional_no_top_level.Menu;
using traditional_no_top_level.Helpers;

namespace traditional_no_top_level.Tasks;

public class WordFrequency : ITask
{
    
    public string Subject => "Strings";
    public string Title => "Word Frequency";
    public string Description => "Counts word frequency using basic string split and dictionary.";
    public int Number => 3;

    public void Run()
    {
        Console.WriteLine("Paste a short paragraph: ");
        string text = Console.ReadLine() ?? string.Empty;
        
        var separators = new char[] { ' ', '\t', '\r', '\n', ',', '.', '!', '?', ';', ':', '"', 
                                    '\'', '(', ')', '[', ']', '{', '}' };

        var words = text
            .ToLowerInvariant()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries);

        var freq = new Dictionary<string, int>();
        foreach (var w in words)
        {
            if (freq.ContainsKey(w)) freq[w]++;
            else freq[w] = 1;
        }
        foreach (var kv in freq.OrderByDescending(kv => kv.Value).ThenBy(kv => kv.Key))
            Console.WriteLine($"{kv.Key}: {kv.Value}");
    }
}