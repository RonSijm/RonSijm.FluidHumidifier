// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerCompositionChannelDestinationConfigurationFactory(Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration>
{

    protected override Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration Create()
    {
        var channelDestinationConfigurationResult = CreateChannelDestinationConfiguration();
        factoryAction?.Invoke(channelDestinationConfigurationResult);

        return channelDestinationConfigurationResult;
    }

    private Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration CreateChannelDestinationConfiguration()
    {
        var channelDestinationConfigurationResult = new Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration();

        return channelDestinationConfigurationResult;
    }

} // End Of Class

public static class InnerCompositionChannelDestinationConfigurationFactoryExtensions
{
}
