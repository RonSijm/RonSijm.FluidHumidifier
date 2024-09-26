// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Detective;

public class OrganizationAdminFactory(string resourceName = null, Action<Humidifier.Detective.OrganizationAdmin> factoryAction = null) : ResourceFactory<Humidifier.Detective.OrganizationAdmin>(resourceName)
{

    protected override Humidifier.Detective.OrganizationAdmin Create()
    {
        var organizationAdminResult = CreateOrganizationAdmin();
        factoryAction?.Invoke(organizationAdminResult);

        return organizationAdminResult;
    }

    private Humidifier.Detective.OrganizationAdmin CreateOrganizationAdmin()
    {
        var organizationAdminResult = new Humidifier.Detective.OrganizationAdmin
        {
            GivenName = InputResourceName,
        };

        return organizationAdminResult;
    }

} // End Of Class

public static class OrganizationAdminFactoryExtensions
{
}
