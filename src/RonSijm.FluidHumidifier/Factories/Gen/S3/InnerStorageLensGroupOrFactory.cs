// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensGroupOrFactory(Action<Humidifier.S3.StorageLensGroupTypes.Or> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensGroupTypes.Or>
{

    internal InnerStorageLensGroupMatchObjectAgeFactory MatchObjectAgeFactory { get; set; }

    internal InnerStorageLensGroupMatchObjectSizeFactory MatchObjectSizeFactory { get; set; }

    protected override Humidifier.S3.StorageLensGroupTypes.Or Create()
    {
        var orResult = CreateOr();
        factoryAction?.Invoke(orResult);

        return orResult;
    }

    private Humidifier.S3.StorageLensGroupTypes.Or CreateOr()
    {
        var orResult = new Humidifier.S3.StorageLensGroupTypes.Or();

        return orResult;
    }
    public override void CreateChildren(Humidifier.S3.StorageLensGroupTypes.Or result)
    {
        base.CreateChildren(result);

        result.MatchObjectAge ??= MatchObjectAgeFactory?.Build();
        result.MatchObjectSize ??= MatchObjectSizeFactory?.Build();
    }

} // End Of Class

public static class InnerStorageLensGroupOrFactoryExtensions
{
    public static CombinedResult<InnerStorageLensGroupOrFactory, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge(this InnerStorageLensGroupOrFactory parentFactory, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null)
    {
        parentFactory.MatchObjectAgeFactory = new InnerStorageLensGroupMatchObjectAgeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchObjectAgeFactory);
    }

    public static CombinedResult<InnerStorageLensGroupOrFactory, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize(this InnerStorageLensGroupOrFactory parentFactory, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null)
    {
        parentFactory.MatchObjectSizeFactory = new InnerStorageLensGroupMatchObjectSizeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchObjectSizeFactory);
    }

    public static CombinedResult<InnerStorageLensGroupOrFactory, T1, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1>(this CombinedResult<InnerStorageLensGroupOrFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupOrFactory, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1>(this CombinedResult<T1, InnerStorageLensGroupOrFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupOrFactory, T1, T2, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2>(this CombinedResult<InnerStorageLensGroupOrFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupOrFactory, T2, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2>(this CombinedResult<T1, InnerStorageLensGroupOrFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensGroupOrFactory, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2>(this CombinedResult<T1, T2, InnerStorageLensGroupOrFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupOrFactory, T1, T2, T3, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3>(this CombinedResult<InnerStorageLensGroupOrFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupOrFactory, T2, T3, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3>(this CombinedResult<T1, InnerStorageLensGroupOrFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensGroupOrFactory, T3, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3>(this CombinedResult<T1, T2, InnerStorageLensGroupOrFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensGroupOrFactory, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStorageLensGroupOrFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupOrFactory, T1, T2, T3, T4, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3, T4>(this CombinedResult<InnerStorageLensGroupOrFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupOrFactory, T2, T3, T4, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3, T4>(this CombinedResult<T1, InnerStorageLensGroupOrFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensGroupOrFactory, T3, T4, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStorageLensGroupOrFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensGroupOrFactory, T4, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStorageLensGroupOrFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerStorageLensGroupOrFactory, InnerStorageLensGroupMatchObjectAgeFactory> WithMatchObjectAge<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStorageLensGroupOrFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectAge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectAge(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupOrFactory, T1, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1>(this CombinedResult<InnerStorageLensGroupOrFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupOrFactory, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1>(this CombinedResult<T1, InnerStorageLensGroupOrFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupOrFactory, T1, T2, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2>(this CombinedResult<InnerStorageLensGroupOrFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupOrFactory, T2, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2>(this CombinedResult<T1, InnerStorageLensGroupOrFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensGroupOrFactory, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2>(this CombinedResult<T1, T2, InnerStorageLensGroupOrFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupOrFactory, T1, T2, T3, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3>(this CombinedResult<InnerStorageLensGroupOrFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupOrFactory, T2, T3, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3>(this CombinedResult<T1, InnerStorageLensGroupOrFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensGroupOrFactory, T3, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3>(this CombinedResult<T1, T2, InnerStorageLensGroupOrFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensGroupOrFactory, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStorageLensGroupOrFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerStorageLensGroupOrFactory, T1, T2, T3, T4, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3, T4>(this CombinedResult<InnerStorageLensGroupOrFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensGroupOrFactory, T2, T3, T4, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3, T4>(this CombinedResult<T1, InnerStorageLensGroupOrFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensGroupOrFactory, T3, T4, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStorageLensGroupOrFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensGroupOrFactory, T4, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStorageLensGroupOrFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerStorageLensGroupOrFactory, InnerStorageLensGroupMatchObjectSizeFactory> WithMatchObjectSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStorageLensGroupOrFactory> combinedResult, Action<Humidifier.S3.StorageLensGroupTypes.MatchObjectSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchObjectSize(combinedResult.T5, subFactoryAction));
}
