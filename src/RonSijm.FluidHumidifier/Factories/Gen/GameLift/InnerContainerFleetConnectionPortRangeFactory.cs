// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerFleetConnectionPortRangeFactory(Action<Humidifier.GameLift.ContainerFleetTypes.ConnectionPortRange> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerFleetTypes.ConnectionPortRange>
{

    protected override Humidifier.GameLift.ContainerFleetTypes.ConnectionPortRange Create()
    {
        var connectionPortRangeResult = CreateConnectionPortRange();
        factoryAction?.Invoke(connectionPortRangeResult);

        return connectionPortRangeResult;
    }

    private Humidifier.GameLift.ContainerFleetTypes.ConnectionPortRange CreateConnectionPortRange()
    {
        var connectionPortRangeResult = new Humidifier.GameLift.ContainerFleetTypes.ConnectionPortRange();

        return connectionPortRangeResult;
    }

} // End Of Class

public static class InnerContainerFleetConnectionPortRangeFactoryExtensions
{
}
