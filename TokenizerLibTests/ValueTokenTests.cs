using Microsoft.VisualStudio.TestTools.UnitTesting;
using TokenizerLib.Tokens;

namespace TokenizerLibTests {
    [TestClass]
    public class ValueTokenTests {
        [TestMethod]
        public void Char_Tok_Equal () =>
            Assert.AreEqual ('a'.Into (), 'a');
        [TestMethod]
        public void Char_Val_Equal () =>
            Assert.AreEqual ('a'.Into ().Val, 'a');
        [TestMethod]
        public void Val_Char_Equal () =>
            Assert.AreEqual ('a', 'a'.Into ());

        [TestMethod]
        public void Int_Tok_Equal () =>
            Assert.AreEqual (127.Into (), 127);
        [TestMethod]
        public void Int_Val_Equal () =>
            Assert.AreEqual (127.Into ().Val, 127);
        [TestMethod]
        public void Val_Int_Equal () =>
            Assert.AreEqual (127, 127.Into ());

        [TestMethod]
        public void String_Tok_Equal () =>
            Assert.AreEqual ("test".Into (), "test");
        [TestMethod]
        public void String_Val_Equal () =>
            Assert.AreEqual ("test".Into ().Val, "test");

        [TestMethod]
        public void Val_String_Equal () =>
            Assert.AreEqual ("test", "test".Into ());
    }
}
