using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace GameOfLifeKata___BDD
{
    [TestClass]
    [Story(
        AsA ="maths geek",
        IWant = "to be able to interate to the next generation",
        SoThat ="I can see my entered patterns evolve")]
    public class Story07Iteration
    {
        public void GivenAnInitialStateForCells()
        {
            throw new NotImplementedException();
        }

        public void WhenIApplyAllTheGameOfLifeRules()
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeThatTheGridShowsTheNextGeneration()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Story07CanIterateToTheNextGeneration()
        {
            this.BDDfy();
        }
    }
}
