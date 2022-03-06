using GameOfLife.AcceptanceTests.Fixture;
using NUnit.Framework;

namespace GameOfLife.AcceptanceTests
{
    public class GOL_2_SettingTheInitialState
    {
        // ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
        // ┃ GOL-2 Settings the Initial State                                   ┃
        // ┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫
        // ┃ As a tech-geek                                                     ┃
        // ┃ I want to be able to set the initial state of the grid's cells     ┃
        // ┃ So that I can see the evolution of different starting patterns     ┃
        // ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛

        [Test]
        public void TestScenario1()
        {
            var fixture = new TestFixture();
            fixture.GivenInitialState(new string[]
            {
                ".....",
                "..X..",
                "...X.",
                ".XXX.",
                "....."
            });

            fixture.WhenIDisplayTheGrid();

            fixture.ThenOutputShouldBe(new string[]
            {
                ".....",
                "..X..",
                "...X.",
                ".XXX.",
                "....."
            });
        }
    }
}
