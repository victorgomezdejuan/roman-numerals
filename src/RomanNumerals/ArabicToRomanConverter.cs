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
        return romanNumbers[number];
    }
}
