// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobEntityDetectorConfigurationFactory(Action<Humidifier.DataBrew.JobTypes.EntityDetectorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.EntityDetectorConfiguration>
{

    internal InnerJobAllowedStatisticsFactory AllowedStatisticsFactory { get; set; }

    protected override Humidifier.DataBrew.JobTypes.EntityDetectorConfiguration Create()
    {
        var entityDetectorConfigurationResult = CreateEntityDetectorConfiguration();
        factoryAction?.Invoke(entityDetectorConfigurationResult);

        return entityDetectorConfigurationResult;
    }

    private Humidifier.DataBrew.JobTypes.EntityDetectorConfiguration CreateEntityDetectorConfiguration()
    {
        var entityDetectorConfigurationResult = new Humidifier.DataBrew.JobTypes.EntityDetectorConfiguration();

        return entityDetectorConfigurationResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.JobTypes.EntityDetectorConfiguration result)
    {
        base.CreateChildren(result);

        result.AllowedStatistics ??= AllowedStatisticsFactory?.Build();
    }

} // End Of Class

public static class InnerJobEntityDetectorConfigurationFactoryExtensions
{
    public static CombinedResult<InnerJobEntityDetectorConfigurationFactory, InnerJobAllowedStatisticsFactory> WithAllowedStatistics(this InnerJobEntityDetectorConfigurationFactory parentFactory, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null)
    {
        parentFactory.AllowedStatisticsFactory = new InnerJobAllowedStatisticsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AllowedStatisticsFactory);
    }

    public static CombinedResult<InnerJobEntityDetectorConfigurationFactory, T1, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1>(this CombinedResult<InnerJobEntityDetectorConfigurationFactory, T1> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobEntityDetectorConfigurationFactory, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1>(this CombinedResult<T1, InnerJobEntityDetectorConfigurationFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobEntityDetectorConfigurationFactory, T1, T2, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1, T2>(this CombinedResult<InnerJobEntityDetectorConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobEntityDetectorConfigurationFactory, T2, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1, T2>(this CombinedResult<T1, InnerJobEntityDetectorConfigurationFactory, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobEntityDetectorConfigurationFactory, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1, T2>(this CombinedResult<T1, T2, InnerJobEntityDetectorConfigurationFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobEntityDetectorConfigurationFactory, T1, T2, T3, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1, T2, T3>(this CombinedResult<InnerJobEntityDetectorConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobEntityDetectorConfigurationFactory, T2, T3, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1, T2, T3>(this CombinedResult<T1, InnerJobEntityDetectorConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobEntityDetectorConfigurationFactory, T3, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobEntityDetectorConfigurationFactory, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobEntityDetectorConfigurationFactory, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobEntityDetectorConfigurationFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobEntityDetectorConfigurationFactory, T1, T2, T3, T4, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1, T2, T3, T4>(this CombinedResult<InnerJobEntityDetectorConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobEntityDetectorConfigurationFactory, T2, T3, T4, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobEntityDetectorConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobEntityDetectorConfigurationFactory, T3, T4, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobEntityDetectorConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobEntityDetectorConfigurationFactory, T4, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobEntityDetectorConfigurationFactory, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobEntityDetectorConfigurationFactory, InnerJobAllowedStatisticsFactory> WithAllowedStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobEntityDetectorConfigurationFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllowedStatistics(combinedResult.T5, subFactoryAction));
}
