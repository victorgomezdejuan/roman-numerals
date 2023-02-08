namespace RomanNumerals;
public class ArabicToRomanConverter
{
    private Dictionary<int, string> romanNumbers = new()
    {
        [1] = "I",
        [5] = "V",
        [10] = "X",
        [50] = "L",
        [100] = "C",
        [500] = "D",
        [1000] = "M"
    };

    public string Convert(int number)
    {
        if (number <= 0)
            return string.Empty;
        if (number == GetNumber(number))
            return romanNumbers[number];

        return ConvertComplex(number);
    }

    private string ConvertComplex(int number)
    {
        if (Base5SymbolShouldBeSubstracted(number))
            return ConvertSubstracted(number, false);
        else if (Base1SymbolShouldBeSubstracted(number))
            return ConvertSubstracted(number, true);
        else
            return ConvertRepeated(number);
    }

    private string ConvertSubstracted(int number, bool IsBase1)
    {
        int smaller = IsBase1 ? GetBase1Smaller(number) : GetBase5Smaller(number);
        int greater = GetGreater(number);
        int rest = number - (greater - smaller);

        return Convert(smaller) + Convert(greater) + Convert(rest);
    }

    private string ConvertRepeated(int number)
    {
        int smaller = GetBase5Smaller(number);
        return Convert(smaller) + Convert(number - smaller);
    }

    private int GetNumber(int number)
        => romanNumbers.Keys.Where(n => n == number).FirstOrDefault();

    private int GetBase1Smaller(int number)
        => GetBase5Smaller(GetBase5Smaller(number));

    private int GetBase5Smaller(int number)
        => romanNumbers.Keys.Where(n => n < number).LastOrDefault();

    private int GetGreater(int number)
        => romanNumbers.Keys.Where(n => n > number).FirstOrDefault();

    private bool Base5SymbolShouldBeSubstracted(int number)
        => GetBase5Smaller(number) > 0 && number >= GetBase5Smaller(number) * 4;

    private bool Base1SymbolShouldBeSubstracted(int number)
        => GetBase1Smaller(number) > 0 && number >= GetBase1Smaller(number) * 9;
}
