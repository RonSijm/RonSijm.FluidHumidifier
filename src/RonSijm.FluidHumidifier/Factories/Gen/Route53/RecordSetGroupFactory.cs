// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class RecordSetGroupFactory(string resourceName = null, Action<Humidifier.Route53.RecordSetGroup> factoryAction = null) : ResourceFactory<Humidifier.Route53.RecordSetGroup>(resourceName)
{

    internal List<InnerRecordSetGroupRecordSetFactory> RecordSetsFactories { get; set; } = [];

    protected override Humidifier.Route53.RecordSetGroup Create()
    {
        var recordSetGroupResult = CreateRecordSetGroup();
        factoryAction?.Invoke(recordSetGroupResult);

        return recordSetGroupResult;
    }

    private Humidifier.Route53.RecordSetGroup CreateRecordSetGroup()
    {
        var recordSetGroupResult = new Humidifier.Route53.RecordSetGroup
        {
            GivenName = InputResourceName,
        };

        return recordSetGroupResult;
    }
    public override void CreateChildren(Humidifier.Route53.RecordSetGroup result)
    {
        base.CreateChildren(result);

        result.RecordSets = RecordSetsFactories.Any() ? RecordSetsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RecordSetGroupFactoryExtensions
{
    public static CombinedResult<RecordSetGroupFactory, InnerRecordSetGroupRecordSetFactory> WithRecordSets(this RecordSetGroupFactory parentFactory, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null)
    {
        var factory = new InnerRecordSetGroupRecordSetFactory(subFactoryAction);
        parentFactory.RecordSetsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RecordSetGroupFactory, T1, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1>(this CombinedResult<RecordSetGroupFactory, T1> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordSets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RecordSetGroupFactory, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1>(this CombinedResult<T1, RecordSetGroupFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordSets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RecordSetGroupFactory, T1, T2, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1, T2>(this CombinedResult<RecordSetGroupFactory, T1, T2> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordSets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RecordSetGroupFactory, T2, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1, T2>(this CombinedResult<T1, RecordSetGroupFactory, T2> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordSets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RecordSetGroupFactory, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1, T2>(this CombinedResult<T1, T2, RecordSetGroupFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordSets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RecordSetGroupFactory, T1, T2, T3, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1, T2, T3>(this CombinedResult<RecordSetGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RecordSetGroupFactory, T2, T3, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1, T2, T3>(this CombinedResult<T1, RecordSetGroupFactory, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RecordSetGroupFactory, T3, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1, T2, T3>(this CombinedResult<T1, T2, RecordSetGroupFactory, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RecordSetGroupFactory, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1, T2, T3>(this CombinedResult<T1, T2, T3, RecordSetGroupFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RecordSetGroupFactory, T1, T2, T3, T4, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1, T2, T3, T4>(this CombinedResult<RecordSetGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RecordSetGroupFactory, T2, T3, T4, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1, T2, T3, T4>(this CombinedResult<T1, RecordSetGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RecordSetGroupFactory, T3, T4, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1, T2, T3, T4>(this CombinedResult<T1, T2, RecordSetGroupFactory, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RecordSetGroupFactory, T4, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RecordSetGroupFactory, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RecordSetGroupFactory, InnerRecordSetGroupRecordSetFactory> WithRecordSets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RecordSetGroupFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.RecordSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSets(combinedResult.T5, subFactoryAction));
}
