using System.Text;

string input = "        EverytHing  i neeD,    is a CuP   of       CoFFee    ";

input = input.Trim();

string[] words = input.Split(' ');

words = words.Where(word => !string.IsNullOrWhiteSpace(word)).ToArray();

StringBuilder correctPhrase = new StringBuilder();

foreach (string word in words)
{
    if (correctPhrase.Length > 0)
    {
        correctPhrase.Append(' ');
    }
    correctPhrase.Append(char.ToUpper(word[0]));
    correctPhrase.Append(word.Substring(1).ToLower());
}

Console.WriteLine(correctPhrase.ToString());