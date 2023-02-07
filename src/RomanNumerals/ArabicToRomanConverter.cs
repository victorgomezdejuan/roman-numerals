namespace RomanNumerals;
public class ArabicToRomanConverter
{
    private Dictionary<int, string> romanNumbers = new()
    {
        [1] = "I",
        [5] = "V",
        [10] = "X"
    };

    public string Convert(int number)
    {
        string result = string.Empty;

        if (number == GetNumber(number))
        {
            return romanNumbers[number];
        }

        if (number <= GetSmallerNumber(number) * 3)
        {
            result = Convert(GetSmallerNumber(number)) + Convert(number - GetSmallerNumber(number));
        }
        else if (number == GetSmallerNumber(number) * 4)
        {
            result = Convert(GetSmallerNumber(number)) + Convert(GetGreaterNumber(number));
        }
        else
        {
            result = Convert(GetSmallerNumber(number)) + Convert(GetSmallerNumber(GetSmallerNumber(number)));
        }

        return result;
    }

    private int GetNumber(int number)
        => romanNumbers.Keys.Where(n => n == number).FirstOrDefault();

    private int GetSmallerNumber(int number)
        => romanNumbers.Keys.Where(n => n < number).LastOrDefault();

    private int GetGreaterNumber(int number)
        => romanNumbers.Keys.Where(n => n > number).FirstOrDefault();
}
