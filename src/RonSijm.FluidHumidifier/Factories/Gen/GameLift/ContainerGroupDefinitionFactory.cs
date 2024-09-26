// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class ContainerGroupDefinitionFactory(string resourceName = null, Action<Humidifier.GameLift.ContainerGroupDefinition> factoryAction = null) : ResourceFactory<Humidifier.GameLift.ContainerGroupDefinition>(resourceName)
{

    internal List<InnerContainerGroupDefinitionContainerDefinitionFactory> ContainerDefinitionsFactories { get; set; } = [];

    protected override Humidifier.GameLift.ContainerGroupDefinition Create()
    {
        var containerGroupDefinitionResult = CreateContainerGroupDefinition();
        factoryAction?.Invoke(containerGroupDefinitionResult);

        return containerGroupDefinitionResult;
    }

    private Humidifier.GameLift.ContainerGroupDefinition CreateContainerGroupDefinition()
    {
        var containerGroupDefinitionResult = new Humidifier.GameLift.ContainerGroupDefinition
        {
            GivenName = InputResourceName,
        };

        return containerGroupDefinitionResult;
    }
    public override void CreateChildren(Humidifier.GameLift.ContainerGroupDefinition result)
    {
        base.CreateChildren(result);

        result.ContainerDefinitions = ContainerDefinitionsFactories.Any() ? ContainerDefinitionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ContainerGroupDefinitionFactoryExtensions
{
    public static CombinedResult<ContainerGroupDefinitionFactory, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions(this ContainerGroupDefinitionFactory parentFactory, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null)
    {
        var factory = new InnerContainerGroupDefinitionContainerDefinitionFactory(subFactoryAction);
        parentFactory.ContainerDefinitionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ContainerGroupDefinitionFactory, T1, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1>(this CombinedResult<ContainerGroupDefinitionFactory, T1> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerGroupDefinitionFactory, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1>(this CombinedResult<T1, ContainerGroupDefinitionFactory> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ContainerGroupDefinitionFactory, T1, T2, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1, T2>(this CombinedResult<ContainerGroupDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerGroupDefinitionFactory, T2, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1, T2>(this CombinedResult<T1, ContainerGroupDefinitionFactory, T2> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerGroupDefinitionFactory, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1, T2>(this CombinedResult<T1, T2, ContainerGroupDefinitionFactory> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ContainerGroupDefinitionFactory, T1, T2, T3, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3>(this CombinedResult<ContainerGroupDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerGroupDefinitionFactory, T2, T3, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3>(this CombinedResult<T1, ContainerGroupDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerGroupDefinitionFactory, T3, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3>(this CombinedResult<T1, T2, ContainerGroupDefinitionFactory, T3> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContainerGroupDefinitionFactory, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContainerGroupDefinitionFactory> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ContainerGroupDefinitionFactory, T1, T2, T3, T4, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3, T4>(this CombinedResult<ContainerGroupDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerGroupDefinitionFactory, T2, T3, T4, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, ContainerGroupDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerGroupDefinitionFactory, T3, T4, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContainerGroupDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContainerGroupDefinitionFactory, T4, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContainerGroupDefinitionFactory, T4> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ContainerGroupDefinitionFactory, InnerContainerGroupDefinitionContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContainerGroupDefinitionFactory> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T5, subFactoryAction));
}
