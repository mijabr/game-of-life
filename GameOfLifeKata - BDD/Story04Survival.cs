using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace GameOfLifeKata___BDD
{
    [TestClass]
    [Story(
        AsA ="maths geek",
        IWant = "to be able to apply the survival rule",
        SoThat ="I can see my entered patterns evolve")]
    public class Story04Survival
    {
        public void GivenAnInitialStateForCells()
        {
            throw new NotImplementedException();
        }

        public void WhenIApplyTheSurvivalRule()
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeThatCellsWithAtLeastThreeNeighboursSurvive()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Story04CanApplySurvivalRule()
        {
            this.BDDfy();
        }
    }
}
