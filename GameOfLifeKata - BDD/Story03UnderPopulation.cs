using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace GameOfLifeKata___BDD
{
    [TestClass]
    [Story(
        AsA ="maths geek",
        IWant = "to be able to apply the under population rule",
        SoThat ="I can see my entered patterns evolve")]
    public class Story03UnderPopulation
    {
        public void GivenAnInitialStateForCells()
        {
            throw new NotImplementedException();
        }

        public void WhenIApplyTheUnderPopulationRule()
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeThatCellsWithLessThanTwoNeighboursDie()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Story03CanApplyUnderPopulationRule()
        {
            this.BDDfy();
        }
    }
}
