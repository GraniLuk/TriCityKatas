using Moq;
using NSubstitute;

namespace TriCityKatas.Tests;
public class Human
{
    public IHygieneFunctions HygieneFunctions { get; }
    public IMouthStuff MouthStuff { get; }

    public Human(IHygieneFunctions hygieneFunctions, IMouthStuff mouthStuff)
    {
        HygieneFunctions = hygieneFunctions;
        MouthStuff = mouthStuff;
    }

    public void BreakfastRoutine()
    {
        MouthStuff.ChewYummyYummies();

        HygieneFunctions.BrushTeeth();
    }
}

public interface IHygieneFunctions
{
    void BrushTeeth();
}

public interface IMouthStuff
{
    void ChewYummyYummies();
}

public class MockOrderTests
{
    [Test]
    public void BreakfastRoutine_ShouldBrushTeethAfterEating()
    {
        //Arrange
        var hygieneFunctionsMock = new Mock<IHygieneFunctions>();
        var mouthStuffMock = new Mock<IMouthStuff>();
        var human = new Human(hygieneFunctionsMock.Object, mouthStuffMock.Object);
        bool isInvoked = false;
        mouthStuffMock.Setup(x => x.ChewYummyYummies()).Callback(() => { isInvoked = true; });
        hygieneFunctionsMock.Setup(x=>x.BrushTeeth()).Callback(() => { if (isInvoked) throw new Exception(); });

        human.BreakfastRoutine();
    }

    [Test]
    public void BreakfastRoutine_ShouldBrushTeethAfterEatingWithSubstitute()
    {
        //Arrange
        var hygieneFunctionsMock = Substitute.For<IHygieneFunctions>();
        var mouthStuffMock = Substitute.For<IMouthStuff>();
        var human = new Human(hygieneFunctionsMock, mouthStuffMock);

        human.BreakfastRoutine();

        Received.InOrder(() =>
        {
            mouthStuffMock.ChewYummyYummies();
            hygieneFunctionsMock.BrushTeeth();
        });
    }

}
