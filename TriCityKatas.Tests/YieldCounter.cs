namespace TriCityKatas.Tests;

public class Tests
{
    public static int counter;

    [Test]
    public void Test1()
    {
        var result = GetNumbers();
        Assert.That(counter, Is.EqualTo(0));
        Assert.That(result.First(), Is.EqualTo(0));
        Assert.That(counter, Is.EqualTo(1));
        Assert.That(result.Skip(1).First(), Is.EqualTo(1));
        Assert.That(counter, Is.EqualTo(3));
        Assert.That(result.Last(), Is.EqualTo(9));
        Assert.That(counter, Is.EqualTo(13));
        GetNumbers().ToList();
        Assert.That(counter, Is.EqualTo(23));
    }

    public static IEnumerable<int> GetNumbers()
    {
        for (int i = 0; i < 10; i++)
        {
            counter++;
            yield return i;
        }
    }
}