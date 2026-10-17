// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantDomainUnitFilterForProjectFactory(Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject Create()
    {
        var domainUnitFilterForProjectResult = CreateDomainUnitFilterForProject();
        factoryAction?.Invoke(domainUnitFilterForProjectResult);

        return domainUnitFilterForProjectResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject CreateDomainUnitFilterForProject()
    {
        var domainUnitFilterForProjectResult = new Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject();

        return domainUnitFilterForProjectResult;
    }

} // End Of Class

public static class InnerPolicyGrantDomainUnitFilterForProjectFactoryExtensions
{
}
