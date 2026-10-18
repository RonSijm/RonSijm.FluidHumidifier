// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTTwinMaker;

public class InnerMetadataTransferJobDestinationConfigurationFactory(Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration>
{

    internal InnerMetadataTransferJobS3DestinationConfigurationFactory S3ConfigurationFactory { get; set; }

    protected override Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration Create()
    {
        var destinationConfigurationResult = CreateDestinationConfiguration();
        factoryAction?.Invoke(destinationConfigurationResult);

        return destinationConfigurationResult;
    }

    private Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration CreateDestinationConfiguration()
    {
        var destinationConfigurationResult = new Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration();

        return destinationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration result)
    {
        base.CreateChildren(result);

        result.S3Configuration ??= S3ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMetadataTransferJobDestinationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMetadataTransferJobDestinationConfigurationFactory, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration(this InnerMetadataTransferJobDestinationConfigurationFactory parentFactory, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null)
    {
        parentFactory.S3ConfigurationFactory = new InnerMetadataTransferJobS3DestinationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ConfigurationFactory);
    }

    public static CombinedResult<InnerMetadataTransferJobDestinationConfigurationFactory, T1, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1>(this CombinedResult<InnerMetadataTransferJobDestinationConfigurationFactory, T1> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMetadataTransferJobDestinationConfigurationFactory, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1>(this CombinedResult<T1, InnerMetadataTransferJobDestinationConfigurationFactory> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMetadataTransferJobDestinationConfigurationFactory, T1, T2, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<InnerMetadataTransferJobDestinationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMetadataTransferJobDestinationConfigurationFactory, T2, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<T1, InnerMetadataTransferJobDestinationConfigurationFactory, T2> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMetadataTransferJobDestinationConfigurationFactory, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<T1, T2, InnerMetadataTransferJobDestinationConfigurationFactory> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMetadataTransferJobDestinationConfigurationFactory, T1, T2, T3, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<InnerMetadataTransferJobDestinationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMetadataTransferJobDestinationConfigurationFactory, T2, T3, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, InnerMetadataTransferJobDestinationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMetadataTransferJobDestinationConfigurationFactory, T3, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMetadataTransferJobDestinationConfigurationFactory, T3> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMetadataTransferJobDestinationConfigurationFactory, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMetadataTransferJobDestinationConfigurationFactory> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMetadataTransferJobDestinationConfigurationFactory, T1, T2, T3, T4, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<InnerMetadataTransferJobDestinationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMetadataTransferJobDestinationConfigurationFactory, T2, T3, T4, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMetadataTransferJobDestinationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMetadataTransferJobDestinationConfigurationFactory, T3, T4, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMetadataTransferJobDestinationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMetadataTransferJobDestinationConfigurationFactory, T4, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMetadataTransferJobDestinationConfigurationFactory, T4> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMetadataTransferJobDestinationConfigurationFactory, InnerMetadataTransferJobS3DestinationConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMetadataTransferJobDestinationConfigurationFactory> combinedResult, Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T5, subFactoryAction).T2);
}
