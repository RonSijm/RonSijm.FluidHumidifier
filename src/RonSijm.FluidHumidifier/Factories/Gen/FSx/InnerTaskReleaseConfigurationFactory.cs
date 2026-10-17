// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerTaskReleaseConfigurationFactory(Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.TaskTypes.ReleaseConfiguration>
{

    internal InnerTaskDurationSinceLastAccessFactory DurationSinceLastAccessFactory { get; set; }

    protected override Humidifier.FSx.TaskTypes.ReleaseConfiguration Create()
    {
        var releaseConfigurationResult = CreateReleaseConfiguration();
        factoryAction?.Invoke(releaseConfigurationResult);

        return releaseConfigurationResult;
    }

    private Humidifier.FSx.TaskTypes.ReleaseConfiguration CreateReleaseConfiguration()
    {
        var releaseConfigurationResult = new Humidifier.FSx.TaskTypes.ReleaseConfiguration();

        return releaseConfigurationResult;
    }
    public override void CreateChildren(Humidifier.FSx.TaskTypes.ReleaseConfiguration result)
    {
        base.CreateChildren(result);

        result.DurationSinceLastAccess ??= DurationSinceLastAccessFactory?.Build();
    }

} // End Of Class

public static class InnerTaskReleaseConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTaskReleaseConfigurationFactory, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess(this InnerTaskReleaseConfigurationFactory parentFactory, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null)
    {
        parentFactory.DurationSinceLastAccessFactory = new InnerTaskDurationSinceLastAccessFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DurationSinceLastAccessFactory);
    }

    public static CombinedResult<InnerTaskReleaseConfigurationFactory, T1, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1>(this CombinedResult<InnerTaskReleaseConfigurationFactory, T1> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTaskReleaseConfigurationFactory, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1>(this CombinedResult<T1, InnerTaskReleaseConfigurationFactory> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTaskReleaseConfigurationFactory, T1, T2, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1, T2>(this CombinedResult<InnerTaskReleaseConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTaskReleaseConfigurationFactory, T2, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1, T2>(this CombinedResult<T1, InnerTaskReleaseConfigurationFactory, T2> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTaskReleaseConfigurationFactory, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1, T2>(this CombinedResult<T1, T2, InnerTaskReleaseConfigurationFactory> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTaskReleaseConfigurationFactory, T1, T2, T3, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1, T2, T3>(this CombinedResult<InnerTaskReleaseConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTaskReleaseConfigurationFactory, T2, T3, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1, T2, T3>(this CombinedResult<T1, InnerTaskReleaseConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTaskReleaseConfigurationFactory, T3, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskReleaseConfigurationFactory, T3> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTaskReleaseConfigurationFactory, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskReleaseConfigurationFactory> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTaskReleaseConfigurationFactory, T1, T2, T3, T4, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1, T2, T3, T4>(this CombinedResult<InnerTaskReleaseConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTaskReleaseConfigurationFactory, T2, T3, T4, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskReleaseConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTaskReleaseConfigurationFactory, T3, T4, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskReleaseConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTaskReleaseConfigurationFactory, T4, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskReleaseConfigurationFactory, T4> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTaskReleaseConfigurationFactory, InnerTaskDurationSinceLastAccessFactory> WithDurationSinceLastAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskReleaseConfigurationFactory> combinedResult, Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDurationSinceLastAccess(combinedResult.T5, subFactoryAction).T2);
}
