// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SWF;

public class DomainFactory(string resourceName = null, Action<Humidifier.SWF.Domain> factoryAction = null) : ResourceFactory<Humidifier.SWF.Domain>(resourceName)
{

    protected override Humidifier.SWF.Domain Create()
    {
        var domainResult = CreateDomain();
        factoryAction?.Invoke(domainResult);

        return domainResult;
    }

    private Humidifier.SWF.Domain CreateDomain()
    {
        var domainResult = new Humidifier.SWF.Domain
        {
            GivenName = InputResourceName,
        };

        return domainResult;
    }

} // End Of Class

public static class DomainFactoryExtensions
{
}
