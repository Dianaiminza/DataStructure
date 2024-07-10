using System;
using System.Collections.Generic;
using System.Text;

public class TextJustifier
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        IList<string> result = new List<string>();
        List<string> currentLine = new List<string>();
        int currentLineLength = 0;

        foreach (var word in words)
        {
            if (currentLineLength + word.Length + currentLine.Count > maxWidth)
            {
                result.Add(JustifyLine(currentLine, currentLineLength, maxWidth));
                currentLine.Clear();
                currentLineLength = 0;
            }
            currentLine.Add(word);
            currentLineLength += word.Length;
        }

        if (currentLine.Count > 0)
        {
            result.Add(LeftJustifyLine(currentLine, maxWidth));
        }

        return result;
    }

    private string JustifyLine(List<string> lineWords, int lineLength, int maxWidth)
    {
        if (lineWords.Count == 1)
        {
            return LeftJustifyLine(lineWords, maxWidth);
        }

        int totalSpaces = maxWidth - lineLength;
        int spaceSlots = lineWords.Count - 1;
        int spaceWidth = totalSpaces / spaceSlots;
        int extraSpaces = totalSpaces % spaceSlots;

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < lineWords.Count; i++)
        {
            sb.Append(lineWords[i]);
            if (i < lineWords.Count - 1)
            {
                sb.Append(' ', spaceWidth + (i < extraSpaces ? 1 : 0));
            }
        }

        return sb.ToString();
    }

    private string LeftJustifyLine(List<string> lineWords, int maxWidth)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < lineWords.Count; i++)
        {
            if (i > 0)
            {
                sb.Append(' ');
            }
            sb.Append(lineWords[i]);
        }

        sb.Append(' ', maxWidth - sb.Length);
        return sb.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        TextJustifier justifier = new TextJustifier();
        string[] words = { "This", "is", "an", "example", "of", "text", "justification." };
        int maxWidth = 16;

        IList<string> justifiedText = justifier.FullJustify(words, maxWidth);
        foreach (var line in justifiedText)
        {
            Console.WriteLine($"\"{line}\"");
        }
    }
}
