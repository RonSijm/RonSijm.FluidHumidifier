// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class EnclaveCertificateIamRoleAssociationFactory(string resourceName = null, Action<Humidifier.EC2.EnclaveCertificateIamRoleAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.EnclaveCertificateIamRoleAssociation>(resourceName)
{

    protected override Humidifier.EC2.EnclaveCertificateIamRoleAssociation Create()
    {
        var enclaveCertificateIamRoleAssociationResult = CreateEnclaveCertificateIamRoleAssociation();
        factoryAction?.Invoke(enclaveCertificateIamRoleAssociationResult);

        return enclaveCertificateIamRoleAssociationResult;
    }

    private Humidifier.EC2.EnclaveCertificateIamRoleAssociation CreateEnclaveCertificateIamRoleAssociation()
    {
        var enclaveCertificateIamRoleAssociationResult = new Humidifier.EC2.EnclaveCertificateIamRoleAssociation
        {
            GivenName = InputResourceName,
        };

        return enclaveCertificateIamRoleAssociationResult;
    }

} // End Of Class

public static class EnclaveCertificateIamRoleAssociationFactoryExtensions
{
}
