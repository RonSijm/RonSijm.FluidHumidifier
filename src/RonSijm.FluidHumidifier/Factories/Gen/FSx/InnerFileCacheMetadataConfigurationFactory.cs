// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileCacheMetadataConfigurationFactory(Action<Humidifier.FSx.FileCacheTypes.MetadataConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileCacheTypes.MetadataConfiguration>
{

    protected override Humidifier.FSx.FileCacheTypes.MetadataConfiguration Create()
    {
        var metadataConfigurationResult = CreateMetadataConfiguration();
        factoryAction?.Invoke(metadataConfigurationResult);

        return metadataConfigurationResult;
    }

    private Humidifier.FSx.FileCacheTypes.MetadataConfiguration CreateMetadataConfiguration()
    {
        var metadataConfigurationResult = new Humidifier.FSx.FileCacheTypes.MetadataConfiguration();

        return metadataConfigurationResult;
    }

} // End Of Class

public static class InnerFileCacheMetadataConfigurationFactoryExtensions
{
}
