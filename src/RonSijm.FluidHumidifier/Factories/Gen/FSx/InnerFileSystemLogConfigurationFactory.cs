// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileSystemLogConfigurationFactory(Action<Humidifier.FSx.FileSystemTypes.LogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileSystemTypes.LogConfiguration>
{

    protected override Humidifier.FSx.FileSystemTypes.LogConfiguration Create()
    {
        var logConfigurationResult = CreateLogConfiguration();
        factoryAction?.Invoke(logConfigurationResult);

        return logConfigurationResult;
    }

    private Humidifier.FSx.FileSystemTypes.LogConfiguration CreateLogConfiguration()
    {
        var logConfigurationResult = new Humidifier.FSx.FileSystemTypes.LogConfiguration();

        return logConfigurationResult;
    }

} // End Of Class

public static class InnerFileSystemLogConfigurationFactoryExtensions
{
}
