using NUnit.Framework;
using ClassLibrarySpellNumber;


namespace NUnitTestSpellNumber
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test0()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(0);
            Assert.IsTrue(NumbertoWords == "zero");
        }

        [Test]
        public void Test1()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(1);
            Assert.IsTrue(NumbertoWords == "one");
        }

        [Test]
        public void Test10()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(10);
            Assert.IsTrue(NumbertoWords == "ten");
        }

        [Test]
        public void Test15()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(15);
            Assert.IsTrue(NumbertoWords == "fifteen");
        }

        [Test]
        public void Test25()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(25);
            Assert.IsTrue(NumbertoWords == "twenty-five");
        }

        [Test]
        public void Test100()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(100);
            Assert.IsTrue(NumbertoWords == "one hundred ");
        }

        [Test]
        public void Test150()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(150);
            Assert.IsTrue(NumbertoWords == "one hundred and fifty");
        }

        [Test]
        public void Test1000()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(1000);
            Assert.IsTrue(NumbertoWords == "one thousand ");
        }

        [Test]
        public void Test1001()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(1001);
            Assert.IsTrue(NumbertoWords == "one thousand and one");
        }

        [Test]
        public void Test1100()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(1100);
            Assert.IsTrue(NumbertoWords == "one thousand one hundred ");
        }

        [Test]
        public void Test1101()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(1101);
            Assert.IsTrue(NumbertoWords == "one thousand one hundred and one");
        }

        [Test]
        public void Test1151()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(1151);
            Assert.IsTrue(NumbertoWords == "one thousand one hundred and fifty-one");
        }

        [Test]
        public void Test10000()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(10000);
            Assert.IsTrue(NumbertoWords == "ten thousand ");
        }

        [Test]
        public void Test10001()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(10001);
            Assert.IsTrue(NumbertoWords == "ten thousand and one");
        }

        [Test]
        public void Test10100()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(10100);
            Assert.IsTrue(NumbertoWords == "ten thousand one hundred ");
        }

        [Test]
        public void Test10101()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(10101);
            Assert.IsTrue(NumbertoWords == "ten thousand one hundred and one");
        }

        [Test]
        public void Test10151()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(10151);
            Assert.IsTrue(NumbertoWords == "ten thousand one hundred and fifty-one");
        }

        [Test]
        public void Test100000()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(100000);
            Assert.IsTrue(NumbertoWords == "one hundred  thousand ");
        }

        [Test]
        public void Test100001()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(100001);
            Assert.IsTrue(NumbertoWords == "one hundred  thousand and one");
        }

        [Test]
        public void Test100100()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(100100);
            Assert.IsTrue(NumbertoWords == "one hundred  thousand one hundred ");
        }

        [Test]
        public void Test100101()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(100101);
            Assert.IsTrue(NumbertoWords == "one hundred  thousand one hundred and one");
        }

        [Test]
        public void Test100151()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(100151);
            Assert.IsTrue(NumbertoWords == "one hundred  thousand one hundred and fifty-one");
        }

        [Test]
        public void Test1000000()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(1000000);
            Assert.IsTrue(NumbertoWords == "one million ");
        }

        [Test]
        public void Test1000001()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(1000001);
            Assert.IsTrue(NumbertoWords == "one million and one");
        }

        [Test]
        public void Test1000100()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(1000100);
            Assert.IsTrue(NumbertoWords == "one million one hundred ");
        }

        [Test]
        public void Test1000101()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(1000101);
            Assert.IsTrue(NumbertoWords == "one million one hundred and one");
        }

        [Test]
        public void Test1000151()
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(1000151);
            Assert.IsTrue(NumbertoWords == "one million one hundred and fifty-one");
        }
    }
}