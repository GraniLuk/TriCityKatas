using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCityKatas.Tests
{
    public interface IDateTimeMock
    {
        DateTime SpecialDate { get; }
    }
    public class MockingDatesTests
    {
        [Test]
        public void CheckDates()
        {
            var dateTimeMock = Substitute.For<IDateTimeMock>();
            dateTimeMock.SpecialDate.Returns(DateTime.UtcNow);

            var firstDate = dateTimeMock.SpecialDate;
            var secondDate = dateTimeMock.SpecialDate;

            Assert.That(firstDate, Is.EqualTo(secondDate));
        }

        [Test]
        public void CheckDatesTwo()
        {
            var dateTimeMock = Substitute.For<IDateTimeMock>();
            dateTimeMock.SpecialDate.Returns(x => DateTime.UtcNow);

            var firstDate = dateTimeMock.SpecialDate;
            var secondDate = dateTimeMock.SpecialDate;

            Assert.That(firstDate, Is.EqualTo(secondDate));
        }
    }
}
