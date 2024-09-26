// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RolesAnywhere;

public class InnerTrustAnchorSourceFactory(Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> factoryAction = null) : SubResourceFactory<Humidifier.RolesAnywhere.TrustAnchorTypes.Source>
{

    internal InnerTrustAnchorSourceDataFactory SourceDataFactory { get; set; }

    protected override Humidifier.RolesAnywhere.TrustAnchorTypes.Source Create()
    {
        var sourceResult = CreateSource();
        factoryAction?.Invoke(sourceResult);

        return sourceResult;
    }

    private Humidifier.RolesAnywhere.TrustAnchorTypes.Source CreateSource()
    {
        var sourceResult = new Humidifier.RolesAnywhere.TrustAnchorTypes.Source();

        return sourceResult;
    }
    public override void CreateChildren(Humidifier.RolesAnywhere.TrustAnchorTypes.Source result)
    {
        base.CreateChildren(result);

        result.SourceData ??= SourceDataFactory?.Build();
    }

} // End Of Class

public static class InnerTrustAnchorSourceFactoryExtensions
{
    public static CombinedResult<InnerTrustAnchorSourceFactory, InnerTrustAnchorSourceDataFactory> WithSourceData(this InnerTrustAnchorSourceFactory parentFactory, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null)
    {
        parentFactory.SourceDataFactory = new InnerTrustAnchorSourceDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceDataFactory);
    }

    public static CombinedResult<InnerTrustAnchorSourceFactory, T1, InnerTrustAnchorSourceDataFactory> WithSourceData<T1>(this CombinedResult<InnerTrustAnchorSourceFactory, T1> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrustAnchorSourceFactory, InnerTrustAnchorSourceDataFactory> WithSourceData<T1>(this CombinedResult<T1, InnerTrustAnchorSourceFactory> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTrustAnchorSourceFactory, T1, T2, InnerTrustAnchorSourceDataFactory> WithSourceData<T1, T2>(this CombinedResult<InnerTrustAnchorSourceFactory, T1, T2> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrustAnchorSourceFactory, T2, InnerTrustAnchorSourceDataFactory> WithSourceData<T1, T2>(this CombinedResult<T1, InnerTrustAnchorSourceFactory, T2> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTrustAnchorSourceFactory, InnerTrustAnchorSourceDataFactory> WithSourceData<T1, T2>(this CombinedResult<T1, T2, InnerTrustAnchorSourceFactory> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTrustAnchorSourceFactory, T1, T2, T3, InnerTrustAnchorSourceDataFactory> WithSourceData<T1, T2, T3>(this CombinedResult<InnerTrustAnchorSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrustAnchorSourceFactory, T2, T3, InnerTrustAnchorSourceDataFactory> WithSourceData<T1, T2, T3>(this CombinedResult<T1, InnerTrustAnchorSourceFactory, T2, T3> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTrustAnchorSourceFactory, T3, InnerTrustAnchorSourceDataFactory> WithSourceData<T1, T2, T3>(this CombinedResult<T1, T2, InnerTrustAnchorSourceFactory, T3> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTrustAnchorSourceFactory, InnerTrustAnchorSourceDataFactory> WithSourceData<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTrustAnchorSourceFactory> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTrustAnchorSourceFactory, T1, T2, T3, T4, InnerTrustAnchorSourceDataFactory> WithSourceData<T1, T2, T3, T4>(this CombinedResult<InnerTrustAnchorSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrustAnchorSourceFactory, T2, T3, T4, InnerTrustAnchorSourceDataFactory> WithSourceData<T1, T2, T3, T4>(this CombinedResult<T1, InnerTrustAnchorSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTrustAnchorSourceFactory, T3, T4, InnerTrustAnchorSourceDataFactory> WithSourceData<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTrustAnchorSourceFactory, T3, T4> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTrustAnchorSourceFactory, T4, InnerTrustAnchorSourceDataFactory> WithSourceData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTrustAnchorSourceFactory, T4> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTrustAnchorSourceFactory, InnerTrustAnchorSourceDataFactory> WithSourceData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTrustAnchorSourceFactory> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceData(combinedResult.T5, subFactoryAction));
}
