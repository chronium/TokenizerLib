using System;
using System.Collections.Generic;

namespace TokenizerLib.Tokens {
    public class Token<T> where T: class {
        public List<T> Value { get; set; }
        public int Line { get; }
        public int Column { get; }

        public Token (T val, int line = 0, int column = 0) {
            this.Value = new List<T> { val };
            this.Line = line;
            this.Column = column;
        }
        public Token (List<T> val, int line = 0, int column = 0) {
            this.Value = val;
            this.Line = line;
            this.Column = column;
        }

        public override bool Equals (object obj) {
            if (obj == null)
                return false;

            if (!(obj is Token<T>))
                return false;

            if (this == (Token<T>) obj)
                return true;

            return false;
        }

        public static bool operator == (Token<T> a, Token<T> b) {
            if (ReferenceEquals (a, b))
                return true;

            if (((object) a == null) || ((object) b == null))
                return false;

            foreach (var v in b.Value)
                if (a.Value.Contains (v))
                    return true;
            return false;
        }

        public static bool operator != (Token<T> a, Token<T> b) {
            return !(a == b);
        }

        public static implicit operator Token<T> (T val) {
            return new Token<T> (val);
        }

        public static implicit operator Token<T>((T val, int line, int column) val) {
            return new Token<T> (val.val, val.line, val.column);
        }

        public override int GetHashCode () {
            return $"{this.Value.GetHashCode ()}--{this.Line}--{this.Column}".GetHashCode ();
        }
    }
}
