using System;

namespace Lab3
{
    public class Number
    {
        private string number;
        private byte numberSystem;

        public Number()
        {
            number = "0";
            numberSystem = 10;
        }

        public Number(string number, byte numberSystem)
        {
            this.number = number;
            this.numberSystem = numberSystem;
        }

        public string Num => number;
        public byte NumberSystem => numberSystem;

        public static Number operator +(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Num, first.NumberSystem);
            ulong newSecond = Convert.ToUInt64(second.Num, second.NumberSystem);
            return new Number((newFirst + newSecond).ToString(), 10);
        }

        public static Number operator -(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Num, first.NumberSystem);
            ulong newSecond = Convert.ToUInt64(second.Num, second.NumberSystem);
            return new Number((newFirst - newSecond).ToString(), 10);
        }

        public static Number operator *(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Num, first.NumberSystem);
            ulong newSecond = Convert.ToUInt64(second.Num, second.NumberSystem);
            return new Number((newFirst * newSecond).ToString(), 10);
        }

        public static bool operator ==(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Num, first.NumberSystem);
            ulong newSecond = Convert.ToUInt64(second.Num, second.NumberSystem);
            return newFirst == newSecond;
        }

        public static bool operator !=(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Num, first.NumberSystem);
            ulong newSecond = Convert.ToUInt64(second.Num, second.NumberSystem);
            return newFirst == newSecond;
        }

        public static bool operator <(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Num, first.NumberSystem);
            ulong newSecond = Convert.ToUInt64(second.Num, second.NumberSystem);
            return newFirst == newSecond;
        }
        
        public static bool operator >(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Num, first.NumberSystem);
            ulong newSecond = Convert.ToUInt64(second.Num, second.NumberSystem);
            return newFirst == newSecond;
        }

        public static bool operator >=(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Num, first.NumberSystem);
            ulong newSecond = Convert.ToUInt64(second.Num, second.NumberSystem);
            return newFirst == newSecond;
        }

        public static bool operator <=(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Num, first.NumberSystem);
            ulong newSecond = Convert.ToUInt64(second.Num, second.NumberSystem);
            return newFirst == newSecond;
        }
    }
}