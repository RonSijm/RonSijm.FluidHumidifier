// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GlobalAccelerator;

public class InnerEndpointGroupPortOverrideFactory(Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride> factoryAction = null) : SubResourceFactory<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride>
{

    protected override Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride Create()
    {
        var portOverrideResult = CreatePortOverride();
        factoryAction?.Invoke(portOverrideResult);

        return portOverrideResult;
    }

    private Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride CreatePortOverride()
    {
        var portOverrideResult = new Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride();

        return portOverrideResult;
    }

} // End Of Class

public static class InnerEndpointGroupPortOverrideFactoryExtensions
{
}
