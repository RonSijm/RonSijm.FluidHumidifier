// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class DomainNameFactory(string resourceName = null, Action<Humidifier.AppSync.DomainName> factoryAction = null) : ResourceFactory<Humidifier.AppSync.DomainName>(resourceName)
{

    protected override Humidifier.AppSync.DomainName Create()
    {
        var domainNameResult = CreateDomainName();
        factoryAction?.Invoke(domainNameResult);

        return domainNameResult;
    }

    private Humidifier.AppSync.DomainName CreateDomainName()
    {
        var domainNameResult = new Humidifier.AppSync.DomainName
        {
            GivenName = InputResourceName,
        };

        return domainNameResult;
    }

} // End Of Class

public static class DomainNameFactoryExtensions
{
}
