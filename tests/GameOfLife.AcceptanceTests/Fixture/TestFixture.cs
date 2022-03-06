using Autofac;

namespace GameOfLife.AcceptanceTests.Fixture
{
    public class TestFixture
    {
        private GameOfLifeRunner _gameOfLife { get; }

        private MockOutput _output { get; } = new();

        public TestFixture()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<GameOfLifeModule>();
            builder.RegisterInstance(_output.Object).As<IOutput>();
            _gameOfLife = builder.Build().Resolve<GameOfLifeRunner>();
        }

        public void GivenICreateAGridOfSize(int sizeX, int sizeY)
        {
            _gameOfLife.SetSize(5, 5);
        }

        public void GivenInitialState(string[] rows)
        {
            _gameOfLife.SetCells(rows);
        }

        internal void WhenIApplyIterations(int interationCount)
        {
            for (int n = 0; n < interationCount; n++)
            {
                _gameOfLife.ApplyIteration();
            }
        }

        public void WhenIDisplayTheGrid()
        {
            _gameOfLife.Display();
        }

        public void ThenOutputShouldBe(string[] rows)
        {
            _output.VerifyOutput(rows);
        }
    }
}
