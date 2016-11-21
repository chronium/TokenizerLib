namespace TokenizerLib.Tokens {
    public class Number : ValueToken<ulong> {
        public Number (ulong val, int line = 0, int column = 0)
            : base (val, line, column) {
        }

        public static implicit operator sbyte (Number val) => (sbyte) val.Val;
        public static implicit operator short (Number val) => (short) val.Val;
        public static implicit operator int (Number val) => (int) val.Val;
        public static implicit operator long (Number val) => (long) val.Val;

        public static implicit operator byte (Number val) => (byte) val.Val;
        public static implicit operator ushort (Number val) => (ushort) val.Val;
        public static implicit operator uint (Number val) => (uint) val.Val;

        public static implicit operator Number (sbyte val) => new Number ((ulong) val);
        public static implicit operator Number (short val) => new Number ((ulong) val);
        public static implicit operator Number (int val) => new Number ((ulong) val);
        public static implicit operator Number (long val) => new Number ((ulong) val);

        public static implicit operator Number (byte val) => new Number (val);
        public static implicit operator Number (ushort val) => new Number (val);
        public static implicit operator Number (uint val) => new Number (val);
    }
}
