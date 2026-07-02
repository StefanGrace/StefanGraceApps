using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferTime
{
    class Calculator
    {
        public static TimeSpan CalculateTrasferTime(DataAmount dataRateData, TimeSpan dataRateTime, DataAmount totalData)
        {
            double trasferTimeTicks = (totalData.Bits / dataRateData.Bits) * dataRateTime.Ticks;

            if (double.IsNaN(trasferTimeTicks))
            {
                throw new ArithmeticException("Undefined amount of time");
            }

            if (double.IsInfinity(trasferTimeTicks))
            {
                throw new ArithmeticException("Infinite amount of time");
            }

            if (trasferTimeTicks > long.MaxValue)
            {
                throw new OverflowException(Formatter.FormatYearsFromTicks(trasferTimeTicks));
            }

            if (trasferTimeTicks < 100 && trasferTimeTicks > 0)
            {
                throw new InvalidCastException(Formatter.FormatSubSecondsFromTicks(trasferTimeTicks, -21));
            }

            return new TimeSpan((long) trasferTimeTicks);
        }

        public static DateTime CalculateFinishDate(DateTime startDate, TimeSpan duration)
        {
            return startDate.Add(duration);
        }

        public static long CalculateFinishYear(DateTime startDate, DataAmount dataRateData, TimeSpan dataRateTime, DataAmount totalData)
        {
            double trasferTimeTicks = (totalData.Bits / dataRateData.Bits) * dataRateTime.Ticks;
            double ticksInYear = 10_000_000.0 * 60.0 * 60.0 * 24.0 * 365.2425;
            double trasferTimeYears = trasferTimeTicks / ticksInYear;

            checked
            {
                return startDate.Year + (long)trasferTimeYears;
            }
        }
    }
}

   
