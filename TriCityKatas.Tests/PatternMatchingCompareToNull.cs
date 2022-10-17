using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCityKatas.Tests;
internal class PatternMatchingCompareToNull
{
    public static int CheckNull()
    {
        MyClass myClassObject = null;
        int result = 0;
        if (myClassObject == null)
        {
            result++;
        }
        if (myClassObject is null)
        {
            result++;
        }
        return result;
    }

    public class MyClass
    {
        public static bool operator ==(MyClass a, MyClass b) => false;
        public static bool operator !=(MyClass a, MyClass b) => false;
    }

    [Test]
    public void CheckNullTests()
    {
        var result = CheckNull();
        Assert.That(result, Is.EqualTo(2));
    }
}
