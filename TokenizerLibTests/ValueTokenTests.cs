using Microsoft.VisualStudio.TestTools.UnitTesting;
using TokenizerLib.Tokens;

namespace TokenizerLibTests {
    [TestClass]
    public class ValueTokenTests {
        [TestMethod]
        public void Char_Tok_Equal () =>
            Assert.AreEqual<ValueToken<char>> (new Char ('a'), 'a');
        [TestMethod]
        public void Char_Val_Equal () =>
            Assert.AreEqual (new Char ('a').Val, 'a');
        [TestMethod]
        public void Val_Char_Equal () =>
            Assert.AreEqual ('a', new Char ('a'));

        [TestMethod]
        public void Int_Tok_Equal () =>
            Assert.AreEqual<ValueToken<ulong>> (new Number (127), 127);
        [TestMethod]
        public void Int_Val_Equal () =>
            Assert.AreEqual<ulong> (new Number (127).Val, 127);
        [TestMethod]
        public void Val_Int_Equal () =>
            Assert.AreEqual (127, new Number (127));

        [TestMethod]
        public void String_Tok_Equal () =>
            Assert.AreEqual<ValueToken<string>> (new String ("test"), "test");
        [TestMethod]
        public void String_Val_Equal () =>
            Assert.AreEqual (new String ("test").Val, "test");

        [TestMethod]
        public void Val_String_Equal () =>
            Assert.AreEqual ("test", new String ("test"));
    }
}
