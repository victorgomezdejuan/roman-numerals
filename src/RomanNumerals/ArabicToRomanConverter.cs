namespace RomanNumerals;
public class ArabicToRomanConverter
{
    private Dictionary<int, string> romanNumbers = new() {
        [1] = "I",
        [5] = "V",
        [10] = "X"
    };

    public string Convert(int number)
    {
        string result = string.Empty;
        int nextSmallerNumber = romanNumbers.Keys.Where(n => n <= number).Max();
        
        for(int i = number; i > 0; i -= nextSmallerNumber)
            result += romanNumbers[nextSmallerNumber];

        return result;
    }
}
