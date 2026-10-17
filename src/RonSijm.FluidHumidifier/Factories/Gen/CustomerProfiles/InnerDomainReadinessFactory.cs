// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerDomainReadinessFactory(Action<Humidifier.CustomerProfiles.DomainTypes.Readiness> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.DomainTypes.Readiness>
{

    protected override Humidifier.CustomerProfiles.DomainTypes.Readiness Create()
    {
        var readinessResult = CreateReadiness();
        factoryAction?.Invoke(readinessResult);

        return readinessResult;
    }

    private Humidifier.CustomerProfiles.DomainTypes.Readiness CreateReadiness()
    {
        var readinessResult = new Humidifier.CustomerProfiles.DomainTypes.Readiness();

        return readinessResult;
    }

} // End Of Class

public static class InnerDomainReadinessFactoryExtensions
{
}
