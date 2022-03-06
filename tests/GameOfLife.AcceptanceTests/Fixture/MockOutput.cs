using FluentAssertions;
using Moq;
using System.Collections.Generic;

namespace GameOfLife.AcceptanceTests.Fixture
{
    public class MockOutput : Mock<IOutput>
    {
        private List<string> _output = new();

        public MockOutput()
        {
            Setup(c => c.WriteLine(It.IsAny<string>())).Callback((string s) => _output.Add(s));

            Setup(c => c.Clear()).Callback(() => _output.Clear());
        }

        public void VerifyOutput(string[] lines)
        {
            _output.Should().BeEquivalentTo(lines);
        }
    }
}
