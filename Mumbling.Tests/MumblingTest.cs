using FluentAssert;
using NUnit.Framework;

namespace Mumbling.Tests
{
    [TestFixture]
    public class MumblingTest
    {
        private Accuml _accuml = new Accuml();

        [Test]
        public void Test_Entered_x_ShouldReturn_X()
        {
            var actual = _accuml.Accum("x");
            var expected = "X";
            actual.ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_Entered_xb_ShouldBe_X_Bb()
        {
            var actual = _accuml.Accum("xb");
            var expected = "X-Bb";
            actual.ShouldBeEqualTo(expected);
        }

        
    }
}