using Autofac;

namespace GameOfLife
{
    public class GameOfLifeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Grid>().As<IGrid>().InstancePerLifetimeScope();
            builder.RegisterType<ConsoleOutput>().As<IOutput>().InstancePerLifetimeScope();
            builder.RegisterType<GameOfLifeRunner>().InstancePerLifetimeScope();
        }
    }
}
