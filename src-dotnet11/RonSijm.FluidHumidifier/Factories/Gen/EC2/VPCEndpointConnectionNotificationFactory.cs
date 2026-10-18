// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCEndpointConnectionNotificationFactory(string resourceName = null, Action<Humidifier.EC2.VPCEndpointConnectionNotification> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCEndpointConnectionNotification>(resourceName)
{

    protected override Humidifier.EC2.VPCEndpointConnectionNotification Create()
    {
        var vPCEndpointConnectionNotificationResult = CreateVPCEndpointConnectionNotification();
        factoryAction?.Invoke(vPCEndpointConnectionNotificationResult);

        return vPCEndpointConnectionNotificationResult;
    }

    private Humidifier.EC2.VPCEndpointConnectionNotification CreateVPCEndpointConnectionNotification()
    {
        var vPCEndpointConnectionNotificationResult = new Humidifier.EC2.VPCEndpointConnectionNotification
        {
            GivenName = InputResourceName,
        };

        return vPCEndpointConnectionNotificationResult;
    }

} // End Of Class

public static class VPCEndpointConnectionNotificationFactoryExtensions
{
}
