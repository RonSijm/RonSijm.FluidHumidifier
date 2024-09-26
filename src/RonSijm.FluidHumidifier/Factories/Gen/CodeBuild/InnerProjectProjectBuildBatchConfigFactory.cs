// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectProjectBuildBatchConfigFactory(Action<Humidifier.CodeBuild.ProjectTypes.ProjectBuildBatchConfig> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.ProjectBuildBatchConfig>
{

    internal InnerProjectBatchRestrictionsFactory RestrictionsFactory { get; set; }

    protected override Humidifier.CodeBuild.ProjectTypes.ProjectBuildBatchConfig Create()
    {
        var projectBuildBatchConfigResult = CreateProjectBuildBatchConfig();
        factoryAction?.Invoke(projectBuildBatchConfigResult);

        return projectBuildBatchConfigResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.ProjectBuildBatchConfig CreateProjectBuildBatchConfig()
    {
        var projectBuildBatchConfigResult = new Humidifier.CodeBuild.ProjectTypes.ProjectBuildBatchConfig();

        return projectBuildBatchConfigResult;
    }
    public override void CreateChildren(Humidifier.CodeBuild.ProjectTypes.ProjectBuildBatchConfig result)
    {
        base.CreateChildren(result);

        result.Restrictions ??= RestrictionsFactory?.Build();
    }

} // End Of Class

public static class InnerProjectProjectBuildBatchConfigFactoryExtensions
{
    public static CombinedResult<InnerProjectProjectBuildBatchConfigFactory, InnerProjectBatchRestrictionsFactory> WithRestrictions(this InnerProjectProjectBuildBatchConfigFactory parentFactory, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null)
    {
        parentFactory.RestrictionsFactory = new InnerProjectBatchRestrictionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RestrictionsFactory);
    }

    public static CombinedResult<InnerProjectProjectBuildBatchConfigFactory, T1, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1>(this CombinedResult<InnerProjectProjectBuildBatchConfigFactory, T1> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, WithRestrictions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectProjectBuildBatchConfigFactory, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1>(this CombinedResult<T1, InnerProjectProjectBuildBatchConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, WithRestrictions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerProjectProjectBuildBatchConfigFactory, T1, T2, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1, T2>(this CombinedResult<InnerProjectProjectBuildBatchConfigFactory, T1, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectProjectBuildBatchConfigFactory, T2, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1, T2>(this CombinedResult<T1, InnerProjectProjectBuildBatchConfigFactory, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectProjectBuildBatchConfigFactory, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1, T2>(this CombinedResult<T1, T2, InnerProjectProjectBuildBatchConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerProjectProjectBuildBatchConfigFactory, T1, T2, T3, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1, T2, T3>(this CombinedResult<InnerProjectProjectBuildBatchConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectProjectBuildBatchConfigFactory, T2, T3, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1, T2, T3>(this CombinedResult<T1, InnerProjectProjectBuildBatchConfigFactory, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectProjectBuildBatchConfigFactory, T3, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1, T2, T3>(this CombinedResult<T1, T2, InnerProjectProjectBuildBatchConfigFactory, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectProjectBuildBatchConfigFactory, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProjectProjectBuildBatchConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerProjectProjectBuildBatchConfigFactory, T1, T2, T3, T4, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<InnerProjectProjectBuildBatchConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectProjectBuildBatchConfigFactory, T2, T3, T4, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<T1, InnerProjectProjectBuildBatchConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectProjectBuildBatchConfigFactory, T3, T4, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProjectProjectBuildBatchConfigFactory, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectProjectBuildBatchConfigFactory, T4, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProjectProjectBuildBatchConfigFactory, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerProjectProjectBuildBatchConfigFactory, InnerProjectBatchRestrictionsFactory> WithRestrictions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProjectProjectBuildBatchConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictions(combinedResult.T5, subFactoryAction));
}
