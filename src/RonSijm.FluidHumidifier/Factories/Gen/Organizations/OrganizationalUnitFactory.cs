// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Organizations;

public class OrganizationalUnitFactory(string resourceName = null, Action<Humidifier.Organizations.OrganizationalUnit> factoryAction = null) : ResourceFactory<Humidifier.Organizations.OrganizationalUnit>(resourceName)
{

    protected override Humidifier.Organizations.OrganizationalUnit Create()
    {
        var organizationalUnitResult = CreateOrganizationalUnit();
        factoryAction?.Invoke(organizationalUnitResult);

        return organizationalUnitResult;
    }

    private Humidifier.Organizations.OrganizationalUnit CreateOrganizationalUnit()
    {
        var organizationalUnitResult = new Humidifier.Organizations.OrganizationalUnit
        {
            GivenName = InputResourceName,
        };

        return organizationalUnitResult;
    }

} // End Of Class

public static class OrganizationalUnitFactoryExtensions
{
}
