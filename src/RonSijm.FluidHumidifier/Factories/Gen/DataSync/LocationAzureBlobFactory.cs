// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationAzureBlobFactory(string resourceName = null, Action<Humidifier.DataSync.LocationAzureBlob> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationAzureBlob>(resourceName)
{

    internal InnerLocationAzureBlobAzureBlobSasConfigurationFactory AzureBlobSasConfigurationFactory { get; set; }

    protected override Humidifier.DataSync.LocationAzureBlob Create()
    {
        var locationAzureBlobResult = CreateLocationAzureBlob();
        factoryAction?.Invoke(locationAzureBlobResult);

        return locationAzureBlobResult;
    }

    private Humidifier.DataSync.LocationAzureBlob CreateLocationAzureBlob()
    {
        var locationAzureBlobResult = new Humidifier.DataSync.LocationAzureBlob
        {
            GivenName = InputResourceName,
        };

        return locationAzureBlobResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationAzureBlob result)
    {
        base.CreateChildren(result);

        result.AzureBlobSasConfiguration ??= AzureBlobSasConfigurationFactory?.Build();
    }

} // End Of Class

public static class LocationAzureBlobFactoryExtensions
{
    public static CombinedResult<LocationAzureBlobFactory, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration(this LocationAzureBlobFactory parentFactory, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null)
    {
        parentFactory.AzureBlobSasConfigurationFactory = new InnerLocationAzureBlobAzureBlobSasConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AzureBlobSasConfigurationFactory);
    }

    public static CombinedResult<LocationAzureBlobFactory, T1, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1>(this CombinedResult<LocationAzureBlobFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationAzureBlobFactory, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1>(this CombinedResult<T1, LocationAzureBlobFactory> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LocationAzureBlobFactory, T1, T2, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1, T2>(this CombinedResult<LocationAzureBlobFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationAzureBlobFactory, T2, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1, T2>(this CombinedResult<T1, LocationAzureBlobFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationAzureBlobFactory, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1, T2>(this CombinedResult<T1, T2, LocationAzureBlobFactory> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LocationAzureBlobFactory, T1, T2, T3, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1, T2, T3>(this CombinedResult<LocationAzureBlobFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationAzureBlobFactory, T2, T3, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1, T2, T3>(this CombinedResult<T1, LocationAzureBlobFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationAzureBlobFactory, T3, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, LocationAzureBlobFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationAzureBlobFactory, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationAzureBlobFactory> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LocationAzureBlobFactory, T1, T2, T3, T4, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1, T2, T3, T4>(this CombinedResult<LocationAzureBlobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationAzureBlobFactory, T2, T3, T4, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, LocationAzureBlobFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationAzureBlobFactory, T3, T4, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationAzureBlobFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationAzureBlobFactory, T4, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationAzureBlobFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LocationAzureBlobFactory, InnerLocationAzureBlobAzureBlobSasConfigurationFactory> WithAzureBlobSasConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationAzureBlobFactory> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureBlobSasConfiguration(combinedResult.T5, subFactoryAction));
}
