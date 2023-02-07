using RomanNumerals;

namespace RomanNumeralsTests;

public class Tests
{
    [Fact]
    public void Convert1FromArabicToRoman()
    {
        AssertConvertion(1, "I");
        AssertConvertion(5, "V");
        AssertConvertion(10, "X");
        AssertConvertion(2, "II");
    }

    private static void AssertConvertion(int Number, string Expected)
    {
        ArabicToRomanConverter converter = new();
        string romanNumber = converter.Convert(Number);
        Assert.Equal(Expected, romanNumber);
    }
}