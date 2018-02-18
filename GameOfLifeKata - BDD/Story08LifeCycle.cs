using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace GameOfLifeKata___BDD
{
    [TestClass]
    [Story(
        AsA ="maths geek",
        IWant = "to be able to cycle through many generations",
        SoThat ="I can see my entered patterns evolve")]
    public class Story08LifeCycle
    {
        public void GivenAnInitialStateForCells()
        {
            throw new NotImplementedException();
        }

        public void WhenICycleThroughManyGenerations()
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeThatTheGridCyclesThroughGenerations()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Story08CanCycleThroughManyGenerations()
        {
            this.BDDfy();
        }
    }
}
