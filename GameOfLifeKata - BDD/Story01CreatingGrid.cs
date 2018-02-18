using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace GameOfLifeKata___BDD
{
    [TestClass]
    [Story(
        AsA ="maths geek",
        IWant = "to see a Conway's Game of Life grid",
        SoThat ="I can see the evolving life patterns")]
    public class Story01CreatingGrid
    {
        public void GivenDimensions()
        {
            throw new NotImplementedException();
        }

        public void WhenIStartTheGameOfLife()
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeAGridOfCells()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Story01CanSeeAGameOfLifeGrid()
        {
            this.BDDfy();
        }
    }
}
