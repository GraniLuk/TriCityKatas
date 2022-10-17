using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCityKatas.Tests
{
    internal class Enums
    {
        internal enum TestEnum
        {
            Val0 = 0,
        }

        public static string DoWork(TestEnum testEnum)
        {
            return testEnum.GetType().Name;
        }
        public static string DoWork(object testObject)
        {
            return testObject.GetType().Name;
        }

        [Test]
        public void CheckTypes()
        {
            Assert.That(DoWork((int)TestEnum.Val0), Is.EqualTo("TestEnum"));
            TestEnum val0 = TestEnum.Val0;
            Assert.That(DoWork((int)val0), Is.EqualTo("Int32"));
        }
    }
}
