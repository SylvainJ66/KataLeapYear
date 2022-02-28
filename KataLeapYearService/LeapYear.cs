namespace KataLeapYearService;

/// <summary>
/// Write a function that returns true or false depending on whether its input integer is a leap year or not.
/// A leap year is divisible by 4 but is not otherwise divisible by 100 unless it is also divisible by 400.
/// </summary>
public class LeapYear
{
    public bool IsLeap(int year)
    {
        if(IsDivisibleBy4(year) && !IsDivisibleBy100(year) || (IsDivisibleBy100(year) && IsDivisibleBy400(year)))
        {
            return true;
        }
        return false;
    }

    private bool IsDivisibleBy4(int number)
    {
        return number % 4 == 0;
    }

    private bool IsDivisibleBy100(int number)
    {
        return number % 100 == 0;
    }

    private bool IsDivisibleBy400(int number)
    {
        return number % 400 == 0;
    }
}
