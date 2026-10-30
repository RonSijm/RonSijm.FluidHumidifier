// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory(Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal>
{

    protected override Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal Create()
    {
        var organizationAccessGrantPrincipalResult = CreateOrganizationAccessGrantPrincipal();
        factoryAction?.Invoke(organizationAccessGrantPrincipalResult);

        return organizationAccessGrantPrincipalResult;
    }

    private Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal CreateOrganizationAccessGrantPrincipal()
    {
        var organizationAccessGrantPrincipalResult = new Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal();

        return organizationAccessGrantPrincipalResult;
    }

} // End Of Class

public static class InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactoryExtensions
{
}
