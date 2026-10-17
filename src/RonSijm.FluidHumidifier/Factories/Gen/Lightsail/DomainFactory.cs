// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class DomainFactory(string resourceName = null, Action<Humidifier.Lightsail.Domain> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.Domain>(resourceName)
{

    internal List<InnerDomainDomainEntryFactory> DomainEntriesFactories { get; set; } = [];

    protected override Humidifier.Lightsail.Domain Create()
    {
        var domainResult = CreateDomain();
        factoryAction?.Invoke(domainResult);

        return domainResult;
    }

    private Humidifier.Lightsail.Domain CreateDomain()
    {
        var domainResult = new Humidifier.Lightsail.Domain
        {
            GivenName = InputResourceName,
        };

        return domainResult;
    }
    public override void CreateChildren(Humidifier.Lightsail.Domain result)
    {
        base.CreateChildren(result);

        result.DomainEntries = DomainEntriesFactories.Any() ? DomainEntriesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DomainFactoryExtensions
{
    public static CombinedResult<DomainFactory, InnerDomainDomainEntryFactory> WithDomainEntries(this DomainFactory parentFactory, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null)
    {
        var factory = new InnerDomainDomainEntryFactory(subFactoryAction);
        parentFactory.DomainEntriesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DomainFactory, T1, InnerDomainDomainEntryFactory> WithDomainEntries<T1>(this CombinedResult<DomainFactory, T1> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainEntries(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainFactory, InnerDomainDomainEntryFactory> WithDomainEntries<T1>(this CombinedResult<T1, DomainFactory> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainEntries(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DomainFactory, T1, T2, InnerDomainDomainEntryFactory> WithDomainEntries<T1, T2>(this CombinedResult<DomainFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainEntries(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainFactory, T2, InnerDomainDomainEntryFactory> WithDomainEntries<T1, T2>(this CombinedResult<T1, DomainFactory, T2> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainEntries(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainFactory, InnerDomainDomainEntryFactory> WithDomainEntries<T1, T2>(this CombinedResult<T1, T2, DomainFactory> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainEntries(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DomainFactory, T1, T2, T3, InnerDomainDomainEntryFactory> WithDomainEntries<T1, T2, T3>(this CombinedResult<DomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainEntries(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainFactory, T2, T3, InnerDomainDomainEntryFactory> WithDomainEntries<T1, T2, T3>(this CombinedResult<T1, DomainFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainEntries(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainFactory, T3, InnerDomainDomainEntryFactory> WithDomainEntries<T1, T2, T3>(this CombinedResult<T1, T2, DomainFactory, T3> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainEntries(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DomainFactory, InnerDomainDomainEntryFactory> WithDomainEntries<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainFactory> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainEntries(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DomainFactory, T1, T2, T3, T4, InnerDomainDomainEntryFactory> WithDomainEntries<T1, T2, T3, T4>(this CombinedResult<DomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainEntries(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainFactory, T2, T3, T4, InnerDomainDomainEntryFactory> WithDomainEntries<T1, T2, T3, T4>(this CombinedResult<T1, DomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainEntries(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainFactory, T3, T4, InnerDomainDomainEntryFactory> WithDomainEntries<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainEntries(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DomainFactory, T4, InnerDomainDomainEntryFactory> WithDomainEntries<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainFactory, T4> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainEntries(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DomainFactory, InnerDomainDomainEntryFactory> WithDomainEntries<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainFactory> combinedResult, Action<Humidifier.Lightsail.DomainTypes.DomainEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainEntries(combinedResult.T5, subFactoryAction).T2);
}
