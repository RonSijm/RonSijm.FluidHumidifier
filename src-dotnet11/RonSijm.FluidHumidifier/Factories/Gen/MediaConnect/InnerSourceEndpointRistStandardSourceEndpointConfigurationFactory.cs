// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerSourceEndpointRistStandardSourceEndpointConfigurationFactory(Action<Humidifier.MediaConnect.SourceEndpointTypes.RistStandardSourceEndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.SourceEndpointTypes.RistStandardSourceEndpointConfiguration>
{

    protected override Humidifier.MediaConnect.SourceEndpointTypes.RistStandardSourceEndpointConfiguration Create()
    {
        var ristStandardSourceEndpointConfigurationResult = CreateRistStandardSourceEndpointConfiguration();
        factoryAction?.Invoke(ristStandardSourceEndpointConfigurationResult);

        return ristStandardSourceEndpointConfigurationResult;
    }

    private Humidifier.MediaConnect.SourceEndpointTypes.RistStandardSourceEndpointConfiguration CreateRistStandardSourceEndpointConfiguration()
    {
        var ristStandardSourceEndpointConfigurationResult = new Humidifier.MediaConnect.SourceEndpointTypes.RistStandardSourceEndpointConfiguration();

        return ristStandardSourceEndpointConfigurationResult;
    }

} // End Of Class

public static class InnerSourceEndpointRistStandardSourceEndpointConfigurationFactoryExtensions
{
}
