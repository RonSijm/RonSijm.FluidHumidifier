// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCDHCPOptionsAssociationFactory(string resourceName = null, Action<Humidifier.EC2.VPCDHCPOptionsAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCDHCPOptionsAssociation>(resourceName)
{

    protected override Humidifier.EC2.VPCDHCPOptionsAssociation Create()
    {
        var vPCDHCPOptionsAssociationResult = CreateVPCDHCPOptionsAssociation();
        factoryAction?.Invoke(vPCDHCPOptionsAssociationResult);

        return vPCDHCPOptionsAssociationResult;
    }

    private Humidifier.EC2.VPCDHCPOptionsAssociation CreateVPCDHCPOptionsAssociation()
    {
        var vPCDHCPOptionsAssociationResult = new Humidifier.EC2.VPCDHCPOptionsAssociation
        {
            GivenName = InputResourceName,
        };

        return vPCDHCPOptionsAssociationResult;
    }

} // End Of Class

public static class VPCDHCPOptionsAssociationFactoryExtensions
{
}
