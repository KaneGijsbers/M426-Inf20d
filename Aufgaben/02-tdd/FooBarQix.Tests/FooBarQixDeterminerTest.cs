using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Determine_whenNumberNotDividibleByThreeFiveSeven_shouldReturnNumberAsString()
        {
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var number = 4;
            var expectedResult = "4";

            var result = fooBarQixDeterminer.Determine(number);

            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void Determine_whenNumberIsDividedByThree_shouldReturnFoo()
        {
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var number = 3;
            var expectedResult = "Foo";

            var result = fooBarQixDeterminer.Determine(number);

            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void Determine_whenNumberIsDividedByFive_shouldReturnBar()
        {
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var number = 5;
            var expectedResult = "Bar";

            var result = fooBarQixDeterminer.Determine(number);

            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void Determine_whenNumberIsDividedBySeven_shouldReturnQix()
        {
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var number = 7;
            var expectedResult = "Qix";

            var result = fooBarQixDeterminer.Determine(number);

            Assert.Equal(expectedResult, result);
        }
    }
}