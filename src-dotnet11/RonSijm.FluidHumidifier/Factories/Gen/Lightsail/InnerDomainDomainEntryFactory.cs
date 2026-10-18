// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerDomainDomainEntryFactory(Action<Humidifier.Lightsail.DomainTypes.DomainEntry> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.DomainTypes.DomainEntry>
{

    protected override Humidifier.Lightsail.DomainTypes.DomainEntry Create()
    {
        var domainEntryResult = CreateDomainEntry();
        factoryAction?.Invoke(domainEntryResult);

        return domainEntryResult;
    }

    private Humidifier.Lightsail.DomainTypes.DomainEntry CreateDomainEntry()
    {
        var domainEntryResult = new Humidifier.Lightsail.DomainTypes.DomainEntry();

        return domainEntryResult;
    }

} // End Of Class

public static class InnerDomainDomainEntryFactoryExtensions
{
}
