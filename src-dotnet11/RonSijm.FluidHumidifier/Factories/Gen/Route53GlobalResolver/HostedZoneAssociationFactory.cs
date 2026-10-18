// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53GlobalResolver;

public class HostedZoneAssociationFactory(string resourceName = null, Action<Humidifier.Route53GlobalResolver.HostedZoneAssociation> factoryAction = null) : ResourceFactory<Humidifier.Route53GlobalResolver.HostedZoneAssociation>(resourceName)
{

    protected override Humidifier.Route53GlobalResolver.HostedZoneAssociation Create()
    {
        var hostedZoneAssociationResult = CreateHostedZoneAssociation();
        factoryAction?.Invoke(hostedZoneAssociationResult);

        return hostedZoneAssociationResult;
    }

    private Humidifier.Route53GlobalResolver.HostedZoneAssociation CreateHostedZoneAssociation()
    {
        var hostedZoneAssociationResult = new Humidifier.Route53GlobalResolver.HostedZoneAssociation
        {
            GivenName = InputResourceName,
        };

        return hostedZoneAssociationResult;
    }

} // End Of Class

public static class HostedZoneAssociationFactoryExtensions
{
}
