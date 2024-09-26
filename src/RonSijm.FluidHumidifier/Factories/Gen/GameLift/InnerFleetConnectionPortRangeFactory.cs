// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetConnectionPortRangeFactory(Action<Humidifier.GameLift.FleetTypes.ConnectionPortRange> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.ConnectionPortRange>
{

    protected override Humidifier.GameLift.FleetTypes.ConnectionPortRange Create()
    {
        var connectionPortRangeResult = CreateConnectionPortRange();
        factoryAction?.Invoke(connectionPortRangeResult);

        return connectionPortRangeResult;
    }

    private Humidifier.GameLift.FleetTypes.ConnectionPortRange CreateConnectionPortRange()
    {
        var connectionPortRangeResult = new Humidifier.GameLift.FleetTypes.ConnectionPortRange();

        return connectionPortRangeResult;
    }

} // End Of Class

public static class InnerFleetConnectionPortRangeFactoryExtensions
{
}
