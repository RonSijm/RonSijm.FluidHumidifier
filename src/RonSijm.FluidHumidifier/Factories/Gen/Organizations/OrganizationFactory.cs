// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Organizations;

public class OrganizationFactory(string resourceName = null, Action<Humidifier.Organizations.Organization> factoryAction = null) : ResourceFactory<Humidifier.Organizations.Organization>(resourceName)
{

    protected override Humidifier.Organizations.Organization Create()
    {
        var organizationResult = CreateOrganization();
        factoryAction?.Invoke(organizationResult);

        return organizationResult;
    }

    private Humidifier.Organizations.Organization CreateOrganization()
    {
        var organizationResult = new Humidifier.Organizations.Organization
        {
            GivenName = InputResourceName,
        };

        return organizationResult;
    }

} // End Of Class

public static class OrganizationFactoryExtensions
{
}
