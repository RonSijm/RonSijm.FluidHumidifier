// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerHostedZoneVPCFactory(Action<Humidifier.Route53.HostedZoneTypes.VPC> factoryAction = null) : SubResourceFactory<Humidifier.Route53.HostedZoneTypes.VPC>
{

    protected override Humidifier.Route53.HostedZoneTypes.VPC Create()
    {
        var vPCResult = CreateVPC();
        factoryAction?.Invoke(vPCResult);

        return vPCResult;
    }

    private Humidifier.Route53.HostedZoneTypes.VPC CreateVPC()
    {
        var vPCResult = new Humidifier.Route53.HostedZoneTypes.VPC();

        return vPCResult;
    }

} // End Of Class

public static class InnerHostedZoneVPCFactoryExtensions
{
}
