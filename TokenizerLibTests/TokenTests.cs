using Microsoft.VisualStudio.TestTools.UnitTesting;
using TokenizerLib.Tokens;

namespace TokenizerLibTests {
    [TestClass]
    public class TokenTests {
        [TestMethod]
        public void Token_SameVal_Equal () =>
            Assert.AreEqual<Token<string>> ("test", "test");
        [TestMethod]
        public void Token_DiffVal_NotEqual () =>
            Assert.AreNotEqual<Token<string>> ("test", "tast");

        [TestMethod]
        public void Token_ImplicitReverse_Equal () =>
            Assert.AreEqual ("test", new Token<string> ("test"));

        [TestMethod]
        public void Token_SamePos_Equal () =>
            Assert.AreEqual<Token<string>> (("a", 0, 5), ("a", 0, 5));
        [TestMethod]
        public void Token_DiffPos_Equal () =>
            Assert.AreEqual<Token<string>> (("a", 0, 7), ("a", 1, 3));

        [TestMethod]
        public void EOF_Manual_Equal () =>
            Assert.AreEqual<Token<string>> (new EOF (), "EOF");

        [TestMethod]
        public void WhiteSpace_Manual_Equal () =>
            Assert.AreEqual<Token<string>> (new WhiteSpace (), " ");

        [TestMethod]
        public void Indent_ManualSpace_Equal () =>
            Assert.AreEqual<Token<string>> (new Indent (), "   ");
        [TestMethod]
        public void Indent_ManualTab_Equal () =>
            Assert.AreEqual<Token<string>> (new Indent (), "\t");
        [TestMethod]
        public void Indent_ManualSize_Equal () =>
            Assert.AreEqual<Token<string>> (new Indent (4), "    ");
    }
}
