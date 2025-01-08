// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileSystemReadCacheConfigurationFactory(Action<Humidifier.FSx.FileSystemTypes.ReadCacheConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileSystemTypes.ReadCacheConfiguration>
{

    protected override Humidifier.FSx.FileSystemTypes.ReadCacheConfiguration Create()
    {
        var readCacheConfigurationResult = CreateReadCacheConfiguration();
        factoryAction?.Invoke(readCacheConfigurationResult);

        return readCacheConfigurationResult;
    }

    private Humidifier.FSx.FileSystemTypes.ReadCacheConfiguration CreateReadCacheConfiguration()
    {
        var readCacheConfigurationResult = new Humidifier.FSx.FileSystemTypes.ReadCacheConfiguration();

        return readCacheConfigurationResult;
    }

} // End Of Class

public static class InnerFileSystemReadCacheConfigurationFactoryExtensions
{
}
