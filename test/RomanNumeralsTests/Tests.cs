using RomanNumerals;

namespace RomanNumeralsTests;

public class Tests
{
    [Fact]
    public void ConvertFromArabicToRoman()
    {
        AssertConvertion(1, "I");
        AssertConvertion(2, "II");
        AssertConvertion(3, "III");
        AssertConvertion(4, "IV");
        AssertConvertion(5, "V");
        AssertConvertion(6, "VI");
        AssertConvertion(7, "VII");
        AssertConvertion(8, "VIII");
        AssertConvertion(10, "X");
        AssertConvertion(9, "IX");
    }

    private static void AssertConvertion(int Number, string Expected)
    {
        ArabicToRomanConverter converter = new();
        string romanNumber = converter.Convert(Number);
        Assert.Equal(Expected, romanNumber);
    }
}