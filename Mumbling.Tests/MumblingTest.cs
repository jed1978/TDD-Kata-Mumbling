using FluentAssert;
using NUnit.Framework;

namespace Mumbling.Tests
{
    [TestFixture]
    public class MumblingTest
    {
        [Test]
        public void Test_EnteredOneLowerCaseLetter()
        {
            var accuml = new Accuml();
            var actual = accuml.Accum("x");
            actual.ShouldBeEqualTo("X");
        }

        
    }
}