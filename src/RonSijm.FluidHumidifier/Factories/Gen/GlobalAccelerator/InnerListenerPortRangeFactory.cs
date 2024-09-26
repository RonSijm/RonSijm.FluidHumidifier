// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GlobalAccelerator;

public class InnerListenerPortRangeFactory(Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> factoryAction = null) : SubResourceFactory<Humidifier.GlobalAccelerator.ListenerTypes.PortRange>
{

    protected override Humidifier.GlobalAccelerator.ListenerTypes.PortRange Create()
    {
        var portRangeResult = CreatePortRange();
        factoryAction?.Invoke(portRangeResult);

        return portRangeResult;
    }

    private Humidifier.GlobalAccelerator.ListenerTypes.PortRange CreatePortRange()
    {
        var portRangeResult = new Humidifier.GlobalAccelerator.ListenerTypes.PortRange();

        return portRangeResult;
    }

} // End Of Class

public static class InnerListenerPortRangeFactoryExtensions
{
}
