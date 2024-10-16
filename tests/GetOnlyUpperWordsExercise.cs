// See https://aka.ms/new-console-template for more information
public class Exercise
{
    public List<string> GetOnlyUpperCaseWords(List<string> words)
    {
        var result = new List<string>();
        foreach (var word in words)
        {
            if (result.Contains(word))
            {
                continue;
            }
            bool isWordUpperCase = true;
            foreach (char letter in word)
            {
                if (!char.IsUpper(letter))
                {
                    isWordUpperCase = false;
                }
            }
            if (isWordUpperCase)
            {
                result.Add(word);
            }
        }
        return result;
    }
}
