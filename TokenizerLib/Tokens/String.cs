namespace TokenizerLib.Tokens {
    public class String : ValueToken<string> {
        public String (string val, int line = 0, int column = 0)
            : base (val, line, column) {

        }
    }
}
