using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace GameOfLifeKata___BDD
{
    [TestClass]
    [Story(
        AsA ="maths geek",
        IWant = "to be able to apply the procreation rule",
        SoThat ="I can see my entered patterns evolve")]
    public class Story06Procreation
    {
        public void GivenAnInitialStateForCells()
        {
            throw new NotImplementedException();
        }

        public void WhenIApplyTheProcreationRule()
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeThatDeadCellsWithExactlyThreeNeighboursSpawn()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Story06CanApplyProcreationRule()
        {
            this.BDDfy();
        }
    }
}
