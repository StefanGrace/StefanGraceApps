using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalTime
{
    class Clock
    {
        private Funcion funcion = Funcion.DisplayCurrentTime;
        private int inputHour = 0;
        private int inputMinute = 0;
        private int inputSecond = 0;

        public Funcion Funcion { get => funcion; set => funcion = value; }
        public int InputHour { get => inputHour; set => inputHour = value; }
        public int InputMinute { get => inputMinute; set => inputMinute = value; }
        public int InputSecond { get => inputSecond; set => inputSecond = value; }

        private double DayProgress
        {
            get
            {
                if (funcion == Funcion.DisplayCurrentTime)
                {
                    DateTime current = DateTime.Now;
                    return ((double)current.Hour / 24) +
                        ((double)current.Minute / 1440) +
                        ((double)current.Second / 86_400) +
                        ((double)current.Millisecond / 86_400_000);
                }
                else
                {
                    return ((double)inputHour / HoursInDay) + ((double)inputMinute / MinutesInDay) + ((double)inputSecond / SecondsInDay);
                }
            }
        }

        private Tuple<int, int, int> HoursInDay_MinutesInHour_SecondsInMinute
        {
            get
            {
                switch (funcion)
                {
                    case Funcion.ConvertFrom10_100_100:
                        return new Tuple<int, int, int>(10, 100, 100);

                    case Funcion.ConvertFrom20_50_100:
                        return new Tuple<int, int, int>(20, 50, 100);

                    case Funcion.ConvertFrom24_100_100:
                        return new Tuple<int, int, int>(24, 100, 100);

                    default:
                        return new Tuple<int, int, int>(24, 60, 60);
                }
            }
        }

        private int HoursInDay { get => HoursInDay_MinutesInHour_SecondsInMinute.Item1; }
        private int MinutesInHour { get => HoursInDay_MinutesInHour_SecondsInMinute.Item2; }
        private int SecondsInMinute { get => HoursInDay_MinutesInHour_SecondsInMinute.Item3; }

        private int MinutesInDay { get => HoursInDay * MinutesInHour; }
        private int SecondsInHour { get => MinutesInHour * SecondsInMinute; }
        private int SecondsInDay { get => HoursInDay * MinutesInHour * SecondsInMinute; }


        public Tuple<int, int, int> GetHoursMinuteSeconds(int hoursInDay, int minutesInHour, int secondsInMinute)
        {
            double dayProgress = DayProgress;

            int outputHour = (int)(dayProgress * hoursInDay);

            int outputMinute = (int) Math.Round((dayProgress - ((double)outputHour / hoursInDay)) * (hoursInDay * minutesInHour), 8);

            int outputSecond = (int)Math.Round((dayProgress - (((double)outputHour / hoursInDay) + ((double)outputMinute / (hoursInDay * minutesInHour)))) *
                (hoursInDay * minutesInHour * secondsInMinute), 8);

            return new Tuple<int, int, int>(outputHour, outputMinute, outputSecond);
        }

    }
}
