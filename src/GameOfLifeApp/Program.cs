using Autofac;
using GameOfLife;

string[] initialState = new string[]
{
    ".............",
    "..X..........",
    "...X.........",
    ".XXX.........",
    ".............",
    ".............",
    ".............",
    ".............",
    ".............",
    ".............",
    ".............",
    "..........XX.",
    ".........X..X",
    "..........XX."
};

var builder = new ContainerBuilder();
builder.RegisterModule<GameOfLifeModule>();
var container = builder.Build();
var gameOfLife = container.Resolve<GameOfLifeRunner>();

gameOfLife.SetCells(initialState);
gameOfLife.Display();

while (true)
{
    Thread.Sleep(200);
    gameOfLife.ApplyIteration();
    gameOfLife.Display();
}
