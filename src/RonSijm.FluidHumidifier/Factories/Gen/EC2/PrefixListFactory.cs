// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class PrefixListFactory(string resourceName = null, Action<Humidifier.EC2.PrefixList> factoryAction = null) : ResourceFactory<Humidifier.EC2.PrefixList>(resourceName)
{

    internal List<InnerPrefixListEntryFactory> EntriesFactories { get; set; } = [];

    protected override Humidifier.EC2.PrefixList Create()
    {
        var prefixListResult = CreatePrefixList();
        factoryAction?.Invoke(prefixListResult);

        return prefixListResult;
    }

    private Humidifier.EC2.PrefixList CreatePrefixList()
    {
        var prefixListResult = new Humidifier.EC2.PrefixList
        {
            GivenName = InputResourceName,
        };

        return prefixListResult;
    }
    public override void CreateChildren(Humidifier.EC2.PrefixList result)
    {
        base.CreateChildren(result);

        result.Entries = EntriesFactories.Any() ? EntriesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class PrefixListFactoryExtensions
{
    public static CombinedResult<PrefixListFactory, InnerPrefixListEntryFactory> WithEntries(this PrefixListFactory parentFactory, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null)
    {
        var factory = new InnerPrefixListEntryFactory(subFactoryAction);
        parentFactory.EntriesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PrefixListFactory, T1, InnerPrefixListEntryFactory> WithEntries<T1>(this CombinedResult<PrefixListFactory, T1> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntries(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrefixListFactory, InnerPrefixListEntryFactory> WithEntries<T1>(this CombinedResult<T1, PrefixListFactory> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntries(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PrefixListFactory, T1, T2, InnerPrefixListEntryFactory> WithEntries<T1, T2>(this CombinedResult<PrefixListFactory, T1, T2> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrefixListFactory, T2, InnerPrefixListEntryFactory> WithEntries<T1, T2>(this CombinedResult<T1, PrefixListFactory, T2> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrefixListFactory, InnerPrefixListEntryFactory> WithEntries<T1, T2>(this CombinedResult<T1, T2, PrefixListFactory> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PrefixListFactory, T1, T2, T3, InnerPrefixListEntryFactory> WithEntries<T1, T2, T3>(this CombinedResult<PrefixListFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrefixListFactory, T2, T3, InnerPrefixListEntryFactory> WithEntries<T1, T2, T3>(this CombinedResult<T1, PrefixListFactory, T2, T3> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrefixListFactory, T3, InnerPrefixListEntryFactory> WithEntries<T1, T2, T3>(this CombinedResult<T1, T2, PrefixListFactory, T3> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PrefixListFactory, InnerPrefixListEntryFactory> WithEntries<T1, T2, T3>(this CombinedResult<T1, T2, T3, PrefixListFactory> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PrefixListFactory, T1, T2, T3, T4, InnerPrefixListEntryFactory> WithEntries<T1, T2, T3, T4>(this CombinedResult<PrefixListFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrefixListFactory, T2, T3, T4, InnerPrefixListEntryFactory> WithEntries<T1, T2, T3, T4>(this CombinedResult<T1, PrefixListFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrefixListFactory, T3, T4, InnerPrefixListEntryFactory> WithEntries<T1, T2, T3, T4>(this CombinedResult<T1, T2, PrefixListFactory, T3, T4> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PrefixListFactory, T4, InnerPrefixListEntryFactory> WithEntries<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PrefixListFactory, T4> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PrefixListFactory, InnerPrefixListEntryFactory> WithEntries<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PrefixListFactory> combinedResult, Action<Humidifier.EC2.PrefixListTypes.Entry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntries(combinedResult.T5, subFactoryAction));
}
