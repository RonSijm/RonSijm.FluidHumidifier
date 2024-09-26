// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.ElasticBeanstalk.Application> factoryAction = null) : ResourceFactory<Humidifier.ElasticBeanstalk.Application>(resourceName)
{

    internal InnerApplicationApplicationResourceLifecycleConfigFactory ResourceLifecycleConfigFactory { get; set; }

    protected override Humidifier.ElasticBeanstalk.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.ElasticBeanstalk.Application CreateApplication()
    {
        var applicationResult = new Humidifier.ElasticBeanstalk.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }
    public override void CreateChildren(Humidifier.ElasticBeanstalk.Application result)
    {
        base.CreateChildren(result);

        result.ResourceLifecycleConfig ??= ResourceLifecycleConfigFactory?.Build();
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
    public static CombinedResult<ApplicationFactory, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig(this ApplicationFactory parentFactory, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null)
    {
        parentFactory.ResourceLifecycleConfigFactory = new InnerApplicationApplicationResourceLifecycleConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceLifecycleConfigFactory);
    }

    public static CombinedResult<ApplicationFactory, T1, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationApplicationResourceLifecycleConfigFactory> WithResourceLifecycleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationTypes.ApplicationResourceLifecycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceLifecycleConfig(combinedResult.T5, subFactoryAction));
}
