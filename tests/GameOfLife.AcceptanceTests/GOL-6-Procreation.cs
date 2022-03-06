using GameOfLife.AcceptanceTests.Fixture;
using NUnit.Framework;

namespace GameOfLife.AcceptanceTests
{
    public class GOL_6_Procreation
    {
        // ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
        // ┃ GOL-6 Procreation                                                  ┃
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
                "XX",
                "X."
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "XX",
                "XX"
            });
        }

        [Test]
        public void TestScenario2()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                ".X",
                "XX"
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "XX",
                "XX"
            });
        }
    }
}
