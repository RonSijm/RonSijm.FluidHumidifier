// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerDataflowEndpointGroupSecurityDetailsFactory(Action<Humidifier.GroundStation.DataflowEndpointGroupTypes.SecurityDetails> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.DataflowEndpointGroupTypes.SecurityDetails>
{

    protected override Humidifier.GroundStation.DataflowEndpointGroupTypes.SecurityDetails Create()
    {
        var securityDetailsResult = CreateSecurityDetails();
        factoryAction?.Invoke(securityDetailsResult);

        return securityDetailsResult;
    }

    private Humidifier.GroundStation.DataflowEndpointGroupTypes.SecurityDetails CreateSecurityDetails()
    {
        var securityDetailsResult = new Humidifier.GroundStation.DataflowEndpointGroupTypes.SecurityDetails();

        return securityDetailsResult;
    }

} // End Of Class

public static class InnerDataflowEndpointGroupSecurityDetailsFactoryExtensions
{
}
