// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerDomainConsolidationFactory(Action<Humidifier.CustomerProfiles.DomainTypes.Consolidation> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.DomainTypes.Consolidation>
{

    protected override Humidifier.CustomerProfiles.DomainTypes.Consolidation Create()
    {
        var consolidationResult = CreateConsolidation();
        factoryAction?.Invoke(consolidationResult);

        return consolidationResult;
    }

    private Humidifier.CustomerProfiles.DomainTypes.Consolidation CreateConsolidation()
    {
        var consolidationResult = new Humidifier.CustomerProfiles.DomainTypes.Consolidation();

        return consolidationResult;
    }

} // End Of Class

public static class InnerDomainConsolidationFactoryExtensions
{
}
