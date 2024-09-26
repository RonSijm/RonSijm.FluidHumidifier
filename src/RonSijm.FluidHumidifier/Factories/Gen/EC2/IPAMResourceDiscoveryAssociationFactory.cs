// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IPAMResourceDiscoveryAssociationFactory(string resourceName = null, Action<Humidifier.EC2.IPAMResourceDiscoveryAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.IPAMResourceDiscoveryAssociation>(resourceName)
{

    protected override Humidifier.EC2.IPAMResourceDiscoveryAssociation Create()
    {
        var iPAMResourceDiscoveryAssociationResult = CreateIPAMResourceDiscoveryAssociation();
        factoryAction?.Invoke(iPAMResourceDiscoveryAssociationResult);

        return iPAMResourceDiscoveryAssociationResult;
    }

    private Humidifier.EC2.IPAMResourceDiscoveryAssociation CreateIPAMResourceDiscoveryAssociation()
    {
        var iPAMResourceDiscoveryAssociationResult = new Humidifier.EC2.IPAMResourceDiscoveryAssociation
        {
            GivenName = InputResourceName,
        };

        return iPAMResourceDiscoveryAssociationResult;
    }

} // End Of Class

public static class IPAMResourceDiscoveryAssociationFactoryExtensions
{
}
