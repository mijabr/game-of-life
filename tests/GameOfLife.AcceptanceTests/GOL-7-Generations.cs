using GameOfLife.AcceptanceTests.Fixture;
using NUnit.Framework;

namespace GameOfLife.AcceptanceTests
{
    public class GOL_7_Generations
    {
        // ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
        // ┃ GOL-7 Generations                                                  ┃
        // ┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫
        // ┃ As a tech-geek                                                     ┃
        // ┃ I want to be able to iterate through many generations              ┃
        // ┃ So that I can see the life pattern evolutions                      ┃
        // ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛

        [Test]
        public void TestScenario1_Blinker()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                ".X.",
                ".X.",
                ".X."
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "...",
                "XXX",
                "..."
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                ".X.",
                ".X.",
                ".X."
            });
        }

        [Test]
        public void TestScenario2_Toad()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                "......",
                "......",
                "..XXX.",
                ".XXX..",
                "......",
                "......"
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "......",
                "...X..",
                ".X..X.",
                ".X..X.",
                "..X...",
                "......"
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "......",
                "......",
                "..XXX.",
                ".XXX..",
                "......",
                "......"
            });
        }

        [Test]
        public void TestScenario3_Beacon()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                "......",
                ".XX...",
                ".XX...",
                "...XX.",
                "...XX.",
                "......"
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "......",
                ".XX...",
                ".X....",
                "....X.",
                "...XX.",
                "......"
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "......",
                ".XX...",
                ".XX...",
                "...XX.",
                "...XX.",
                "......"
            });
        }

        [Test]
        public void TestScenario4_Pulsar()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                ".................",
                ".................",
                "....XXX...XXX....",
                ".................",
                "..X....X.X....X..",
                "..X....X.X....X..",
                "..X....X.X....X..",
                "....XXX...XXX....",
                ".................",
                "....XXX...XXX....",
                "..X....X.X....X..",
                "..X....X.X....X..",
                "..X....X.X....X..",
                ".................",
                "....XXX...XXX....",
                ".................",
                "................."
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                ".................",
                ".....X.....X.....",
                ".....X.....X.....",
                ".....XX...XX.....",
                ".................",
                ".XXX..XX.XX..XXX.",
                "...X.X.X.X.X.X...",
                ".....XX...XX.....",
                ".................",
                ".....XX...XX.....",
                "...X.X.X.X.X.X...",
                ".XXX..XX.XX..XXX.",
                ".................",
                ".....X.....X.....",
                ".....X.....X.....",
                ".....XX...XX.....",
                "................."
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                ".................",
                ".................",
                "....XX.....XX....",
                ".....XX...XX.....",
                "..X..X.X.X.X..X..",
                "..XXX.XX.XX.XXX..",
                "...X.X.X.X.X.X...",
                "....XXX...XXX....",
                ".................",
                "....XXX...XXX....",
                "...X.X.X.X.X.X...",
                "..XXX.XX.XX.XXX..",
                "..X..X.X.X.X..X..",
                ".....XX...XX.....",
                "....XX.....XX....",
                ".................",
                ".................",
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                ".................",
                ".................",
                "....XXX...XXX....",
                ".................",
                "..X....X.X....X..",
                "..X....X.X....X..",
                "..X....X.X....X..",
                "....XXX...XXX....",
                ".................",
                "....XXX...XXX....",
                "..X....X.X....X..",
                "..X....X.X....X..",
                "..X....X.X....X..",
                ".................",
                "....XXX...XXX....",
                ".................",
                ".................",
            });
        }

        [Test]
        public void TestScenario4_Spaceship()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                "X.....",
                ".XX...",
                "XX....",
                "......",
                "......",
                "......"
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                ".X....",
                "..X...",
                "XXX...",
                "......",
                "......",
                "......"
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "......",
                "X.X...",
                ".XX...",
                ".X....",
                "......",
                "......"
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "......",
                "X.X...",
                ".XX...",
                "..X...",
                "......",
                "......"
            });

            fixture.WhenIApplyIterations(1);
            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                "......",
                ".X....",
                "..XX..",
                ".XX...",
                "......",
                "......"
            });
        }
    }
}
