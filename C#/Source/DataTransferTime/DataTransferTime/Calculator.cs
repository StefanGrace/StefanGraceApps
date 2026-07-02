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
                throw new OverflowException("Infinite amount of time");
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
    }
}
