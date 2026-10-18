// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class DomainFactory(string resourceName = null, Action<Humidifier.Cases.Domain> factoryAction = null) : ResourceFactory<Humidifier.Cases.Domain>(resourceName)
{

    protected override Humidifier.Cases.Domain Create()
    {
        var domainResult = CreateDomain();
        factoryAction?.Invoke(domainResult);

        return domainResult;
    }

    private Humidifier.Cases.Domain CreateDomain()
    {
        var domainResult = new Humidifier.Cases.Domain
        {
            GivenName = InputResourceName,
        };

        return domainResult;
    }

} // End Of Class

public static class DomainFactoryExtensions
{
}
