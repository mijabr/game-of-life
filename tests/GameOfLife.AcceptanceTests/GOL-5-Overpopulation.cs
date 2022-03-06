using GameOfLife.AcceptanceTests.Fixture;
using NUnit.Framework;

namespace GameOfLife.AcceptanceTests
{
    public class GOL_5_Overpopulation
    {
        // ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
        // ┃ GOL-5 Over-population                                              ┃
        // ┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫
        // ┃ As a tech-geek                                                     ┃
        // ┃ I want to be able to apply the over-population rule                ┃
        // ┃ So that I can see the life pattern evolutions                      ┃
        // ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛

        [Test]
        public void TestScenario1()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                "XXX",
                "XXX"
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "X.X",
                "X.X"
            });
        }

        [Test]
        public void TestScenario2()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                "XXXX",
                "XXXX",
                "XXXX"
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "X..X",
                "....",
                "X..X"
            });
        }
    }
}
