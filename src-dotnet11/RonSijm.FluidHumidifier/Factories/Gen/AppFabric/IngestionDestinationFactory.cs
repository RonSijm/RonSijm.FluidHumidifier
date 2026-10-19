// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class IngestionDestinationFactory(string resourceName = null, Action<Humidifier.AppFabric.IngestionDestination> factoryAction = null) : ResourceFactory<Humidifier.AppFabric.IngestionDestination>(resourceName)
{

    internal InnerIngestionDestinationDestinationConfigurationFactory DestinationConfigurationFactory { get; set; }

    internal InnerIngestionDestinationProcessingConfigurationFactory ProcessingConfigurationFactory { get; set; }

    protected override Humidifier.AppFabric.IngestionDestination Create()
    {
        var ingestionDestinationResult = CreateIngestionDestination();
        factoryAction?.Invoke(ingestionDestinationResult);

        return ingestionDestinationResult;
    }

    private Humidifier.AppFabric.IngestionDestination CreateIngestionDestination()
    {
        var ingestionDestinationResult = new Humidifier.AppFabric.IngestionDestination
        {
            GivenName = InputResourceName,
        };

        return ingestionDestinationResult;
    }
    public override void CreateChildren(Humidifier.AppFabric.IngestionDestination result)
    {
        base.CreateChildren(result);

        result.DestinationConfiguration ??= DestinationConfigurationFactory?.Build();
        result.ProcessingConfiguration ??= ProcessingConfigurationFactory?.Build();
    }

} // End Of Class

public static class IngestionDestinationFactoryExtensions
{
    public static CombinedResult<IngestionDestinationFactory, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration(this IngestionDestinationFactory parentFactory, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null)
    {
        parentFactory.DestinationConfigurationFactory = new InnerIngestionDestinationDestinationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationConfigurationFactory);
    }

    public static CombinedResult<IngestionDestinationFactory, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration(this IngestionDestinationFactory parentFactory, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null)
    {
        parentFactory.ProcessingConfigurationFactory = new InnerIngestionDestinationProcessingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProcessingConfigurationFactory);
    }

    public static CombinedResult<IngestionDestinationFactory, T1, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1>(this CombinedResult<IngestionDestinationFactory, T1> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IngestionDestinationFactory, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1>(this CombinedResult<T1, IngestionDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IngestionDestinationFactory, T1, T2, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<IngestionDestinationFactory, T1, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IngestionDestinationFactory, T2, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<T1, IngestionDestinationFactory, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IngestionDestinationFactory, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<T1, T2, IngestionDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IngestionDestinationFactory, T1, T2, T3, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<IngestionDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IngestionDestinationFactory, T2, T3, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, IngestionDestinationFactory, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IngestionDestinationFactory, T3, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, IngestionDestinationFactory, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IngestionDestinationFactory, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, IngestionDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IngestionDestinationFactory, T1, T2, T3, T4, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<IngestionDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IngestionDestinationFactory, T2, T3, T4, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, IngestionDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IngestionDestinationFactory, T3, T4, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, IngestionDestinationFactory, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IngestionDestinationFactory, T4, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IngestionDestinationFactory, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IngestionDestinationFactory, InnerIngestionDestinationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IngestionDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<IngestionDestinationFactory, T1, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1>(this CombinedResult<IngestionDestinationFactory, T1> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IngestionDestinationFactory, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1>(this CombinedResult<T1, IngestionDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IngestionDestinationFactory, T1, T2, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1, T2>(this CombinedResult<IngestionDestinationFactory, T1, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IngestionDestinationFactory, T2, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1, T2>(this CombinedResult<T1, IngestionDestinationFactory, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IngestionDestinationFactory, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1, T2>(this CombinedResult<T1, T2, IngestionDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IngestionDestinationFactory, T1, T2, T3, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1, T2, T3>(this CombinedResult<IngestionDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IngestionDestinationFactory, T2, T3, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1, T2, T3>(this CombinedResult<T1, IngestionDestinationFactory, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IngestionDestinationFactory, T3, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, IngestionDestinationFactory, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IngestionDestinationFactory, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, IngestionDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IngestionDestinationFactory, T1, T2, T3, T4, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1, T2, T3, T4>(this CombinedResult<IngestionDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IngestionDestinationFactory, T2, T3, T4, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, IngestionDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IngestionDestinationFactory, T3, T4, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, IngestionDestinationFactory, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IngestionDestinationFactory, T4, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IngestionDestinationFactory, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IngestionDestinationFactory, InnerIngestionDestinationProcessingConfigurationFactory> WithProcessingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IngestionDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProcessingConfiguration(combinedResult.T5, subFactoryAction).T2);
}
