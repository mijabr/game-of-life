using GameOfLife.AcceptanceTests.Fixture;
using NUnit.Framework;

namespace GameOfLife.AcceptanceTests
{
    public class GOL_4_Survival
    {
        // ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
        // ┃ GOL-4 Survival                                                     ┃
        // ┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫
        // ┃ As a tech-geek                                                     ┃
        // ┃ I want to be able to apply the survival rule                       ┃
        // ┃ So that I can see the life pattern evolutions                      ┃
        // ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛

        [Test]
        public void TestScenario1_Block()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                "....",
                ".XX.",
                ".XX.",
                "...."
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "....",
                ".XX.",
                ".XX.",
                "...."
            });
        }

        [Test]
        public void TestScenario2_BeeHive()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                "......",
                "..XX..",
                ".X..X.",
                "..XX..",
                "......"
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "......",
                "..XX..",
                ".X..X.",
                "..XX..",
                "......"
            });
        }

        [Test]
        public void TestScenario3_Loaf()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                "......",
                "..XX..",
                ".X..X.",
                "..X.X.",
                "...X..",
                "......"
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "......",
                "..XX..",
                ".X..X.",
                "..X.X.",
                "...X..",
                "......"
            });
        }

        [Test]
        public void TestScenario4_Boat()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                ".....",
                ".XX..",
                ".X.X.",
                "..X..",
                "....."
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                ".....",
                ".XX..",
                ".X.X.",
                "..X..",
                "....."
            });
        }

        [Test]
        public void TestScenario5_Tub()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                ".....",
                "..X..",
                ".X.X.",
                "..X..",
                "....."
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                ".....",
                "..X..",
                ".X.X.",
                "..X..",
                "....."
            });
        }
    }
}
