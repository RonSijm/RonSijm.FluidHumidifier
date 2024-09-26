// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResourceGroups;

public class InnerGroupResourceQueryFactory(Action<Humidifier.ResourceGroups.GroupTypes.ResourceQuery> factoryAction = null) : SubResourceFactory<Humidifier.ResourceGroups.GroupTypes.ResourceQuery>
{

    internal InnerGroupQueryFactory QueryFactory { get; set; }

    protected override Humidifier.ResourceGroups.GroupTypes.ResourceQuery Create()
    {
        var resourceQueryResult = CreateResourceQuery();
        factoryAction?.Invoke(resourceQueryResult);

        return resourceQueryResult;
    }

    private Humidifier.ResourceGroups.GroupTypes.ResourceQuery CreateResourceQuery()
    {
        var resourceQueryResult = new Humidifier.ResourceGroups.GroupTypes.ResourceQuery();

        return resourceQueryResult;
    }
    public override void CreateChildren(Humidifier.ResourceGroups.GroupTypes.ResourceQuery result)
    {
        base.CreateChildren(result);

        result.Query ??= QueryFactory?.Build();
    }

} // End Of Class

public static class InnerGroupResourceQueryFactoryExtensions
{
    public static CombinedResult<InnerGroupResourceQueryFactory, InnerGroupQueryFactory> WithQuery(this InnerGroupResourceQueryFactory parentFactory, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null)
    {
        parentFactory.QueryFactory = new InnerGroupQueryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.QueryFactory);
    }

    public static CombinedResult<InnerGroupResourceQueryFactory, T1, InnerGroupQueryFactory> WithQuery<T1>(this CombinedResult<InnerGroupResourceQueryFactory, T1> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, WithQuery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGroupResourceQueryFactory, InnerGroupQueryFactory> WithQuery<T1>(this CombinedResult<T1, InnerGroupResourceQueryFactory> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, WithQuery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGroupResourceQueryFactory, T1, T2, InnerGroupQueryFactory> WithQuery<T1, T2>(this CombinedResult<InnerGroupResourceQueryFactory, T1, T2> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGroupResourceQueryFactory, T2, InnerGroupQueryFactory> WithQuery<T1, T2>(this CombinedResult<T1, InnerGroupResourceQueryFactory, T2> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGroupResourceQueryFactory, InnerGroupQueryFactory> WithQuery<T1, T2>(this CombinedResult<T1, T2, InnerGroupResourceQueryFactory> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGroupResourceQueryFactory, T1, T2, T3, InnerGroupQueryFactory> WithQuery<T1, T2, T3>(this CombinedResult<InnerGroupResourceQueryFactory, T1, T2, T3> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGroupResourceQueryFactory, T2, T3, InnerGroupQueryFactory> WithQuery<T1, T2, T3>(this CombinedResult<T1, InnerGroupResourceQueryFactory, T2, T3> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGroupResourceQueryFactory, T3, InnerGroupQueryFactory> WithQuery<T1, T2, T3>(this CombinedResult<T1, T2, InnerGroupResourceQueryFactory, T3> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGroupResourceQueryFactory, InnerGroupQueryFactory> WithQuery<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGroupResourceQueryFactory> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuery(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGroupResourceQueryFactory, T1, T2, T3, T4, InnerGroupQueryFactory> WithQuery<T1, T2, T3, T4>(this CombinedResult<InnerGroupResourceQueryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGroupResourceQueryFactory, T2, T3, T4, InnerGroupQueryFactory> WithQuery<T1, T2, T3, T4>(this CombinedResult<T1, InnerGroupResourceQueryFactory, T2, T3, T4> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGroupResourceQueryFactory, T3, T4, InnerGroupQueryFactory> WithQuery<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGroupResourceQueryFactory, T3, T4> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGroupResourceQueryFactory, T4, InnerGroupQueryFactory> WithQuery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGroupResourceQueryFactory, T4> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuery(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGroupResourceQueryFactory, InnerGroupQueryFactory> WithQuery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGroupResourceQueryFactory> combinedResult, Action<Humidifier.ResourceGroups.GroupTypes.Query> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuery(combinedResult.T5, subFactoryAction));
}
