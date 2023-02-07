﻿namespace RomanNumerals;
public class ArabicToRomanConverter
{
    private Dictionary<int, string> romanNumbers = new()
    {
        [1] = "I",
        [5] = "V",
        [10] = "X",
        [50] = "V"
    };

    public string Convert(int number)
    {
        if (number == GetNumber(number))
            return romanNumbers[number];

        string result = string.Empty;

        if (number == GetSmallerNumber(number) * 4)
            result = Convert(GetSmallerNumber(number)) + Convert(GetGreaterNumber(number));
        else if (number == GetSecondSmallerNumber(number) * 9)
            result = Convert(GetSecondSmallerNumber(number)) + Convert(GetGreaterNumber(number));
        else
            result = Convert(GetSmallerNumber(number)) + Convert(number - GetSmallerNumber(number));

        return result;
    }

    private int GetNumber(int number)
        => romanNumbers.Keys.Where(n => n == number).FirstOrDefault();

    private int GetSecondSmallerNumber(int number)
        => GetSmallerNumber(GetSmallerNumber(number));

    private int GetSmallerNumber(int number)
        => romanNumbers.Keys.Where(n => n < number).LastOrDefault();

    private int GetGreaterNumber(int number)
        => romanNumbers.Keys.Where(n => n > number).FirstOrDefault();
}
