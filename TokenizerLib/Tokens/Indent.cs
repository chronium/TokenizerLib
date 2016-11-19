using System;
using System.Collections.Generic;

namespace TokenizerLib.Tokens {
    public class Indent : Token<string> {
        public Indent (int line = 0, int column = 0)
            : base (new List<string> { "   ", "\t" }, line, column) {
        }
    }
}
