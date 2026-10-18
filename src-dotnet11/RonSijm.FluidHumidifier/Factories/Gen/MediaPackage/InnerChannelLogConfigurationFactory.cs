// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerChannelLogConfigurationFactory(Action<Humidifier.MediaPackage.ChannelTypes.LogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.ChannelTypes.LogConfiguration>
{

    protected override Humidifier.MediaPackage.ChannelTypes.LogConfiguration Create()
    {
        var logConfigurationResult = CreateLogConfiguration();
        factoryAction?.Invoke(logConfigurationResult);

        return logConfigurationResult;
    }

    private Humidifier.MediaPackage.ChannelTypes.LogConfiguration CreateLogConfiguration()
    {
        var logConfigurationResult = new Humidifier.MediaPackage.ChannelTypes.LogConfiguration();

        return logConfigurationResult;
    }

} // End Of Class

public static class InnerChannelLogConfigurationFactoryExtensions
{
}
