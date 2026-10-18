// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryControl;

public class RoutingControlFactory(string resourceName = null, Action<Humidifier.Route53RecoveryControl.RoutingControl> factoryAction = null) : ResourceFactory<Humidifier.Route53RecoveryControl.RoutingControl>(resourceName)
{

    protected override Humidifier.Route53RecoveryControl.RoutingControl Create()
    {
        var routingControlResult = CreateRoutingControl();
        factoryAction?.Invoke(routingControlResult);

        return routingControlResult;
    }

    private Humidifier.Route53RecoveryControl.RoutingControl CreateRoutingControl()
    {
        var routingControlResult = new Humidifier.Route53RecoveryControl.RoutingControl
        {
            GivenName = InputResourceName,
        };

        return routingControlResult;
    }

} // End Of Class

public static class RoutingControlFactoryExtensions
{
}
