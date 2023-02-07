using RomanNumerals;

namespace RomanNumeralsTests;

public class Tests
{
    [Fact]
    public void ConvertFromArabicToRoman()
    {
        string romanNumber = ArabicToRomanConverter.Convert(1);

        Assert.Equal("I", romanNumber);
    }
}