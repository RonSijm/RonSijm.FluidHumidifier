// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerGroupDefinitionGameServerContainerDefinitionFactory(Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.GameServerContainerDefinition> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerGroupDefinitionTypes.GameServerContainerDefinition>
{

    internal InnerContainerGroupDefinitionPortConfigurationFactory PortConfigurationFactory { get; set; }

    protected override Humidifier.GameLift.ContainerGroupDefinitionTypes.GameServerContainerDefinition Create()
    {
        var gameServerContainerDefinitionResult = CreateGameServerContainerDefinition();
        factoryAction?.Invoke(gameServerContainerDefinitionResult);

        return gameServerContainerDefinitionResult;
    }

    private Humidifier.GameLift.ContainerGroupDefinitionTypes.GameServerContainerDefinition CreateGameServerContainerDefinition()
    {
        var gameServerContainerDefinitionResult = new Humidifier.GameLift.ContainerGroupDefinitionTypes.GameServerContainerDefinition();

        return gameServerContainerDefinitionResult;
    }
    public override void CreateChildren(Humidifier.GameLift.ContainerGroupDefinitionTypes.GameServerContainerDefinition result)
    {
        base.CreateChildren(result);

        result.PortConfiguration ??= PortConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerContainerGroupDefinitionGameServerContainerDefinitionFactoryExtensions
{
    public static CombinedResult<InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration(this InnerContainerGroupDefinitionGameServerContainerDefinitionFactory parentFactory, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null)
    {
        parentFactory.PortConfigurationFactory = new InnerContainerGroupDefinitionPortConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PortConfigurationFactory);
    }

    public static CombinedResult<InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T1, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1>(this CombinedResult<InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T1> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1>(this CombinedResult<T1, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T1, T2, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1, T2>(this CombinedResult<InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T2, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1, T2>(this CombinedResult<T1, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T2> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T1, T2, T3, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1, T2, T3>(this CombinedResult<InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T2, T3, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T3, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T3> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T1, T2, T3, T4, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T2, T3, T4, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T3, T4, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T4, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, T4> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory, InnerContainerGroupDefinitionPortConfigurationFactory> WithPortConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerContainerGroupDefinitionGameServerContainerDefinitionFactory> combinedResult, Action<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortConfiguration(combinedResult.T5, subFactoryAction));
}
