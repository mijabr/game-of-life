using GameOfLife.AcceptanceTests.Fixture;
using NUnit.Framework;

namespace GameOfLife.AcceptanceTests
{
    public class GOL_1_CreatingTheGrid
    {
        // ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
        // ┃ GOL-1 Creating the Grid                                            ┃
        // ┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫
        // ┃ As a tech-geek                                                     ┃
        // ┃ I want to see a Conway's Game of Life grid                         ┃
        // ┃ So that I can see the evolving life patterns                       ┃
        // ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛

        [Test]
        public void TestScenario1()
        {
            var fixture = new TestFixture();
            fixture.GivenICreateAGridOfSize(5, 5);

            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                ".....",
                ".....",
                ".....",
                ".....",
                "....."
            });
        }
    }
}
