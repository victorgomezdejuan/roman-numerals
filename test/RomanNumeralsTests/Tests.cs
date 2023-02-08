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
        AssertConvertion(9, "IX");
        AssertConvertion(10, "X");
        AssertConvertion(11, "XI");
        AssertConvertion(12, "XII");
        AssertConvertion(13, "XIII");
        AssertConvertion(14, "XIV");
        AssertConvertion(15, "XV");
        AssertConvertion(16, "XVI");
        AssertConvertion(20, "XX");
        AssertConvertion(29, "XXIX");
        AssertConvertion(40, "XL");
        AssertConvertion(50, "L");
        AssertConvertion(80, "LXXX");
        AssertConvertion(94, "XCIV");
        AssertConvertion(100, "C");
        AssertConvertion(294, "CCXCIV");
        AssertConvertion(500, "D");
        AssertConvertion(700, "DCC");
        AssertConvertion(1000, "M");
    }

    private static void AssertConvertion(int Number, string Expected)
    {
        ArabicToRomanConverter converter = new();
        string romanNumber = converter.Convert(Number);
        Assert.Equal(Expected, romanNumber);
    }
}