// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileCacheLogConfigurationFactory(Action<Humidifier.FSx.FileCacheTypes.LogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileCacheTypes.LogConfiguration>
{

    protected override Humidifier.FSx.FileCacheTypes.LogConfiguration Create()
    {
        var logConfigurationResult = CreateLogConfiguration();
        factoryAction?.Invoke(logConfigurationResult);

        return logConfigurationResult;
    }

    private Humidifier.FSx.FileCacheTypes.LogConfiguration CreateLogConfiguration()
    {
        var logConfigurationResult = new Humidifier.FSx.FileCacheTypes.LogConfiguration();

        return logConfigurationResult;
    }

} // End Of Class

public static class InnerFileCacheLogConfigurationFactoryExtensions
{
}
