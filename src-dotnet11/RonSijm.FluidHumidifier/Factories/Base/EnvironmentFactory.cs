using RonSijm.FluidHumidifier.Features.Consumer;

namespace RonSijm.FluidHumidifier.Factories.Base;

public class EnvironmentFactory(EnvironmentConfig config) : RootFactory<IEnumerable<Stack>>
{
    public List<StackFactory> StackFactories { get; } = [];

    public StackFactory AddStack(string description)
    {
        var factory = this.CreateSubFactory(() => new StackFactory(description));
        Decorator.Variables["StackName"] = description;
        StackFactories.Add(factory);
        return factory;
    }

    protected override IEnumerable<Stack> Create()
    {
        return StackFactories.Select(stackFactory =>
        {
            stackFactory.Decorator.Variables["EnvironmentName"] = config.EnvironmentName;
            stackFactory.Decorator.Variables["AwsAccountId"] = config.AWSAccountId;
            stackFactory.Decorator.Variables["AWSRegion"] = config.Region;
            return stackFactory.Build();
        });
    }
}