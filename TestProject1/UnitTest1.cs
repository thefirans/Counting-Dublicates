using ConsoleApp1;

namespace TestProject1
{
    public class Tests
    {
        [TestFixture]
        public class KataTest
        {
            [Test]
            public void KataTests()
            {
                Assert.AreEqual(0, Kata.DuplicateCount(""));
                Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
                Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
                Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
                Assert.AreEqual(1, Kata.DuplicateCount("Indivisibility"));
                Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
            }
        }
    }
}