using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCityKatas.Tests
{
    internal class DivideIntegers
    {
        [Test]
        public void DivideIntegersTest()
        {
            int a = 3;
            int b = 6;
            var result1 = a / b;
            Assert.That(result1, Is.EqualTo(0));

            int a2 = 4;
            int b2 = 6;
            var result2 = a2 / b2;
            Assert.That(result2, Is.EqualTo(0));
        }
    }
}
