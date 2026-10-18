// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantDomainUnitGrantFilterFactory(Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter Create()
    {
        var domainUnitGrantFilterResult = CreateDomainUnitGrantFilter();
        factoryAction?.Invoke(domainUnitGrantFilterResult);

        return domainUnitGrantFilterResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter CreateDomainUnitGrantFilter()
    {
        var domainUnitGrantFilterResult = new Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter();

        return domainUnitGrantFilterResult;
    }

} // End Of Class

public static class InnerPolicyGrantDomainUnitGrantFilterFactoryExtensions
{
}
