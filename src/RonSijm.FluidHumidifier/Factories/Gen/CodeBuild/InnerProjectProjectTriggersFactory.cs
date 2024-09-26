// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectProjectTriggersFactory(Action<Humidifier.CodeBuild.ProjectTypes.ProjectTriggers> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.ProjectTriggers>
{

    internal InnerProjectScopeConfigurationFactory ScopeConfigurationFactory { get; set; }

    protected override Humidifier.CodeBuild.ProjectTypes.ProjectTriggers Create()
    {
        var projectTriggersResult = CreateProjectTriggers();
        factoryAction?.Invoke(projectTriggersResult);

        return projectTriggersResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.ProjectTriggers CreateProjectTriggers()
    {
        var projectTriggersResult = new Humidifier.CodeBuild.ProjectTypes.ProjectTriggers();

        return projectTriggersResult;
    }
    public override void CreateChildren(Humidifier.CodeBuild.ProjectTypes.ProjectTriggers result)
    {
        base.CreateChildren(result);

        result.ScopeConfiguration ??= ScopeConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerProjectProjectTriggersFactoryExtensions
{
    public static CombinedResult<InnerProjectProjectTriggersFactory, InnerProjectScopeConfigurationFactory> WithScopeConfiguration(this InnerProjectProjectTriggersFactory parentFactory, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null)
    {
        parentFactory.ScopeConfigurationFactory = new InnerProjectScopeConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScopeConfigurationFactory);
    }

    public static CombinedResult<InnerProjectProjectTriggersFactory, T1, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1>(this CombinedResult<InnerProjectProjectTriggersFactory, T1> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectProjectTriggersFactory, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1>(this CombinedResult<T1, InnerProjectProjectTriggersFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerProjectProjectTriggersFactory, T1, T2, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1, T2>(this CombinedResult<InnerProjectProjectTriggersFactory, T1, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectProjectTriggersFactory, T2, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1, T2>(this CombinedResult<T1, InnerProjectProjectTriggersFactory, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectProjectTriggersFactory, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerProjectProjectTriggersFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerProjectProjectTriggersFactory, T1, T2, T3, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<InnerProjectProjectTriggersFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectProjectTriggersFactory, T2, T3, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerProjectProjectTriggersFactory, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectProjectTriggersFactory, T3, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerProjectProjectTriggersFactory, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectProjectTriggersFactory, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProjectProjectTriggersFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerProjectProjectTriggersFactory, T1, T2, T3, T4, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerProjectProjectTriggersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectProjectTriggersFactory, T2, T3, T4, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerProjectProjectTriggersFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectProjectTriggersFactory, T3, T4, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProjectProjectTriggersFactory, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectProjectTriggersFactory, T4, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProjectProjectTriggersFactory, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerProjectProjectTriggersFactory, InnerProjectScopeConfigurationFactory> WithScopeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProjectProjectTriggersFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeConfiguration(combinedResult.T5, subFactoryAction));
}
