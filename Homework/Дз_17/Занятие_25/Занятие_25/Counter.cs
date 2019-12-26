﻿namespace Занятие_25
{
    public class Counter
    {
        public int Value { get; set; }

        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value + c2.Value };

        }

        public static Counter operator -(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value - c2.Value };

        }

        public static Counter operator *(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value * c2.Value };

        }

        public static Counter operator /(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value / c2.Value };

        }

        public static bool operator >(Counter c1, Counter c2)
        {
            return c1.Value > c2.Value;
        }

        public static bool operator <(Counter c1, Counter c2)
        {
            return c1.Value < c2.Value;
        }
    }
}
