// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensGroupAndFactory(Action<Humidifier.S3.StorageLensGroupTypes.And> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensGroupTypes.And>
{

    internal InnerStorageLensGroupMatchObjectAgeFactory MatchObjectAgeFactory { get; set; }

    internal InnerStorageLensGroupMatchObjectSizeFactory MatchObjectSizeFactory { get; set; }

    protected override Humidifier.S3.StorageLensGroupTypes.And Create()
    {
        var andResult = CreateAnd();
        factoryAction?.Invoke(andResult);

        return andResult;
    }

    private Humidifier.S3.StorageLensGroupTypes.And CreateAnd()
    {
        var andResult = new Humidifier.S3.StorageLensGroupTypes.And();

        return andResult;
    }
    public override void CreateChildren(Humidifier.S3.StorageLensGroupTypes.And result)
    {
        base.CreateChildren(result);

        result.MatchObjectAge ??= MatchObjectAgeFactory?.Build();
        result.MatchObjectSize ??= MatchObjectSizeFactory?.Build();
    }

} // End Of Class

public static class InnerStorageLensGroupAndFactoryExtensions
{
    public static CombinedResult<InnerStorageLensGroupAndFactory, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge(this InnerStorageLensGroupAndFactory parentFactory, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null)
    {
        parentFactory.MatchObjectAgeFactory = new InnerStorageLensGroupMatchObjectAgeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchObjectAgeFactory);
    }

    public static CombinedResult<InnerStorageLensGroupAndFactory, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize(this InnerStorageLensGroupAndFactory parentFactory, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null)
    {
        parentFactory.MatchObjectSizeFactory = new InnerStorageLensGroupMatchObjectSizeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchObjectSizeFactory);
    }

    public static CombinedResult<InnerStorageLensGroupAndFactory, T1, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1>(this CombinedResult<InnerStorageLensGroupAndFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupAndFactory, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1>(this CombinedResult<T1, InnerStorageLensGroupAndFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupAndFactory, T1, T2, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2>(this CombinedResult<InnerStorageLensGroupAndFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupAndFactory, T2, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2>(this CombinedResult<T1, InnerStorageLensGroupAndFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensGroupAndFactory, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2>(this CombinedResult<T1, T2, InnerStorageLensGroupAndFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupAndFactory, T1, T2, T3, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3>(this CombinedResult<InnerStorageLensGroupAndFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupAndFactory, T2, T3, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3>(this CombinedResult<T1, InnerStorageLensGroupAndFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensGroupAndFactory, T3, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3>(this CombinedResult<T1, T2, InnerStorageLensGroupAndFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensGroupAndFactory, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStorageLensGroupAndFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupAndFactory, T1, T2, T3, T4, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3, T4>(this CombinedResult<InnerStorageLensGroupAndFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupAndFactory, T2, T3, T4, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3, T4>(this CombinedResult<T1, InnerStorageLensGroupAndFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensGroupAndFactory, T3, T4, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStorageLensGroupAndFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensGroupAndFactory, T4, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStorageLensGroupAndFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerStorageLensGroupAndFactory, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStorageLensGroupAndFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupAndFactory, T1, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1>(this CombinedResult<InnerStorageLensGroupAndFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupAndFactory, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1>(this CombinedResult<T1, InnerStorageLensGroupAndFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupAndFactory, T1, T2, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2>(this CombinedResult<InnerStorageLensGroupAndFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupAndFactory, T2, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2>(this CombinedResult<T1, InnerStorageLensGroupAndFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensGroupAndFactory, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2>(this CombinedResult<T1, T2, InnerStorageLensGroupAndFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupAndFactory, T1, T2, T3, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3>(this CombinedResult<InnerStorageLensGroupAndFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupAndFactory, T2, T3, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3>(this CombinedResult<T1, InnerStorageLensGroupAndFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensGroupAndFactory, T3, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3>(this CombinedResult<T1, T2, InnerStorageLensGroupAndFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensGroupAndFactory, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStorageLensGroupAndFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupAndFactory, T1, T2, T3, T4, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3, T4>(this CombinedResult<InnerStorageLensGroupAndFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupAndFactory, T2, T3, T4, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3, T4>(this CombinedResult<T1, InnerStorageLensGroupAndFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensGroupAndFactory, T3, T4, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStorageLensGroupAndFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensGroupAndFactory, T4, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStorageLensGroupAndFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerStorageLensGroupAndFactory, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStorageLensGroupAndFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T5, subFactoryAction));
}
