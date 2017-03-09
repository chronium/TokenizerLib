namespace TokenizerLib.Tokens {
    public class ValueToken<TVal> : Token<string> {
        public TVal Val { get; }

        public ValueToken (TVal val, int line = 0, int column = 0)
            : base (val.ToString (), line, column) {
            this.Val = val;
        }

        public static implicit operator ValueToken<TVal> (TVal val) => 
            new ValueToken<TVal> (val);
        public static implicit operator ValueToken<TVal> ((TVal val, int line, int column) val) =>
            new ValueToken<TVal> (val.val, val.line, val.column);
        public static implicit operator TVal (ValueToken<TVal> val) => 
            val.Val;

        public override bool Equals (object obj) {
            if (obj == null)
                return false;

            if (Val.Equals(obj))
                return true;


            if (!(obj is ValueToken<TVal>))
                return false;

            if (this == (ValueToken<TVal>) obj)
                return true;

            return false;
        }

        public static bool operator == (ValueToken<TVal> a, ValueToken<TVal> b) {
            if (ReferenceEquals (a, b))
                return true;

            if (((object) a == null) || ((object) b == null))
                return false;
            
            return a.Val.Equals(b.Val);
        }

        public static bool operator != (ValueToken<TVal> a, ValueToken<TVal> b) => !(a == b);

        public override int GetHashCode () =>
            $"{this.Val.GetHashCode ()}--{this.Line}--{this.Column}".GetHashCode ();
    }

    public static class IntoValueToken {
        public static ValueToken<T> Create<T> (T from) => new ValueToken<T> (from);
        public static ValueToken<T> Into<T> (this T from) => Create (from);
    }
}
