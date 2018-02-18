using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace GameOfLifeKata___BDD
{
    [TestClass]
    [Story(
        AsA ="maths geek",
        IWant = "to be able to apply the over population rule",
        SoThat ="I can see my entered patterns evolve")]
    public class Story05OverPopulation
    {
        public void GivenAnInitialStateForCells()
        {
            throw new NotImplementedException();
        }

        public void WhenIApplyTheOverPopulationRule()
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeThatCellsWithMoreThanThreeNeighboursDie()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Story05CanApplyOverPopulationRule()
        {
            this.BDDfy();
        }
    }
}
