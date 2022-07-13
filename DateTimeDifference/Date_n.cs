namespace DateTimeDifference;

public class Date_n
{
    private static readonly int[] daysPerMonth = new int[] { 31, 0, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    private readonly int _day, _month, _year;

    private bool IsLeapYear() => _year % 400 == 0 || (_year % 4 == 0 && _year % 100 != 0);

    private int DaysLeftInYear()
    {
        int total = 0;

        for (int i = _month; i < 12; i++)
            total += daysPerMonth[i];

        if (_month < 2)
        {
            total += daysPerMonth[_month - 1] - _day + 1;
            total += IsLeapYear() ? 29 : 28;
        }
        else if (_month == 2)
        {
            total += IsLeapYear() ? 29 - _day + 1 : 28 - _day + 1;
        }
        else
        {
            total += daysPerMonth[_month - 1] - _day + 1;
        }

        return total;
    }

    private int DaysInYear()
    {
        int total = _day - 1;

        for (int i = 0; i < _month - 1; i++)
            total += daysPerMonth[i];

        if (_month >= 2)
            total += IsLeapYear() ? 29 : 28;

        return total;
    }

    public Date_n(int day, int month, int year)
    {
        _day = day;
        _month = month;
        _year = year;
    }

    public static int GetDifference(Date_n d1, Date_n d2)
    {
        int total = d1.DaysLeftInYear();

        for (int i = d1._year + 1; i < d2._year; i++)
            total += new Date_n(1, 1, i).DaysLeftInYear();

        total += d2.DaysInYear();

        return total;
    }
}
