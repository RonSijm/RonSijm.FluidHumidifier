// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerChannelLogConfigurationForChannelFactory(Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel>
{

    protected override Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel Create()
    {
        var logConfigurationForChannelResult = CreateLogConfigurationForChannel();
        factoryAction?.Invoke(logConfigurationForChannelResult);

        return logConfigurationForChannelResult;
    }

    private Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel CreateLogConfigurationForChannel()
    {
        var logConfigurationForChannelResult = new Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel();

        return logConfigurationForChannelResult;
    }

} // End Of Class

public static class InnerChannelLogConfigurationForChannelFactoryExtensions
{
}
