namespace TokenizerLib.Tokens {
    public class Char : ValueToken<char> {
        public Char (char val, int line = 0, int column = 0)
            : base (val, line, column) {
        }
    }
}
