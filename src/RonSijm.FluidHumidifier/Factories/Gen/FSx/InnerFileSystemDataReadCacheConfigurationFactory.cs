// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileSystemDataReadCacheConfigurationFactory(Action<Humidifier.FSx.FileSystemTypes.DataReadCacheConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileSystemTypes.DataReadCacheConfiguration>
{

    protected override Humidifier.FSx.FileSystemTypes.DataReadCacheConfiguration Create()
    {
        var dataReadCacheConfigurationResult = CreateDataReadCacheConfiguration();
        factoryAction?.Invoke(dataReadCacheConfigurationResult);

        return dataReadCacheConfigurationResult;
    }

    private Humidifier.FSx.FileSystemTypes.DataReadCacheConfiguration CreateDataReadCacheConfiguration()
    {
        var dataReadCacheConfigurationResult = new Humidifier.FSx.FileSystemTypes.DataReadCacheConfiguration();

        return dataReadCacheConfigurationResult;
    }

} // End Of Class

public static class InnerFileSystemDataReadCacheConfigurationFactoryExtensions
{
}
