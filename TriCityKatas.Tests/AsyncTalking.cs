using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCityKatas.Tests
{
    public class AsyncTalkingTests
    {
        [Test]
        public void SaySomethingTest()
        {
            AsyncTalking.SaySomething();

            Assert.That(AsyncTalking.helloWorld, Is.EqualTo(null));
        }
    }

    public static class AsyncTalking
    {
        public static string helloWorld;
        public static async Task<string> SaySomething()
        {
            await Task.Delay(100);
            helloWorld = "Hello world!";
            return "Something";
        }
    }
}
