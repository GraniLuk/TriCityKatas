using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCityKatas.Tests
{
    internal class CompareNulls
    {
        [Test]
        public void CompareNullsTest()
        {
            Assert.That(null <= null, Is.False);
            Assert.That(null == null, Is.True);
        }
    }
}
