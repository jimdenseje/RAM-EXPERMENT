using RAM_EXPERMENT;

namespace RamExpermentTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddToRam()
        {
            Ram.Write(0, 'a');
            Assert.Equal('a', Ram.Read(0));
        }

        [Fact]
        public void ReadFromRam()
        {
            Ram.Write(0, 'a');
            Ram.Write(1, 'b');
            Ram.Write(2, 'c');
            Assert.Matches("abc", Ram.ReadAll());
        }
    }
}