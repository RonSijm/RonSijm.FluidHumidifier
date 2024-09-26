// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileSystemMetadataConfigurationFactory(Action<Humidifier.FSx.FileSystemTypes.MetadataConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileSystemTypes.MetadataConfiguration>
{

    protected override Humidifier.FSx.FileSystemTypes.MetadataConfiguration Create()
    {
        var metadataConfigurationResult = CreateMetadataConfiguration();
        factoryAction?.Invoke(metadataConfigurationResult);

        return metadataConfigurationResult;
    }

    private Humidifier.FSx.FileSystemTypes.MetadataConfiguration CreateMetadataConfiguration()
    {
        var metadataConfigurationResult = new Humidifier.FSx.FileSystemTypes.MetadataConfiguration();

        return metadataConfigurationResult;
    }

} // End Of Class

public static class InnerFileSystemMetadataConfigurationFactoryExtensions
{
}
