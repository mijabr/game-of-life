using GameOfLife.AcceptanceTests.Fixture;
using NUnit.Framework;

namespace GameOfLife.AcceptanceTests
{
    public class GOL_3_Underpopulation
    {
        // ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
        // ┃ GOL-3 Under-population                                             ┃
        // ┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫
        // ┃ As a tech-geek                                                     ┃
        // ┃ I want to be able to apply the under population rule               ┃
        // ┃ So that I can see the life pattern evolutions                      ┃
        // ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛

        [Test]
        public void TestScenario1()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                "...",
                ".X.",
                "...",
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "...",
                "...",
                "..."
            });
        }

        [Test]
        public void TestScenario2()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                ".X.",
                ".X.",
                "...",
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "...",
                "...",
                "..."
            });
        }

        [Test]
        public void TestScenario3()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                "..X",
                "...",
                "X..",
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "...",
                "...",
                "..."
            });
        }

        [Test]
        public void TestScenario4()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                ".X.",
                "...",
                ".X.",
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "...",
                "...",
                "..."
            });
        }

        [Test]
        public void TestScenario5()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                "...",
                "X.X",
                "...",
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "...",
                "...",
                "..."
            });
        }
    }
}
