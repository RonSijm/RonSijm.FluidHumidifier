// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTTwinMaker;

public class MetadataTransferJobFactory(string resourceName = null, Action<Humidifier.IoTTwinMaker.MetadataTransferJob> factoryAction = null) : ResourceFactory<Humidifier.IoTTwinMaker.MetadataTransferJob>(resourceName)
{

    internal List<InnerMetadataTransferJobSourceConfigurationFactory> SourcesFactories { get; set; } = [];

    internal InnerMetadataTransferJobDestinationConfigurationFactory DestinationFactory { get; set; }

    protected override Humidifier.IoTTwinMaker.MetadataTransferJob Create()
    {
        var metadataTransferJobResult = CreateMetadataTransferJob();
        factoryAction?.Invoke(metadataTransferJobResult);

        return metadataTransferJobResult;
    }

    private Humidifier.IoTTwinMaker.MetadataTransferJob CreateMetadataTransferJob()
    {
        var metadataTransferJobResult = new Humidifier.IoTTwinMaker.MetadataTransferJob
        {
            GivenName = InputResourceName,
        };

        return metadataTransferJobResult;
    }
    public override void CreateChildren(Humidifier.IoTTwinMaker.MetadataTransferJob result)
    {
        base.CreateChildren(result);

        result.Sources = SourcesFactories.Any() ? SourcesFactories.Select(x => x.Build()).ToList() : null;
        result.Destination ??= DestinationFactory?.Build();
    }

} // End Of Class

public static class MetadataTransferJobFactoryExtensions
{
    public static CombinedResult<MetadataTransferJobFactory, InnerMetadataTransferJobSourceConfigurationFactory> WithSources(this MetadataTransferJobFactory parentFactory, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null)
    {
        var factory = new InnerMetadataTransferJobSourceConfigurationFactory(subFactoryAction);
        parentFactory.SourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MetadataTransferJobFactory, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination(this MetadataTransferJobFactory parentFactory, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null)
    {
        parentFactory.DestinationFactory = new InnerMetadataTransferJobDestinationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationFactory);
    }

    public static CombinedResult<MetadataTransferJobFactory, T1, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1>(this CombinedResult<MetadataTransferJobFactory, T1> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetadataTransferJobFactory, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1>(this CombinedResult<T1, MetadataTransferJobFactory> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MetadataTransferJobFactory, T1, T2, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1, T2>(this CombinedResult<MetadataTransferJobFactory, T1, T2> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetadataTransferJobFactory, T2, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1, T2>(this CombinedResult<T1, MetadataTransferJobFactory, T2> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetadataTransferJobFactory, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1, T2>(this CombinedResult<T1, T2, MetadataTransferJobFactory> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MetadataTransferJobFactory, T1, T2, T3, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1, T2, T3>(this CombinedResult<MetadataTransferJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetadataTransferJobFactory, T2, T3, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, MetadataTransferJobFactory, T2, T3> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetadataTransferJobFactory, T3, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, MetadataTransferJobFactory, T3> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MetadataTransferJobFactory, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, T3, MetadataTransferJobFactory> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MetadataTransferJobFactory, T1, T2, T3, T4, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<MetadataTransferJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetadataTransferJobFactory, T2, T3, T4, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, MetadataTransferJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetadataTransferJobFactory, T3, T4, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, MetadataTransferJobFactory, T3, T4> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MetadataTransferJobFactory, T4, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MetadataTransferJobFactory, T4> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MetadataTransferJobFactory, InnerMetadataTransferJobSourceConfigurationFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MetadataTransferJobFactory> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<MetadataTransferJobFactory, T1, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1>(this CombinedResult<MetadataTransferJobFactory, T1> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetadataTransferJobFactory, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1>(this CombinedResult<T1, MetadataTransferJobFactory> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MetadataTransferJobFactory, T1, T2, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1, T2>(this CombinedResult<MetadataTransferJobFactory, T1, T2> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetadataTransferJobFactory, T2, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1, T2>(this CombinedResult<T1, MetadataTransferJobFactory, T2> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetadataTransferJobFactory, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1, T2>(this CombinedResult<T1, T2, MetadataTransferJobFactory> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MetadataTransferJobFactory, T1, T2, T3, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1, T2, T3>(this CombinedResult<MetadataTransferJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetadataTransferJobFactory, T2, T3, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, MetadataTransferJobFactory, T2, T3> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetadataTransferJobFactory, T3, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, MetadataTransferJobFactory, T3> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MetadataTransferJobFactory, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, MetadataTransferJobFactory> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MetadataTransferJobFactory, T1, T2, T3, T4, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<MetadataTransferJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetadataTransferJobFactory, T2, T3, T4, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, MetadataTransferJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetadataTransferJobFactory, T3, T4, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, MetadataTransferJobFactory, T3, T4> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MetadataTransferJobFactory, T4, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MetadataTransferJobFactory, T4> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MetadataTransferJobFactory, InnerMetadataTransferJobDestinationConfigurationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MetadataTransferJobFactory> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T5, subFactoryAction).T2);
}
