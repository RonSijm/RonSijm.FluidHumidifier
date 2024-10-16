// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class ADMChannelFactory(string resourceName = null, Action<Humidifier.Pinpoint.ADMChannel> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.ADMChannel>(resourceName)
{

    protected override Humidifier.Pinpoint.ADMChannel Create()
    {
        var aDMChannelResult = CreateADMChannel();
        factoryAction?.Invoke(aDMChannelResult);

        return aDMChannelResult;
    }

    private Humidifier.Pinpoint.ADMChannel CreateADMChannel()
    {
        var aDMChannelResult = new Humidifier.Pinpoint.ADMChannel
        {
            GivenName = InputResourceName,
        };

        return aDMChannelResult;
    }

} // End Of Class

public static class ADMChannelFactoryExtensions
{
}
