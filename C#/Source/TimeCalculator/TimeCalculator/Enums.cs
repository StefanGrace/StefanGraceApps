namespace TimeCalculator
{
    enum Function
    {
        DisplayDuration,
        AddDurations,
        DifferenceBetweenDurations,
        DurationTimesNumber,
        DurationDividedByNumber,
        AddDurationToDate,
        SubtractDurationFromDate,
        DifferenceBetweenDates,
        AddDurationToCurrentDate,
        SubtractDurationFromCurrentDate,
        DifferenceBetweenDateAndCurrentDate,
    }

    enum DataType
    {
        None,
        Number,
        Duration,
        Date,
    }

    enum DateFormat
    {
        SystemShort,
        SystemLong,
        ISO8601,
    }
}