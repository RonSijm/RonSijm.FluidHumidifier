// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class InnerApplicationApplicationResourceLifecycleConfigFactory(Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig>
{

    internal InnerApplicationApplicationVersionLifecycleConfigFactory VersionLifecycleConfigFactory { get; set; }

    protected override Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig Create()
    {
        var applicationResourceLifecycleConfigResult = CreateApplicationResourceLifecycleConfig();
        factoryAction?.Invoke(applicationResourceLifecycleConfigResult);

        return applicationResourceLifecycleConfigResult;
    }

    private Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig CreateApplicationResourceLifecycleConfig()
    {
        var applicationResourceLifecycleConfigResult = new Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig();

        return applicationResourceLifecycleConfigResult;
    }
    public override void CreateChildren(Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig result)
    {
        base.CreateChildren(result);

        result.VersionLifecycleConfig ??= VersionLifecycleConfigFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationApplicationResourceLifecycleConfigFactoryExtensions
{
    public static CombinedResult<InnerApplicationApplicationResourceLifecycleConfigFactory, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig(this InnerApplicationApplicationResourceLifecycleConfigFactory parentFactory, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null)
    {
        parentFactory.VersionLifecycleConfigFactory = new InnerApplicationApplicationVersionLifecycleConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VersionLifecycleConfigFactory);
    }

    public static CombinedResult<InnerApplicationApplicationResourceLifecycleConfigFactory, T1, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1>(this CombinedResult<InnerApplicationApplicationResourceLifecycleConfigFactory, T1> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationApplicationResourceLifecycleConfigFactory, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1>(this CombinedResult<T1, InnerApplicationApplicationResourceLifecycleConfigFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationApplicationResourceLifecycleConfigFactory, T1, T2, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1, T2>(this CombinedResult<InnerApplicationApplicationResourceLifecycleConfigFactory, T1, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationApplicationResourceLifecycleConfigFactory, T2, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1, T2>(this CombinedResult<T1, InnerApplicationApplicationResourceLifecycleConfigFactory, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationApplicationResourceLifecycleConfigFactory, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1, T2>(this CombinedResult<T1, T2, InnerApplicationApplicationResourceLifecycleConfigFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationApplicationResourceLifecycleConfigFactory, T1, T2, T3, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1, T2, T3>(this CombinedResult<InnerApplicationApplicationResourceLifecycleConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationApplicationResourceLifecycleConfigFactory, T2, T3, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1, T2, T3>(this CombinedResult<T1, InnerApplicationApplicationResourceLifecycleConfigFactory, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationApplicationResourceLifecycleConfigFactory, T3, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationApplicationResourceLifecycleConfigFactory, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationApplicationResourceLifecycleConfigFactory, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationApplicationResourceLifecycleConfigFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationApplicationResourceLifecycleConfigFactory, T1, T2, T3, T4, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1, T2, T3, T4>(this CombinedResult<InnerApplicationApplicationResourceLifecycleConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationApplicationResourceLifecycleConfigFactory, T2, T3, T4, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationApplicationResourceLifecycleConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationApplicationResourceLifecycleConfigFactory, T3, T4, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationApplicationResourceLifecycleConfigFactory, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationApplicationResourceLifecycleConfigFactory, T4, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationApplicationResourceLifecycleConfigFactory, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationApplicationResourceLifecycleConfigFactory, InnerApplicationApplicationVersionLifecycleConfigFactory> WithVersionLifecycleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationApplicationResourceLifecycleConfigFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationVersionLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVersionLifecycleConfig(combinedResult.T5, subFactoryAction));
}
