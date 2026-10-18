// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class DomainUnitFactory(string resourceName = null, Action<Humidifier.DataZone.DomainUnit> factoryAction = null) : ResourceFactory<Humidifier.DataZone.DomainUnit>(resourceName)
{

    protected override Humidifier.DataZone.DomainUnit Create()
    {
        var domainUnitResult = CreateDomainUnit();
        factoryAction?.Invoke(domainUnitResult);

        return domainUnitResult;
    }

    private Humidifier.DataZone.DomainUnit CreateDomainUnit()
    {
        var domainUnitResult = new Humidifier.DataZone.DomainUnit
        {
            GivenName = InputResourceName,
        };

        return domainUnitResult;
    }

} // End Of Class

public static class DomainUnitFactoryExtensions
{
}
