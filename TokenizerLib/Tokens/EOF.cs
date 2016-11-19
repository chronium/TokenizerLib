namespace TokenizerLib.Tokens {
    public class EOF : Token<string> {
        public EOF (int line = 0, int column = 0) 
            : base ("EOF", line, column) {
        }
    }
}
