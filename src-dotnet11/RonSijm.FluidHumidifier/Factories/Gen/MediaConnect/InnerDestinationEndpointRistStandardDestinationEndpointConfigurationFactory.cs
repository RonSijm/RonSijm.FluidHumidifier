// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerDestinationEndpointRistStandardDestinationEndpointConfigurationFactory(Action<Humidifier.MediaConnect.DestinationEndpointTypes.RistStandardDestinationEndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.DestinationEndpointTypes.RistStandardDestinationEndpointConfiguration>
{

    protected override Humidifier.MediaConnect.DestinationEndpointTypes.RistStandardDestinationEndpointConfiguration Create()
    {
        var ristStandardDestinationEndpointConfigurationResult = CreateRistStandardDestinationEndpointConfiguration();
        factoryAction?.Invoke(ristStandardDestinationEndpointConfigurationResult);

        return ristStandardDestinationEndpointConfigurationResult;
    }

    private Humidifier.MediaConnect.DestinationEndpointTypes.RistStandardDestinationEndpointConfiguration CreateRistStandardDestinationEndpointConfiguration()
    {
        var ristStandardDestinationEndpointConfigurationResult = new Humidifier.MediaConnect.DestinationEndpointTypes.RistStandardDestinationEndpointConfiguration();

        return ristStandardDestinationEndpointConfigurationResult;
    }

} // End Of Class

public static class InnerDestinationEndpointRistStandardDestinationEndpointConfigurationFactoryExtensions
{
}
