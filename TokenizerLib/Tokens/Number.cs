namespace TokenizerLib.Tokens {
    public class Number<T> : ValueToken<T> {
        public Number (T val, int line = 0, int column = 0)
            : base (val, line, column) {
        }
    }
}
