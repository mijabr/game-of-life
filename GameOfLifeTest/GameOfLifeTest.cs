using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;
using NSubstitute;
using Shouldly;

namespace GameOfLifeTest
{
    [TestClass]
    public class GameOfLifeTest
    {
        IConsole console = NSubstitute.Substitute.For<IConsole>();
        [TestMethod]
        public void CanDisplayCells()
        {
            GameOfLifeGrid grid = new GameOfLifeGrid(console, 10, 10);
            grid.Display();
            console.Received(10).WriteLine(Arg.Is(".........."));
        }

        [TestMethod]
        public void CanInitialiseCells()
        {
            char[,] initialState = new char[,]
            {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', 'X', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', 'X', 'X', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            var grid = new GameOfLifeGrid(console, 10, 10);
            grid.Initalise(initialState);
            grid.Display();
            console.Received(7).WriteLine(Arg.Is(".........."));
            console.Received().WriteLine(Arg.Is("..X......."));
            console.Received().WriteLine(Arg.Is("...X......"));
            console.Received().WriteLine(Arg.Is(".XXX......"));

        }

        [TestMethod]
        public void CanCountLiveNeighbours()
        {
            char[,] initialState = new char[,]
            {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', 'X', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', 'X', 'X', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };
            var grid = new GameOfLifeGrid(console, 10, 10);
            grid.Initalise(initialState);
            grid.LiveNeighbourCount(2, 3, initialState).ShouldBe(3);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            char[,] initialState = new char[,]
            {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', 'X', '.', '.', '.', '.', '.', 'X', '.' },
                { '.', '.', '.', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', 'X', 'X', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', '.', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', '.', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            var grid = new GameOfLifeGrid(console, 10, 10);
            grid.Initalise(initialState);
            grid.ApplyUnderPopulation((char[,])initialState.Clone());
            grid.Display();
            Received.InOrder(
                () =>
                {
                    console.WriteLine("..........");
                    console.WriteLine("..........");
                    console.WriteLine("...X......");
                    console.WriteLine("..XX......");
                    console.WriteLine("..........");
                    console.WriteLine(".......XXX");
                    console.WriteLine(".......XXX");
                    console.WriteLine(".......XXX");
                    console.WriteLine("..........");
                    console.WriteLine("..........");
                }
                );
        }

        [TestMethod]
        public void MyTest3Neighbours()
        {
            char[,] initialState = new char[,]
            {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', 'X', '.', '.', '.', '.', '.', 'X', '.' },
                { '.', '.', '.', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', 'X', 'X', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            var grid = new GameOfLifeGrid(console, 10, 10);
            grid.Initalise(initialState);
            grid.ApplySurvivalRule((char[,])initialState.Clone());
            grid.Display();
            Received.InOrder(
                () =>
                {
                    console.WriteLine("..........");
                    console.WriteLine("..........");
                    console.WriteLine("...X......");
                    console.WriteLine("..X.......");
                    console.WriteLine("..........");
                    console.WriteLine("......XXXX");
                    console.WriteLine("......XXXX");
                    console.WriteLine("......XXXX");
                    console.WriteLine("......XXXX");
                    console.WriteLine("..........");
                }
                );
        }

        [TestMethod]
        public void MyTestMoreThan3Neighbours()
        {
            char[,] initialState = new char[,]
                       {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', 'X', '.', '.', '.', '.', '.', 'X', '.' },
                { '.', '.', '.', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', 'X', 'X', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' }
                       };

            var grid = new GameOfLifeGrid(console, 10, 10);
            grid.Initalise(initialState);
            grid.ApplyOverPopulationRule((char[,])initialState.Clone());
            grid.Display();
            Received.InOrder(
                () =>
                {
                    console.WriteLine("..........");
                    console.WriteLine("..X.....X.");
                    console.WriteLine("...X......");
                    console.WriteLine(".XXX......");
                    console.WriteLine("..........");
                    console.WriteLine(".....X...X");
                    console.WriteLine("..........");
                    console.WriteLine("..........");
                    console.WriteLine("......X..X");
                    console.WriteLine("..........");
                }
                );
        }

        [TestMethod]
        public void ProcreationRule()
        {
            char[,] initialState = new char[,]
                       {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', 'X', '.', '.', '.', '.', '.', 'X', '.' },
                { '.', '.', '.', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', 'X', 'X', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' }
                       };

            var grid = new GameOfLifeGrid(console, 10, 10);
            grid.Initalise(initialState);
            grid.ApplyProcreationRule((char[,])initialState.Clone());
            grid.Display();
            Received.InOrder(
                () =>
                {
                    console.WriteLine("..........");
                    console.WriteLine("..X.....X.");
                    console.WriteLine(".X.X......");
                    console.WriteLine(".XXX......");
                    console.WriteLine("..X...XXX.");
                    console.WriteLine(".....XXXXX");
                    console.WriteLine(".....XXXXX");
                    console.WriteLine("......XXXX");
                    console.WriteLine("......XXXX");
                    console.WriteLine(".......XX.");
                }
                );
        }

        [TestMethod]
        public void TestingTheNextGeneration()
        {
            char[,] initialState = new char[,]
                       {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', 'X', '.', '.', '.', '.', '.', 'X', '.' },
                { '.', '.', '.', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', 'X', 'X', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { '.', 'X', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { 'X', 'X', '.', '.', '.', '.', '.', '.', '.', '.' }
                       };

            var grid = new GameOfLifeGrid(console, 10, 10);
            grid.Initalise(initialState);
            grid.ApplyAllRules();
            grid.Display();
            Received.InOrder(
                () =>
                {
                    console.WriteLine("..........");
                    console.WriteLine("..........");
                    console.WriteLine(".X.X......");
                    console.WriteLine("..XX......");
                    console.WriteLine("..X...XXX.");
                    console.WriteLine(".....X...X");
                    console.WriteLine("..........");
                    console.WriteLine("..........");
                    console.WriteLine("XX....X..X");
                    console.WriteLine("XX.....XX.");
                }
                );
        }

        [TestMethod]
        public void TestingManyGenerations()
        {
            char[,] initialState = new char[,]
                       {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', 'X', '.', '.', '.', '.', '.', 'X', '.' },
                { '.', '.', '.', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', 'X', 'X', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { '.', 'X', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { 'X', 'X', '.', '.', '.', '.', '.', '.', '.', '.' }
                       };


            /*
                             {
                    console.WriteLine("..........");
                    console.WriteLine("..........");
                    console.WriteLine(".X.X......");
                    console.WriteLine("..XX......");
                    console.WriteLine("..X...XXX.");
                    console.WriteLine(".....X...X");
                    console.WriteLine("..........");
                    console.WriteLine("..........");
                    console.WriteLine("XX....X..X");
                    console.WriteLine("XX.....XX.");
                }

             */
            var grid = new GameOfLifeGrid(console, 10, 10);
            grid.Initalise(initialState);
            grid.ApplyAllRules();
            grid.ApplyAllRules();
            grid.Display();
            Received.InOrder(
                () =>
                {
                    console.WriteLine("..........");
                    console.WriteLine("..........");
                    console.WriteLine("...X......");
                    console.WriteLine(".X.X...X..");
                    console.WriteLine("..XX..XXX.");
                    console.WriteLine("......XXX.");
                    console.WriteLine("..........");
                    console.WriteLine("..........");
                    console.WriteLine("XX.....XX.");
                    console.WriteLine("XX.....XX.");
                }
                );
        }
    }
}
