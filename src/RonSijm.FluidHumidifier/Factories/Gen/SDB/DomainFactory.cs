// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SDB;

public class DomainFactory(string resourceName = null, Action<Humidifier.SDB.Domain> factoryAction = null) : ResourceFactory<Humidifier.SDB.Domain>(resourceName)
{

    protected override Humidifier.SDB.Domain Create()
    {
        var domainResult = CreateDomain();
        factoryAction?.Invoke(domainResult);

        return domainResult;
    }

    private Humidifier.SDB.Domain CreateDomain()
    {
        var domainResult = new Humidifier.SDB.Domain
        {
            GivenName = InputResourceName,
        };

        return domainResult;
    }

} // End Of Class

public static class DomainFactoryExtensions
{
}
