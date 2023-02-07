using RomanNumerals;

namespace RomanNumeralsTests;

public class Tests
{
    [Fact]
    public void ConvertFromArabicToRoman()
    {
        AssertConvertion(1, "I");
        AssertConvertion(5, "V");
        AssertConvertion(10, "X");
        AssertConvertion(2, "II");
        AssertConvertion(3, "III");
        AssertConvertion(4, "IV");
        AssertConvertion(6, "VI");
    }

    private static void AssertConvertion(int Number, string Expected)
    {
        ArabicToRomanConverter converter = new();
        string romanNumber = converter.Convert(Number);
        Assert.Equal(Expected, romanNumber);
    }
}