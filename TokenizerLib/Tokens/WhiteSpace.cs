namespace TokenizerLib.Tokens {
    public class WhiteSpace : Token<string> {
        public WhiteSpace (int line = 0, int column = 0) 
            : base (" ", line, column) {
        }
    }
}
