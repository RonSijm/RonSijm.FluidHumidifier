// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Vectors;

public class InnerIndexMetadataConfigurationFactory(Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration>
{

    protected override Humidifier.S3Vectors.IndexTypes.MetadataConfiguration Create()
    {
        var metadataConfigurationResult = CreateMetadataConfiguration();
        factoryAction?.Invoke(metadataConfigurationResult);

        return metadataConfigurationResult;
    }

    private Humidifier.S3Vectors.IndexTypes.MetadataConfiguration CreateMetadataConfiguration()
    {
        var metadataConfigurationResult = new Humidifier.S3Vectors.IndexTypes.MetadataConfiguration();

        return metadataConfigurationResult;
    }

} // End Of Class

public static class InnerIndexMetadataConfigurationFactoryExtensions
{
}
