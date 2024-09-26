// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerDatasetPathOptionsFactory(Action<Humidifier.DataBrew.DatasetTypes.PathOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.DatasetTypes.PathOptions>
{

    internal InnerDatasetFilterExpressionFactory LastModifiedDateConditionFactory { get; set; }

    internal InnerDatasetFilesLimitFactory FilesLimitFactory { get; set; }

    protected override Humidifier.DataBrew.DatasetTypes.PathOptions Create()
    {
        var pathOptionsResult = CreatePathOptions();
        factoryAction?.Invoke(pathOptionsResult);

        return pathOptionsResult;
    }

    private Humidifier.DataBrew.DatasetTypes.PathOptions CreatePathOptions()
    {
        var pathOptionsResult = new Humidifier.DataBrew.DatasetTypes.PathOptions();

        return pathOptionsResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.DatasetTypes.PathOptions result)
    {
        base.CreateChildren(result);

        result.LastModifiedDateCondition ??= LastModifiedDateConditionFactory?.Build();
        result.FilesLimit ??= FilesLimitFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetPathOptionsFactoryExtensions
{
    public static CombinedResult<InnerDatasetPathOptionsFactory, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition(this InnerDatasetPathOptionsFactory parentFactory, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null)
    {
        parentFactory.LastModifiedDateConditionFactory = new InnerDatasetFilterExpressionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LastModifiedDateConditionFactory);
    }

    public static CombinedResult<InnerDatasetPathOptionsFactory, InnerDatasetFilesLimitFactory> WithFilesLimit(this InnerDatasetPathOptionsFactory parentFactory, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null)
    {
        parentFactory.FilesLimitFactory = new InnerDatasetFilesLimitFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FilesLimitFactory);
    }

    public static CombinedResult<InnerDatasetPathOptionsFactory, T1, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1>(this CombinedResult<InnerDatasetPathOptionsFactory, T1> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetPathOptionsFactory, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1>(this CombinedResult<T1, InnerDatasetPathOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetPathOptionsFactory, T1, T2, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1, T2>(this CombinedResult<InnerDatasetPathOptionsFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetPathOptionsFactory, T2, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1, T2>(this CombinedResult<T1, InnerDatasetPathOptionsFactory, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetPathOptionsFactory, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1, T2>(this CombinedResult<T1, T2, InnerDatasetPathOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetPathOptionsFactory, T1, T2, T3, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1, T2, T3>(this CombinedResult<InnerDatasetPathOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetPathOptionsFactory, T2, T3, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1, T2, T3>(this CombinedResult<T1, InnerDatasetPathOptionsFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetPathOptionsFactory, T3, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetPathOptionsFactory, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetPathOptionsFactory, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetPathOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetPathOptionsFactory, T1, T2, T3, T4, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1, T2, T3, T4>(this CombinedResult<InnerDatasetPathOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetPathOptionsFactory, T2, T3, T4, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetPathOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetPathOptionsFactory, T3, T4, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetPathOptionsFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetPathOptionsFactory, T4, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetPathOptionsFactory, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetPathOptionsFactory, InnerDatasetFilterExpressionFactory> WithLastModifiedDateCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetPathOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilterExpression> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastModifiedDateCondition(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDatasetPathOptionsFactory, T1, InnerDatasetFilesLimitFactory> WithFilesLimit<T1>(this CombinedResult<InnerDatasetPathOptionsFactory, T1> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilesLimit(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetPathOptionsFactory, InnerDatasetFilesLimitFactory> WithFilesLimit<T1>(this CombinedResult<T1, InnerDatasetPathOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilesLimit(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetPathOptionsFactory, T1, T2, InnerDatasetFilesLimitFactory> WithFilesLimit<T1, T2>(this CombinedResult<InnerDatasetPathOptionsFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilesLimit(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetPathOptionsFactory, T2, InnerDatasetFilesLimitFactory> WithFilesLimit<T1, T2>(this CombinedResult<T1, InnerDatasetPathOptionsFactory, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilesLimit(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetPathOptionsFactory, InnerDatasetFilesLimitFactory> WithFilesLimit<T1, T2>(this CombinedResult<T1, T2, InnerDatasetPathOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilesLimit(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetPathOptionsFactory, T1, T2, T3, InnerDatasetFilesLimitFactory> WithFilesLimit<T1, T2, T3>(this CombinedResult<InnerDatasetPathOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilesLimit(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetPathOptionsFactory, T2, T3, InnerDatasetFilesLimitFactory> WithFilesLimit<T1, T2, T3>(this CombinedResult<T1, InnerDatasetPathOptionsFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilesLimit(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetPathOptionsFactory, T3, InnerDatasetFilesLimitFactory> WithFilesLimit<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetPathOptionsFactory, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilesLimit(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetPathOptionsFactory, InnerDatasetFilesLimitFactory> WithFilesLimit<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetPathOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilesLimit(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetPathOptionsFactory, T1, T2, T3, T4, InnerDatasetFilesLimitFactory> WithFilesLimit<T1, T2, T3, T4>(this CombinedResult<InnerDatasetPathOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilesLimit(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetPathOptionsFactory, T2, T3, T4, InnerDatasetFilesLimitFactory> WithFilesLimit<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetPathOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilesLimit(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetPathOptionsFactory, T3, T4, InnerDatasetFilesLimitFactory> WithFilesLimit<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetPathOptionsFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilesLimit(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetPathOptionsFactory, T4, InnerDatasetFilesLimitFactory> WithFilesLimit<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetPathOptionsFactory, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilesLimit(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetPathOptionsFactory, InnerDatasetFilesLimitFactory> WithFilesLimit<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetPathOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.FilesLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilesLimit(combinedResult.T5, subFactoryAction));
}
