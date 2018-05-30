using FluentAssert;
using NUnit.Framework;

namespace Mumbling.Tests
{
    [TestFixture]
    public class MumblingTest
    {
        [Test]
        public void Test_Entered_x_ShouldReturn_X()
        {
            var accuml = new Accuml();
            var actual = accuml.Accum("x");
            actual.ShouldBeEqualTo("X");
        }

        [Test]
        public void Test_Entered_xb_ShouldBe_X_Bb()
        {
            var accuml = new Accuml();
            var actual = accuml.Accum("xb");
            actual.ShouldBeEqualTo("X-Bb");
        }
    }
}