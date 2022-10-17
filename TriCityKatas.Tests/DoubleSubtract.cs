namespace TriCityKatas.Tests
{
    internal class DoubleSubtract
    {
        [Test]
        public void CheckSubtraction()
        {
            var value1 = 1.0 - 0.9 - 0.1;
            var value = 0.0;

            Assert.That(value, Is.EqualTo(value1));
        }
    }
}
