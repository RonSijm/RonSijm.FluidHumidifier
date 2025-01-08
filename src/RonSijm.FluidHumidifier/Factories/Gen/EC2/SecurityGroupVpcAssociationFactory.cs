// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SecurityGroupVpcAssociationFactory(string resourceName = null, Action<Humidifier.EC2.SecurityGroupVpcAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.SecurityGroupVpcAssociation>(resourceName)
{

    protected override Humidifier.EC2.SecurityGroupVpcAssociation Create()
    {
        var securityGroupVpcAssociationResult = CreateSecurityGroupVpcAssociation();
        factoryAction?.Invoke(securityGroupVpcAssociationResult);

        return securityGroupVpcAssociationResult;
    }

    private Humidifier.EC2.SecurityGroupVpcAssociation CreateSecurityGroupVpcAssociation()
    {
        var securityGroupVpcAssociationResult = new Humidifier.EC2.SecurityGroupVpcAssociation
        {
            GivenName = InputResourceName,
        };

        return securityGroupVpcAssociationResult;
    }

} // End Of Class

public static class SecurityGroupVpcAssociationFactoryExtensions
{
}
