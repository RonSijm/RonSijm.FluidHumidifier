// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerChannelMultitrackInputConfigurationFactory(Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration>
{

    protected override Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration Create()
    {
        var multitrackInputConfigurationResult = CreateMultitrackInputConfiguration();
        factoryAction?.Invoke(multitrackInputConfigurationResult);

        return multitrackInputConfigurationResult;
    }

    private Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration CreateMultitrackInputConfiguration()
    {
        var multitrackInputConfigurationResult = new Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration();

        return multitrackInputConfigurationResult;
    }

} // End Of Class

public static class InnerChannelMultitrackInputConfigurationFactoryExtensions
{
}
